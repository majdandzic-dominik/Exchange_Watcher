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

            exchangeRatesDB = new MongoCRUD(exchangeRatesDatabase);
            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            List<ExchangeRate> exchangeRatesList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(exchangeRatesCollection, today);

            dgvExchangeRates.AutoGenerateColumns = false;
            dgvExchangeRates.DataSource = exchangeRatesList;

            PopulateChart();



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


        public void PopulateChart()
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
            

            List<double> middleRateValues = new List<double>();
            List<string> dateValues = new List<string>();
            foreach (var v in exchangeRatesList)
            {
                middleRateValues.Add(Convert.ToDouble(v.MiddleRate) * Convert.ToDouble(v.Unit));
                dateValues.Add(v.Date);
            }

            Func<double, string> formatFunc = (x) => string.Format("{0:0.0000}", x);
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date",
                Labels = dateValues
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Middle Rate [HRK]",
                //LabelFormatter = value => value.ToString("C"),
                LabelFormatter = formatFunc
            }); ;
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Top;
            SeriesCollection series = new SeriesCollection();
            series.Add(new LineSeries() { Title = "middle rate", Values = new ChartValues<double>(middleRateValues) });
            cartesianChart1.Series = series;
        }
       

        public void SetUser(User user)
        {
            loggedInUser = new User(user.UserName, user.UserNameUpper, user.Email, user.Password);
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
            PopulateChart();
        }

        private void cboDateSpan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateChart();
        }
    }
}
