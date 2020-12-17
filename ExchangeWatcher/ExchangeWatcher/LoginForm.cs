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
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(userDB.GetNumOfUsers<User>(userCollection, txtUserName.Text) > 0)
            {
                if(DoesPasswordMatch(userDB.GetUserPasswordHash(userCollection, txtUserName.Text), txtPassword.Text))
                {
                    lblErrorMsg.Text = "";
                    var f = new MainForm();
                    f.SetUserName(txtUserName.Text);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    lblErrorMsg.Text = "Invalid password";
                    lblErrorMsg.Visible = true;
                }
            }
            else
            {
                lblErrorMsg.Text = "User does not exist";
                lblErrorMsg.Visible = true;
            }
        }

        private bool DoesPasswordMatch(string hashedPassword, string password)
        {
            return BC.Verify(password, hashedPassword);
        }

    }
}
