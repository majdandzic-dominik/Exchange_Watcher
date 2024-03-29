﻿
namespace ExchangeWatcher
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbllAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.lbllAppName);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(274, 498);
            this.panelLeft.TabIndex = 0;
            // 
            // lbllAppName
            // 
            this.lbllAppName.AutoSize = true;
            this.lbllAppName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllAppName.ForeColor = System.Drawing.Color.White;
            this.lbllAppName.Location = new System.Drawing.Point(6, 333);
            this.lbllAppName.Name = "lbllAppName";
            this.lbllAppName.Size = new System.Drawing.Size(264, 33);
            this.lbllAppName.TabIndex = 1;
            this.lbllAppName.Text = "Exchange Watcher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.lblErrorMsg);
            this.panelRight.Controls.Add(this.lblExit);
            this.panelRight.Controls.Add(this.btnSignUp);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.txtConfirmPassword);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.txtUserName);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Controls.Add(this.panel4);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.lblEmail);
            this.panelRight.Controls.Add(this.lblLogIn);
            this.panelRight.Controls.Add(this.lblPassword2);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.lblUserName);
            this.panelRight.Controls.Add(this.lblSignUp);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(274, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(410, 498);
            this.panelRight.TabIndex = 1;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(40, 377);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(324, 17);
            this.lblErrorMsg.TabIndex = 7;
            this.lblErrorMsg.Text = "Error";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblExit.Location = new System.Drawing.Point(329, 468);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(78, 21);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "Go back";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(40, 397);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(324, 34);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 100);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(40, 328);
            this.txtConfirmPassword.MaxLength = 30;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(324, 19);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 252);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.txtUserName.Location = new System.Drawing.Point(40, 176);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel2.Location = new System.Drawing.Point(40, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel4.Location = new System.Drawing.Point(40, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 2);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel3.Location = new System.Drawing.Point(40, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 2);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(40, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 2);
            this.panel1.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblLogIn.Location = new System.Drawing.Point(88, 443);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(228, 17);
            this.lblLogIn.TabIndex = 5;
            this.lblLogIn.Text = "Have an account? Log in instead.";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblPassword2.Location = new System.Drawing.Point(36, 303);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(177, 22);
            this.lblPassword2.TabIndex = 3;
            this.lblPassword2.Text = "Re-Enter Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblPassword.Location = new System.Drawing.Point(36, 227);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblUserName.Location = new System.Drawing.Point(36, 151);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 22);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name:";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblSignUp.Location = new System.Drawing.Point(34, 19);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(110, 33);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 498);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllAppName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}