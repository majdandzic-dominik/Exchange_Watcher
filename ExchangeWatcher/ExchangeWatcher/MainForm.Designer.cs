
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotificationSettings = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblTableHeader = new System.Windows.Forms.Label();
            this.dgvExchangeRates = new System.Windows.Forms.DataGridView();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnNotificationSettings);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.lblTableHeader);
            this.panel1.Controls.Add(this.dgvExchangeRates);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 591);
            this.panel1.TabIndex = 2;
            // 
            // btnNotificationSettings
            // 
            this.btnNotificationSettings.BackColor = System.Drawing.Color.White;
            this.btnNotificationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnNotificationSettings.Location = new System.Drawing.Point(13, 401);
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
            this.lblLoggedInAs.Location = new System.Drawing.Point(9, 377);
            this.lblLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(112, 21);
            this.lblLoggedInAs.TabIndex = 9;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(27, 522);
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
            this.btnLogIn.Location = new System.Drawing.Point(13, 545);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(88, 34);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
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
            this.lblUserName.Location = new System.Drawing.Point(120, 377);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 21);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "user";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnSignOut.Location = new System.Drawing.Point(124, 545);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 34);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExchangeWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeRates)).EndInit();
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
    }
}

