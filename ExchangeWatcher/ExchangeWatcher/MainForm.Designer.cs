
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
            this.txtJSON = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtJSON
            // 
            this.txtJSON.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJSON.Location = new System.Drawing.Point(60, 31);
            this.txtJSON.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJSON.Multiline = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.ReadOnly = true;
            this.txtJSON.Size = new System.Drawing.Size(415, 408);
            this.txtJSON.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 519);
            this.Controls.Add(this.txtJSON);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "ExchangeWatcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJSON;
    }
}

