using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using ExchangeWatcherClassLibrary;

namespace ExchangeWatcher
{
    public partial class LogInForm : Form
    {
        private string userDatabase = "Users";
        private string userCollection = "UsersList";
        private MongoCRUD userDB;
        public LogInForm()
        {
            InitializeComponent();
        }
        private void LogInForm_Load(object sender, EventArgs e)
        {
            userDB = new MongoCRUD(userDatabase);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MainForm();
            f.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(AreAllInputsValid(txtUserName.Text.ToUpper(), txtPassword.Text))
            {
                this.Hide();
                var f = new MainForm();
                f.SetUser(userDB.GetUser(userCollection, txtUserName.Text.ToUpper()));
                f.Show();
            }
            else
            {
                lblErrorMsg.Text = GenerateErrorMessage(txtUserName.Text.ToUpper(), txtPassword.Text);
                lblErrorMsg.Visible = true;
            }

        }

        public bool AreAllInputsValid(string userNameUpper, string password)
        {
            return userDB.GetNumOfUsers<User>(userCollection, userNameUpper) > 0
                && DoesPasswordMatch(userDB.GetUserPasswordHash(userCollection, userNameUpper), password);
        }
        public bool DoesPasswordMatch(string hashedPassword, string password)
        {
            return BC.Verify(password, hashedPassword);
        }

        public string GenerateErrorMessage(string userNameUpper, string password)
        {
            if(!(userDB.GetNumOfUsers<User>(userCollection, userNameUpper) > 0))
            {
                return "User does not exist";
            }
            else if(!(DoesPasswordMatch(userDB.GetUserPasswordHash(userCollection, userNameUpper), password)))
            {
                return "Invalid password";
            }
            return "";
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new SignUpForm();
            f.Show();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
