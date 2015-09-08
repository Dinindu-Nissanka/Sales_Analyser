using MetroFramework.Forms;
using Modern_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAnalyser
{
    public partial class ChangePasswordWindow : MetroForm
    {
        private int type;
        private Main_Form form;

        private DataArranger da = new DataArranger();

        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        public ChangePasswordWindow(int type, Main_Form main_Form)
        {
            this.type = type;
            this.form = main_Form;
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            string username = this.textBox_Username.Text;
            string old_password = this.textBox_CurrentPassword.Text;
            string new_password_1 = this.textBox_NewPassword.Text;
            string new_password_2 = this.textBox_ReNewPassword.Text;

            bool result = da.changePassword(this.type, username, old_password, new_password_1, new_password_2, this);

            if (result) 
            {
                this.Close();
                this.form.Enabled = true;
            }

        }

        private void ChangePasswordWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.Enabled = true;
        }

    }
}
