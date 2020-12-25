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
            exchangeRatesDB = new MongoCRUD(exchangeRatesDatabase);
            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            List<ExchangeRate> exchangeRatesList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(exchangeRatesCollection, today);

            dgvExchangeRates.AutoGenerateColumns = false;
            dgvExchangeRates.DataSource = exchangeRatesList;



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
    }
}
