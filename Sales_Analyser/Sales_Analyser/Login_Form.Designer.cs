namespace SalesAnalyser
{
    partial class Login_Form
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
            this.label_Username = new MetroFramework.Controls.MetroLabel();
            this.label_Password = new MetroFramework.Controls.MetroLabel();
            this.textBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.button_Login = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(24, 122);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(68, 19);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(24, 169);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(63, 19);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Lines = new string[0];
            this.textBox_Username.Location = new System.Drawing.Point(192, 122);
            this.textBox_Username.MaxLength = 32767;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.PasswordChar = '\0';
            this.textBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Username.SelectedText = "";
            this.textBox_Username.Size = new System.Drawing.Size(157, 23);
            this.textBox_Username.TabIndex = 2;
            this.textBox_Username.UseSelectable = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Lines = new string[0];
            this.textBox_Password.Location = new System.Drawing.Point(192, 169);
            this.textBox_Password.MaxLength = 32767;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.Size = new System.Drawing.Size(157, 23);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSelectable = true;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(274, 230);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseSelectable = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 300);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Name = "Login_Form";
            this.Text = "Login ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label_Username;
        private MetroFramework.Controls.MetroLabel label_Password;
        private MetroFramework.Controls.MetroTextBox textBox_Username;
        private MetroFramework.Controls.MetroTextBox textBox_Password;
        private MetroFramework.Controls.MetroButton button_Login;
    }
}