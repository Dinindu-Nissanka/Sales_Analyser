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
    public partial class Login_Form : MetroForm
    {
        private int type;
        private DataArranger da = new DataArranger();
        private Main_Form form;

        public Login_Form(int type, Main_Form form)
        {
            this.type = type;
            this.form = form;
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        } 
        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = this.textBox_Username.Text;
            string password = this.textBox_Password.Text;
            string loggedName = da.checkLoginAuthentication(this.type, username, password,this);
            if (loggedName != null)
            {
                this.Close();
                this.form.Enabled = true;
                if (this.type == 1)
                {
                    this.form.adminLoginSuccessful(loggedName);
                }
                else if (this.type == 2)
                {
                    this.form.analysistLoginSuccessful(loggedName);
                }
                else
                {
                    this.form.reviewerLoginSuccessful(loggedName);
                }

            }
            else 
            {
                this.textBox_Username.Text = "";
                this.textBox_Password.Text = "";
            }
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.Enabled = true;
        }
    }
}
