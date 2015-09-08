namespace SalesAnalyser
{
    partial class ChangePasswordWindow
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
            this.label_CurrentPassword = new MetroFramework.Controls.MetroLabel();
            this.label_ReNewPassword = new MetroFramework.Controls.MetroLabel();
            this.label_NewPassword = new MetroFramework.Controls.MetroLabel();
            this.textBox_CurrentPassword = new MetroFramework.Controls.MetroTextBox();
            this.textBox_NewPassword = new MetroFramework.Controls.MetroTextBox();
            this.textBox_ReNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.button_Submit = new MetroFramework.Controls.MetroButton();
            this.textBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.label_Username = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label_CurrentPassword
            // 
            this.label_CurrentPassword.AutoSize = true;
            this.label_CurrentPassword.Location = new System.Drawing.Point(23, 147);
            this.label_CurrentPassword.Name = "label_CurrentPassword";
            this.label_CurrentPassword.Size = new System.Drawing.Size(145, 19);
            this.label_CurrentPassword.TabIndex = 0;
            this.label_CurrentPassword.Text = "Enter Current Password";
            // 
            // label_ReNewPassword
            // 
            this.label_ReNewPassword.AutoSize = true;
            this.label_ReNewPassword.Location = new System.Drawing.Point(23, 231);
            this.label_ReNewPassword.Name = "label_ReNewPassword";
            this.label_ReNewPassword.Size = new System.Drawing.Size(148, 19);
            this.label_ReNewPassword.TabIndex = 1;
            this.label_ReNewPassword.Text = "Re-Enter New Password";
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Location = new System.Drawing.Point(23, 188);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(127, 19);
            this.label_NewPassword.TabIndex = 2;
            this.label_NewPassword.Text = "Enter New Password";
            // 
            // textBox_CurrentPassword
            // 
            this.textBox_CurrentPassword.Lines = new string[0];
            this.textBox_CurrentPassword.Location = new System.Drawing.Point(255, 143);
            this.textBox_CurrentPassword.MaxLength = 32767;
            this.textBox_CurrentPassword.Name = "textBox_CurrentPassword";
            this.textBox_CurrentPassword.PasswordChar = '*';
            this.textBox_CurrentPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_CurrentPassword.SelectedText = "";
            this.textBox_CurrentPassword.Size = new System.Drawing.Size(176, 23);
            this.textBox_CurrentPassword.TabIndex = 3;
            this.textBox_CurrentPassword.UseSelectable = true;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Lines = new string[0];
            this.textBox_NewPassword.Location = new System.Drawing.Point(255, 184);
            this.textBox_NewPassword.MaxLength = 32767;
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.PasswordChar = '*';
            this.textBox_NewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_NewPassword.SelectedText = "";
            this.textBox_NewPassword.Size = new System.Drawing.Size(176, 23);
            this.textBox_NewPassword.TabIndex = 4;
            this.textBox_NewPassword.UseSelectable = true;
            // 
            // textBox_ReNewPassword
            // 
            this.textBox_ReNewPassword.Lines = new string[0];
            this.textBox_ReNewPassword.Location = new System.Drawing.Point(255, 227);
            this.textBox_ReNewPassword.MaxLength = 32767;
            this.textBox_ReNewPassword.Name = "textBox_ReNewPassword";
            this.textBox_ReNewPassword.PasswordChar = '*';
            this.textBox_ReNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_ReNewPassword.SelectedText = "";
            this.textBox_ReNewPassword.Size = new System.Drawing.Size(176, 23);
            this.textBox_ReNewPassword.TabIndex = 5;
            this.textBox_ReNewPassword.UseSelectable = true;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(356, 275);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 6;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseSelectable = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Lines = new string[0];
            this.textBox_Username.Location = new System.Drawing.Point(255, 102);
            this.textBox_Username.MaxLength = 32767;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.PasswordChar = '\0';
            this.textBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Username.SelectedText = "";
            this.textBox_Username.Size = new System.Drawing.Size(176, 23);
            this.textBox_Username.TabIndex = 8;
            this.textBox_Username.UseSelectable = true;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(23, 106);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(102, 19);
            this.label_Username.TabIndex = 7;
            this.label_Username.Text = "Enter Username";
            // 
            // ChangePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 321);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_ReNewPassword);
            this.Controls.Add(this.textBox_NewPassword);
            this.Controls.Add(this.textBox_CurrentPassword);
            this.Controls.Add(this.label_NewPassword);
            this.Controls.Add(this.label_ReNewPassword);
            this.Controls.Add(this.label_CurrentPassword);
            this.Name = "ChangePasswordWindow";
            this.Text = "Change Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswordWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label_CurrentPassword;
        private MetroFramework.Controls.MetroLabel label_ReNewPassword;
        private MetroFramework.Controls.MetroLabel label_NewPassword;
        private MetroFramework.Controls.MetroTextBox textBox_CurrentPassword;
        private MetroFramework.Controls.MetroTextBox textBox_NewPassword;
        private MetroFramework.Controls.MetroTextBox textBox_ReNewPassword;
        private MetroFramework.Controls.MetroButton button_Submit;
        private MetroFramework.Controls.MetroTextBox textBox_Username;
        private MetroFramework.Controls.MetroLabel label_Username;
    }
}