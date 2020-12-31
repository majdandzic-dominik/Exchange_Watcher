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
using ExchangeWatcherClassLibrary;

namespace ExchangeWatcher
{
    public partial class EmailNotifierForm : Form
    {
        private string userDatabase = "Users";
        private string userCollection = "UsersList";
        private MongoCRUD userDB;
        private User loggedInUser = new User();

        public EmailNotifierForm()
        {
            InitializeComponent();
        }

        private void EmailNotifierForm_Load(object sender, EventArgs e)
        {
            cboCurrency.SelectedIndex = 0;
            userDB = new MongoCRUD(userDatabase);
            dgvNotifications.AutoGenerateColumns = false;

            SetNotificationTable();

            lblErrorMsg.MaximumSize = new Size(293, 51);
            lblErrorMsg.AutoSize = true;
        }

        private void SetNotificationTable()
        {
            dgvNotifications.DataSource = userDB.GetUser(userCollection, loggedInUser.UserNameUpper).Notifications;
            dgvNotifications.ClearSelection();
        }
        
        private void EmailNotifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MainForm();
            f.SetUser(loggedInUser);
            f.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(Convert.ToDouble(numChange.Value), cboCurrency.Text);
            if(!userDB.DoesNotificationExist(userCollection, loggedInUser, notification))
            {
                loggedInUser.addNotification(notification);            
                userDB.UpdateUser(userCollection, loggedInUser);
                SetNotificationTable();
                lblErrorMsg.Visible = false;
            }
            else
            {
                lblErrorMsg.Text = "Entry already exists. Please press update if you would like to update the tracked change or delete if you would like to delete the entry";
                lblErrorMsg.Visible = true;
            }      
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(Convert.ToDouble(numChange.Value), cboCurrency.Text);
            if (userDB.DoesNotificationExist(userCollection, loggedInUser, notification))
            {
                loggedInUser.updateNotificationByCurrency(notification.Currency, notification.PercentageChange);
                userDB.UpdateUser(userCollection, loggedInUser);
                SetNotificationTable();
                lblErrorMsg.Visible = false;
            }
            else
            {
                lblErrorMsg.Text = "No such entry exists. Make sure that the email and currency match the values from the table";
                lblErrorMsg.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(Convert.ToDouble(numChange.Value), cboCurrency.Text);
            if (userDB.DoesNotificationExist(userCollection, loggedInUser, notification))
            {
                loggedInUser.deleteNotificationByCurrency(notification.Currency);
                userDB.UpdateUser(userCollection, loggedInUser);
                SetNotificationTable();
                lblErrorMsg.Visible = false;
            }
            else
            {
                lblErrorMsg.Text = "No such entry exists. Make sure that the email and currency match the values from the table";
                lblErrorMsg.Visible = true;
            }
        }

        public void SetUser(User user)
        {
            this.loggedInUser = new User(user.UserName, user.UserNameUpper, user.Email, user.Password, user.Notifications);
        }
    }
}
