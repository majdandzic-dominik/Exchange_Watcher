
namespace ExchangeWatcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblGraphHeader = new System.Windows.Forms.Label();
            this.cboDateSpan = new System.Windows.Forms.ComboBox();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.lblTableHeader = new System.Windows.Forms.Label();
            this.dgvExchangeRates = new System.Windows.Forms.DataGridView();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnNotificationSettings = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lbllAppName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTimePeriod);
            this.panel1.Controls.Add(this.lblCurrency);
            this.panel1.Controls.Add(this.lblGraphHeader);
            this.panel1.Controls.Add(this.cboDateSpan);
            this.panel1.Controls.Add(this.cboCurrency);
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Controls.Add(this.lblTableHeader);
            this.panel1.Controls.Add(this.dgvExchangeRates);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.btnNotificationSettings);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 464);
            this.panel1.TabIndex = 2;
            // 
            // lbllAppName
            // 
            this.lbllAppName.AutoSize = true;
            this.lbllAppName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllAppName.ForeColor = System.Drawing.Color.White;
            this.lbllAppName.Location = new System.Drawing.Point(25, 386);
            this.lbllAppName.Name = "lbllAppName";
            this.lbllAppName.Size = new System.Drawing.Size(145, 66);
            this.lbllAppName.TabIndex = 19;
            this.lbllAppName.Text = "Exchange\r\nWatcher";
            this.lbllAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePeriod.ForeColor = System.Drawing.Color.White;
            this.lblTimePeriod.Location = new System.Drawing.Point(294, 425);
            this.lblTimePeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(104, 21);
            this.lblTimePeriod.TabIndex = 17;
            this.lblTimePeriod.Text = "Time period:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(313, 387);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(85, 21);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "Currency:";
            // 
            // lblGraphHeader
            // 
            this.lblGraphHeader.AutoSize = true;
            this.lblGraphHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphHeader.ForeColor = System.Drawing.Color.White;
            this.lblGraphHeader.Location = new System.Drawing.Point(362, 11);
            this.lblGraphHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGraphHeader.Name = "lblGraphHeader";
            this.lblGraphHeader.Size = new System.Drawing.Size(383, 25);
            this.lblGraphHeader.TabIndex = 15;
            this.lblGraphHeader.Text = "Middle rate change over time graph";
            // 
            // cboDateSpan
            // 
            this.cboDateSpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateSpan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateSpan.FormattingEnabled = true;
            this.cboDateSpan.Items.AddRange(new object[] {
            "Past week",
            "Past month",
            "Past year"});
            this.cboDateSpan.Location = new System.Drawing.Point(405, 423);
            this.cboDateSpan.Name = "cboDateSpan";
            this.cboDateSpan.Size = new System.Drawing.Size(121, 29);
            this.cboDateSpan.TabIndex = 14;
            this.cboDateSpan.SelectionChangeCommitted += new System.EventHandler(this.cboDateSpan_SelectionChangeCommitted);
            // 
            // cboCurrency
            // 
            this.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
            "AUD",
            "BAM",
            "CAD",
            "CHF",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HUF",
            "JPY",
            "NOK",
            "PLN",
            "SEK",
            "USD"});
            this.cboCurrency.Location = new System.Drawing.Point(405, 384);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(69, 29);
            this.cboCurrency.Sorted = true;
            this.cboCurrency.TabIndex = 13;
            this.cboCurrency.SelectionChangeCommitted += new System.EventHandler(this.cboCurrency_SelectionChangeCommitted);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.White;
            this.cartesianChart1.Location = new System.Drawing.Point(296, 39);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(515, 335);
            this.cartesianChart1.TabIndex = 12;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // lblTableHeader
            // 
            this.lblTableHeader.AutoSize = true;
            this.lblTableHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableHeader.ForeColor = System.Drawing.Color.White;
            this.lblTableHeader.Location = new System.Drawing.Point(43, 11);
            this.lblTableHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableHeader.Name = "lblTableHeader";
            this.lblTableHeader.Size = new System.Drawing.Size(215, 25);
            this.lblTableHeader.TabIndex = 4;
            this.lblTableHeader.Text = "Todays middle rates";
            // 
            // dgvExchangeRates
            // 
            this.dgvExchangeRates.AllowUserToAddRows = false;
            this.dgvExchangeRates.AllowUserToDeleteRows = false;
            this.dgvExchangeRates.AllowUserToResizeColumns = false;
            this.dgvExchangeRates.AllowUserToResizeRows = false;
            this.dgvExchangeRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExchangeRates.BackgroundColor = System.Drawing.Color.White;
            this.dgvExchangeRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExchangeRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Currency,
            this.MiddleRate});
            this.dgvExchangeRates.Location = new System.Drawing.Point(13, 39);
            this.dgvExchangeRates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvExchangeRates.Name = "dgvExchangeRates";
            this.dgvExchangeRates.ReadOnly = true;
            this.dgvExchangeRates.RowHeadersVisible = false;
            this.dgvExchangeRates.Size = new System.Drawing.Size(274, 335);
            this.dgvExchangeRates.TabIndex = 3;
            // 
            // Currency
            // 
            this.Currency.DataPropertyName = "Currency";
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // MiddleRate
            // 
            this.MiddleRate.DataPropertyName = "MiddleRate";
            this.MiddleRate.HeaderText = "Middle Rate";
            this.MiddleRate.Name = "MiddleRate";
            this.MiddleRate.ReadOnly = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(638, 416);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 21);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "user";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(657, 426);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(61, 20);
            this.lblSignUp.TabIndex = 8;
            this.lblSignUp.Text = "Sign up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.White;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnLogIn.Location = new System.Drawing.Point(724, 419);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(88, 34);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnNotificationSettings
            // 
            this.btnNotificationSettings.BackColor = System.Drawing.Color.White;
            this.btnNotificationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnNotificationSettings.Location = new System.Drawing.Point(537, 379);
            this.btnNotificationSettings.Name = "btnNotificationSettings";
            this.btnNotificationSettings.Size = new System.Drawing.Size(274, 34);
            this.btnNotificationSettings.TabIndex = 10;
            this.btnNotificationSettings.Text = "Change notificaton settings";
            this.btnNotificationSettings.UseVisualStyleBackColor = false;
            this.btnNotificationSettings.Click += new System.EventHandler(this.btnNotificationSettings_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInAs.Location = new System.Drawing.Point(533, 416);
            this.lblLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(112, 21);
            this.lblLoggedInAs.TabIndex = 9;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnSignOut.Location = new System.Drawing.Point(723, 434);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 26);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.White;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblExit.Location = new System.Drawing.Point(798, -1);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 23);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(824, 25);
            this.panelHeader.TabIndex = 19;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExchangeWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTableHeader;
        private System.Windows.Forms.DataGridView dgvExchangeRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleRate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnNotificationSettings;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ComboBox cboCurrency;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox cboDateSpan;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblGraphHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllAppName;
    }
}

