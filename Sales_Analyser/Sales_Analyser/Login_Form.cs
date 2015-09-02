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


        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = this.textBox_Username.Text;
            string password = this.textBox_Password.Text;
            string loggedName = da.checkLoginAuthentication(this.type, username, password,this);
            if (loggedName!=null)
            {
                this.Hide();
                this.form.Enabled = true;
                if (this.type == 1) 
                {
                    this.form.adminLoginSuccessful(loggedName);
                }
                else if (this.type == 2)
                {
                    this.form.analysistLoginSuccessful(loggedName);
                }
                
            }/*
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Login attempt failed" + "\n" + "Username or Password is incorrect", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png" + "|All image files (*.jpg, *.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    //PictureBox1.Image = new Bitmap(dlg.FileName);
                    Console.WriteLine(dlg.SafeFileName);
                    //Console.WriteLine(dlg.);
                }
            }*/
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.Enabled = true;
        }
    }
}
