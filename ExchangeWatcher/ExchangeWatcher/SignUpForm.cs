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
                    if(IsValidUserNameLength(txtUserName.Text))
                    {
                        lblErrorMsg.Text = "User name has to be atleast 4 characters.";
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
                

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUserNameLength(string userName)
        {
            return userName.Length > 3;
        }
        private bool IsValidPasswordLength(string password)
        {
            return password.Length > 7;
        }

        private bool DoesPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        private string GeneratePasswordHash(string password)
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
