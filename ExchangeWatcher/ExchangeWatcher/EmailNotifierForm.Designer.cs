
namespace ExchangeWatcher
{
    partial class EmailNotifierForm
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelEmailLine = new System.Windows.Forms.Panel();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelBackground.Controls.Add(this.btnUpdate);
            this.panelBackground.Controls.Add(this.lblErrorMsg);
            this.panelBackground.Controls.Add(this.lblExit);
            this.panelBackground.Controls.Add(this.btnDelete);
            this.panelBackground.Controls.Add(this.btnInsert);
            this.panelBackground.Controls.Add(this.panelEmailLine);
            this.panelBackground.Controls.Add(this.numChange);
            this.panelBackground.Controls.Add(this.txtEmail);
            this.panelBackground.Controls.Add(this.lblChange);
            this.panelBackground.Controls.Add(this.lblCurrency);
            this.panelBackground.Controls.Add(this.lblEmail);
            this.panelBackground.Controls.Add(this.cboCurrency);
            this.panelBackground.Controls.Add(this.dgvNotifications);
            this.panelBackground.Location = new System.Drawing.Point(10, 12);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(874, 308);
            this.panelBackground.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnUpdate.Location = new System.Drawing.Point(134, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(30, 217);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(293, 51);
            this.lblErrorMsg.TabIndex = 11;
            this.lblErrorMsg.Text = "Error";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(5, 278);
            this.lblExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(78, 21);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Go back";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnDelete.Location = new System.Drawing.Point(235, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnInsert.Location = new System.Drawing.Point(33, 180);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 34);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panelEmailLine
            // 
            this.panelEmailLine.BackColor = System.Drawing.Color.White;
            this.panelEmailLine.Location = new System.Drawing.Point(81, 52);
            this.panelEmailLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEmailLine.Name = "panelEmailLine";
            this.panelEmailLine.Size = new System.Drawing.Size(242, 1);
            this.panelEmailLine.TabIndex = 6;
            // 
            // numChange
            // 
            this.numChange.BackColor = System.Drawing.Color.White;
            this.numChange.DecimalPlaces = 3;
            this.numChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.numChange.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numChange.Location = new System.Drawing.Point(140, 129);
            this.numChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numChange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numChange.Name = "numChange";
            this.numChange.Size = new System.Drawing.Size(140, 27);
            this.numChange.TabIndex = 7;
            this.numChange.Value = new decimal(new int[] {
            1000,
            0,
            0,
            196608});
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(81, 27);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(29, 131);
            this.lblChange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(103, 21);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "Change[%]:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(29, 80);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(85, 21);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "Currency:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(29, 27);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // cboCurrency
            // 
            this.cboCurrency.BackColor = System.Drawing.Color.White;
            this.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
            "AUD",
            "CAD",
            "CZK",
            "DKK",
            "HUF",
            "JPY",
            "NOK",
            "SEK",
            "CHF",
            "GBP",
            "USD",
            "BAM",
            "EUR",
            "PLN"});
            this.cboCurrency.Location = new System.Drawing.Point(122, 77);
            this.cboCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(140, 29);
            this.cboCurrency.TabIndex = 1;
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeColumns = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Currency,
            this.Change});
            this.dgvNotifications.Location = new System.Drawing.Point(350, 14);
            this.dgvNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.Size = new System.Drawing.Size(511, 280);
            this.dgvNotifications.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Currency
            // 
            this.Currency.DataPropertyName = "Currency";
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "PercentageChange";
            this.Change.HeaderText = "Change[%]";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            // 
            // EmailNotifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 331);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmailNotifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailNotifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailNotifier_FormClosing);
            this.Load += new System.EventHandler(this.EmailNotifierForm_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelEmailLine;
        private System.Windows.Forms.NumericUpDown numChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.Button btnUpdate;
    }
}