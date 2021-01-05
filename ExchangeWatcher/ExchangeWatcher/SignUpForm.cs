using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using ExchangeWatcherClassLibrary;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ExchangeWatcher
{
    public partial class SignUpForm : Form
    {
        private string userDatabase = "Users";
        private string userCollection = "UsersList";
        private MongoCRUD userDB;

        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            userDB = new MongoCRUD(userDatabase);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MainForm();
            f.Show();
        }

        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
            {

                if(IsValidUserNameLength(txtUserName.Text) && IsValidPasswordLength(txtPassword.Text))
                {

                    if (IsValidPasswordFormat(txtPassword.Text))
                    { 

                        if(DoesPasswordMatch(txtPassword.Text, txtConfirmPassword.Text))
                        {                        
                            lblErrorMsg.Text = userDB.GetUserLogInErrorMsg<User>(userCollection, txtUserName.Text.ToUpper(), txtEmail.Text);
                            lblErrorMsg.Visible = true;
                            
                            if(lblErrorMsg.Text == "") //if there are no errors
                            {
                                User user = new User(txtUserName.Text, txtUserName.Text.ToUpper(), txtEmail.Text, GeneratePasswordHash(txtPassword.Text), new List<Notification>());
                                userDB.InsertData<User>(userCollection, user);
                                this.Hide();
                                var f = new MainForm();
                                f.SetUser(user);
                                f.Show();
                            }
                        }
                        else
                        {
                            lblErrorMsg.Text = "The passwords do not match";
                            lblErrorMsg.Visible = true;
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Password cannot contain spaces";
                        lblErrorMsg.Visible = true;
                    }
                }
                else
                {
                    if(!IsValidUserNameLength(txtUserName.Text))
                    {
                        lblErrorMsg.Text = "User name has to be atleast 4 characters";
                        lblErrorMsg.Visible = true;
                    }
                    else
                    {
                        lblErrorMsg.Text = "Password needs to be atlest 8 characters";
                        lblErrorMsg.Visible = true;
                    }
                }
            }
            else
            {
                lblErrorMsg.Text = "Invalid email format";
                lblErrorMsg.Visible = true;
            }
        }
                

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool IsValidUserNameLength(string userName)
        {
            return userName.Length > 3;
        }
        public bool IsValidPasswordLength(string password)
        {
            return password.Length > 7;
        }
        public bool IsValidPasswordFormat(string password)
        {
            return !password.Any(c => Char.IsWhiteSpace(c));
        }
        public bool DoesPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        public string GeneratePasswordHash(string password)
        {
            return BC.HashPassword(password, BC.GenerateSalt());
        }


        private void lblLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new LogInForm();
            f.Show();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
