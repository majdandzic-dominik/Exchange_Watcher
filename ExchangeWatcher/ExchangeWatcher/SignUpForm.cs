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

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            userDB = new MongoCRUD(userDatabase);
        }

        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) && txtUserName.Text != null && txtPassword.Text != null && txtConfirmPassword.Text != null)
            {
                if(txtPassword.Text.Length > 7 && txtUserName.Text.Length > 3)
                {
                    if(txtPassword.Text == txtConfirmPassword.Text)
                    {
                        User user = new User(txtUserName.Text, txtEmail.Text, GeneratePasswordHash(txtPassword.Text));
                        lblErrorMsg.Text = userDB.InsertUserIfNotExist<User>(userCollection, user, user.UserName, user.Email);
                        lblErrorMsg.Visible = true;
                    }
                    else
                    {
                        lblErrorMsg.Text = "The passwords do not match";
                        lblErrorMsg.Visible = true;
                    }
                }
                else
                {
                    if(txtUserName.Text.Length <= 3)
                    {
                        lblErrorMsg.Text = "User name has to be atleast 4 characters. Password needs to be atlest 8 characters";
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

        private string GeneratePasswordHash(string password)
        {
            return BC.HashPassword(password, BC.GenerateSalt());
        }

    }
}
