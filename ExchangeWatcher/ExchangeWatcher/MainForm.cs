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

namespace ExchangeWatcher
{
    public partial class MainForm : Form
    {
        private string loggedInUser = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {        


        }


        public void SetUserName(string userName)
        {
            loggedInUser = userName;
            lblUserName.Text = userName;
        }
    }
}
