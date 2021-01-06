using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using ExchangeWatcherClassLibrary;
using LiveCharts;
using LiveCharts.Wpf;

namespace ExchangeWatcher
{
    public partial class MainForm : Form
    {
        private User loggedInUser = new User();
        private string exchangeRatesDatabase = "ExchangeRates";
        private string exchangeRatesCollection = "ExchangeRatesList";
        private MongoCRUD exchangeRatesDB;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboCurrency.SelectedIndex = 0;
            cboDateSpan.SelectedIndex = 0;

            PopulateTable();

            PopulateGraph();

            //set visible items based on wether the user is logged in or not
            if(loggedInUser.UserName != "")
            {
                lblUserName.Visible = true;
                lblLoggedInAs.Visible = true;
                btnLogIn.Visible = false;
                lblSignUp.Visible = false;
                btnNotificationSettings.Visible = true;
                btnSignOut.Visible = true;
            }
            else
            {
                lblUserName.Visible = false;
                lblLoggedInAs.Visible = false;
                btnLogIn.Visible = true;
                lblSignUp.Visible = true;
                btnNotificationSettings.Visible = false;
                btnSignOut.Visible = false;
            }
            
        }

        public void PopulateTable()
        {
            exchangeRatesDB = new MongoCRUD(exchangeRatesDatabase);
            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            List<ExchangeRate> exchangeRatesList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(exchangeRatesCollection, today);

            foreach (var rate in exchangeRatesList)
            {
                rate.MiddleRate = (Convert.ToDouble(rate.MiddleRate) * Convert.ToDouble(rate.Unit)).ToString();
            }

            dgvExchangeRates.AutoGenerateColumns = false;
            dgvExchangeRates.DataSource = exchangeRatesList;
            dgvExchangeRates.ClearSelection();
        }
        public void PopulateGraph()
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string beforeDate;
            if (cboDateSpan.SelectedIndex == 0)
            {
                beforeDate = DateTime.UtcNow.AddDays(-7).ToString("yyyy-MM-dd");
            }
            else if (cboDateSpan.SelectedIndex == 1)
            {
                beforeDate = DateTime.UtcNow.AddDays(-30).ToString("yyyy-MM-dd");
            }
            else
            {
                beforeDate = DateTime.UtcNow.AddDays(-365).ToString("yyyy-MM-dd");
            }

            List<ExchangeRate> exchangeRatesList = exchangeRatesDB.LoadRecordsInDateRange<ExchangeRate>(exchangeRatesCollection, today, beforeDate, cboCurrency.Text);
            

            var middleRateValues = GetMiddleRatesListFromExchangeRates(exchangeRatesList);
            var dateValues = GetDateListFromExchangeRates(exchangeRatesList);

            SetGraphValues(dateValues, middleRateValues);
        }

        public List<string> GetDateListFromExchangeRates(List<ExchangeRate> exchangeRatesList)
        {
            List<string> dateValues = new List<string>();

            foreach (var v in exchangeRatesList)
            {
                dateValues.Add(v.Date);
            }

            return dateValues;
        }
        public List<double> GetMiddleRatesListFromExchangeRates(List<ExchangeRate> exchangeRatesList)
        {
            List<double> middleRateValues = new List<double>();

            foreach (var v in exchangeRatesList)
            {
                middleRateValues.Add(Convert.ToDouble(v.MiddleRate) * Convert.ToDouble(v.Unit));
            }

            return middleRateValues;
        }

        public void SetGraphValues(List<string> dateValues, List<double> middleRateValues)
        {
            Func<double, string> formatFunc = (x) => string.Format("{0:0.0000}", x);
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date",
                Labels = dateValues
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Middle Rate [HRK]",
                LabelFormatter = formatFunc
            }); ;
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Top;
            SeriesCollection series = new SeriesCollection();
            series.Add(new LineSeries() { Title = $"{cboCurrency.Text} middle rates", Values = new ChartValues<double>(middleRateValues) });
            cartesianChart1.Series = series;
        }

        //set logged in user
        public void SetUser(User user)
        {
            loggedInUser = new User(user.UserName, user.UserNameUpper, user.Email, user.Password, user.Notifications);
            lblUserName.Text = loggedInUser.UserName;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new LogInForm();
            f.Show();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new SignUpForm();
            f.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNotificationSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new EmailNotifierForm();
            f.SetUser(loggedInUser);
            f.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MainForm();
            f.SetUser(new User());
            f.Show();
        }

        
        private void cboCurrency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateGraph();
        }

        private void cboDateSpan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateGraph();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
