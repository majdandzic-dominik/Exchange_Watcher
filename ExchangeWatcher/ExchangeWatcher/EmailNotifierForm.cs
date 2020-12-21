using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeWatcher
{
    public partial class EmailNotifierForm : Form
    {
        private string userDatabase = "Users";
        private string userCollection = "EmailNotifications";
        private MongoCRUD userDB;
        public EmailNotifierForm()
        {
            InitializeComponent();
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

        private void EmailNotifierForm_Load(object sender, EventArgs e)
        {
            cboCurrency.SelectedIndex = 0;
        }
    }
}
