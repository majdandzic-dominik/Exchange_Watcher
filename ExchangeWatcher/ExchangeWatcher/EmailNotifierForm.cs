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

namespace ExchangeWatcher
{
    public partial class EmailNotifierForm : Form
    {
        private string userDatabase = "Users";
        private string emailCollection = "EmailNotifications";
        private MongoCRUD userDB;
        private string userName = "testUser";

        public EmailNotifierForm()
        {
            InitializeComponent();
        }

        private void EmailNotifierForm_Load(object sender, EventArgs e)
        {
            cboCurrency.SelectedIndex = 0;
            userDB = new MongoCRUD(userDatabase);
            dgvNotifications.AutoGenerateColumns = false;
            dgvNotifications.DataSource = userDB.LoadAllRecords<Notification>(emailCollection);

            lblErrorMsg.MaximumSize = new Size(293, 51);
            lblErrorMsg.AutoSize = true;
        }
        
        private void EmailNotifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MainForm();
            f.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(txtEmail.Text))
            {
                Notification notification = new Notification(txtEmail.Text, userName, Convert.ToDouble(numChange.Value), cboCurrency.Text);
                if(!userDB.DoesNotificationExist(emailCollection, notification))
                {
                    userDB.InsertNotification(emailCollection, notification);
                    dgvNotifications.DataSource = userDB.LoadAllRecords<Notification>(emailCollection);
                    lblErrorMsg.Visible = false;
                }
                else
                {
                    lblErrorMsg.Text = "Entry already exists. Please press update if you would like to update the tracked change or delete if you would like to delete the entry";
                    lblErrorMsg.Visible = true;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
            {
                Notification notification = new Notification(txtEmail.Text, userName, Convert.ToDouble(numChange.Value), cboCurrency.Text);
                if (userDB.DoesNotificationExist(emailCollection, notification))
                {
                    userDB.UpdateNotification(emailCollection, notification);
                    dgvNotifications.DataSource = userDB.LoadAllRecords<Notification>(emailCollection);
                    lblErrorMsg.Visible = false;
                }
                else
                {
                    lblErrorMsg.Text = "No such entry exists. Make sure that the email and currency match the values from the table";
                    lblErrorMsg.Visible = true;
                }
            }
            else
            {
                lblErrorMsg.Text = "Invalid email format";
                lblErrorMsg.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
            {
                Notification notification = new Notification(txtEmail.Text, userName, Convert.ToDouble(numChange.Value), cboCurrency.Text);
                if (userDB.DoesNotificationExist(emailCollection, notification))
                {
                    userDB.DeleteNotification(emailCollection, notification);
                    dgvNotifications.DataSource = userDB.LoadAllRecords<Notification>(emailCollection);
                    lblErrorMsg.Visible = false;
                }
                else
                {
                    lblErrorMsg.Text = "No such entry exists. Make sure that the email and currency match the values from the table";
                    lblErrorMsg.Visible = true;
                }
            }
            else
            {
                lblErrorMsg.Text = "Invalid email format";
                lblErrorMsg.Visible = true;
            }
        }
    }
}
