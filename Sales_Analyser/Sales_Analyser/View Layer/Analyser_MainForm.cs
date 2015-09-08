using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using SalesAnalyser;
using System.Reflection;

namespace Modern_UI
{
    public partial class Main_Form : MetroForm
    {
        #region Private Variables of the Form

        public const int DEFAULT_IGNORE = 3;
        public const int DEFAULT_HOLDOUT = 6;
        private DataArranger dataArranger = new DataArranger();
        private DateTime[] chart_xdata;
        private double[] chart_ydata;
        private int chart_point_count = 10;
        private int forecasted_yData_type = 0;
        private int forecasting_type = 0;
        private string image_file_path;
        private string image_file_name;
        private int chart_sales_data_type;
        private bool isMonth;
        private bool isSeason;
        private bool isAllData;

        private string info = "Value: " + "#VAL{N2}" + "\n" + "Average: " + "#AVG{N2}" + "\n" + "Minimum: " + "#MIN{N2}" + "\n" + "Maximum: " + "#MAX{N2}" + "\n"
            + "First: " + "#FIRST{N2}" + "\n" + "Last: " + "#LAST{N2}" + "\n" + "Date: " + "#VALX";


        #endregion
        
        public Main_Form()
        {
            InitializeComponent();
            this.panel_choice.Show();
            this.panel_Analyst.Hide();
            this.panel_pastData.Hide();
            this.button_logout.Hide();
            this.label_LoggedName.Hide();
            this.panel_Chart.Hide();
            this.panel_Admin.Hide();
            this.panel_ForecastedData.Hide();
            this.panel_NewAdmin.Hide();
            this.panel_NewAnalysist.Hide();
            this.panel_NewDealer.Hide();
            this.panel_NewReviewer.Hide();
            this.panel_Reviewer.Hide();
            this.panel_Reviews.Hide();
            loadCountries();
            init_Charts();
            loadComboBoxes();
            this.tile_reviewer.BackColor = Color.OrangeRed;
            this.tile_reviewer.UseVisualStyleBackColor = true;
            this.tile_admin.BackColor = Color.SlateBlue;
            this.tile_admin.UseVisualStyleBackColor = true;
            this.tile_analyst.BackColor = Color.MediumVioletRed;
            this.tile_analyst.UseVisualStyleBackColor = true;
            this.panel_choice.BackColor = Color.Transparent;

            this.tile_newAdmin.BackColor = Color.OrangeRed;
            this.tile_newAdmin.UseVisualStyleBackColor = true;
            this.tile_newDealer.BackColor = Color.SlateBlue;
            this.tile_newDealer.UseVisualStyleBackColor = true;
            this.tile_newAnalysist.BackColor = Color.MediumVioletRed;
            this.tile_newAnalysist.UseVisualStyleBackColor = true;
            this.tile_NewReviewer.BackColor = Color.MediumSeaGreen;
            this.tile_NewReviewer.UseVisualStyleBackColor = true;
            this.tile_AdminChangePassword.BackColor = Color.Turquoise;
            this.tile_AdminChangePassword.UseVisualStyleBackColor = true;

            this.tile_PastSalesDataGrid.BackColor = Color.OrangeRed;
            this.tile_PastSalesDataGrid.UseVisualStyleBackColor = true;
            this.tile_PastSalesDataGraph.BackColor = Color.SlateBlue;
            this.tile_PastSalesDataGraph.UseVisualStyleBackColor = true;
            this.tile_ForecastedData.BackColor = Color.MediumVioletRed;
            this.tile_ForecastedData.UseVisualStyleBackColor = true;
            this.tile_AnalysistChangePassword.BackColor = Color.Turquoise;
            this.tile_AnalysistChangePassword.UseVisualStyleBackColor = true;

            this.tile_ViewReviews.BackColor = Color.OrangeRed;
            this.tile_ViewReviews.UseVisualStyleBackColor = true;
            this.tile_ReviewerChangePassword.BackColor = Color.Turquoise;
            this.tile_ReviewerChangePassword.UseVisualStyleBackColor = true;

        }
        
        /*
         * Methods to load combo boxes and other components before
         * form load
         */
        #region Loading Component When Form created

        /*
         * Method to load countries to combo boxes
         */
        public void loadCountries()
        {
            List<Country> country_list = dataArranger.getAllCountries();
            if (country_list != null)
            {
                for (int i = 0; i < country_list.Count; i++)
                {
                    this.comboBox_pastDataCountry.Items.Add(country_list.ElementAt(i));
                    this.comboBox_ChartCountry.Items.Add(country_list.ElementAt(i));
                    this.comboBox_ForecastedCountry.Items.Add(country_list.ElementAt(i));
                }
                this.comboBox_pastDataCountry.SelectedIndex = 0;
                this.comboBox_ChartCountry.SelectedIndex = 0;
                this.comboBox_ForecastedCountry.SelectedIndex = 0;
            }
            else 
            {
                Console.WriteLine("Countries were not fully loaded");
            }
        }

        /*
         * Method to load other combo boxes
         */
        public void loadComboBoxes()
        {
            comboBox_RegressionType.Items.Clear();

            comboBox_RegressionType.Items.Add("None");
            comboBox_RegressionType.Items.Add("Linear");
            comboBox_RegressionType.Items.Add("Exponential");
            comboBox_RegressionType.Items.Add("Logarithmic");
            comboBox_RegressionType.Items.Add("Power");

            comboBox_RegressionType.SelectedIndex = 0;

            comboBox_ChartType.Items.Clear();

            comboBox_ChartType.Items.Add("Points");
            comboBox_ChartType.Items.Add("Line");
            comboBox_ChartType.Items.Add("Spline");
            comboBox_ChartType.Items.Add("Column");
            comboBox_ChartType.Items.Add("Area");

            comboBox_ChartType.SelectedIndex = 0;

            comboBox_RegressionChartType.Items.Add("Line");
            comboBox_RegressionChartType.Items.Add("Points");
            comboBox_RegressionChartType.Items.Add("Spline");
            comboBox_RegressionChartType.Items.Add("Column");
            comboBox_RegressionChartType.Items.Add("Area");

            comboBox_RegressionChartType.SelectedIndex = 0;

            comboBox_ForecastingType.Items.Add("Naive");
            comboBox_ForecastingType.Items.Add("Simple Moving Average");
            comboBox_ForecastingType.Items.Add("Weighted Moving Average");
            comboBox_ForecastingType.Items.Add("Adaptive Rate Smoothing");
            comboBox_ForecastingType.Items.Add("Exponential Smoothing");

            comboBox_ForecastingType.SelectedIndex = 0;
        }

        /*
         * Event listener for the logout button
         */
        private void button_logout_Click(object sender, EventArgs e)
        {
            this.button_logout.Hide();
            this.label_LoggedName.Text = "";
            this.label_LoggedName.Hide();
            this.panel_Analyst.Hide();
            this.panel_Admin.Hide();
            this.panel_Reviewer.Hide();
            this.panel_choice.Show();
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
        

        /*
        * Initialize Chart components
        * Create and Configure Chart Series
       */
        public void init_Charts()
        {
            this.chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.Point;
            this.chart_PastData.Series["Past Sales Data"].Color = Color.DarkMagenta;
            chart_PastData.Series["Past Sales Data"].ToolTip = "Sales Data point" + "\n" + info;


            this.chart_PastData.Series["Regression Series"].ChartType =
                                SeriesChartType.FastLine;
            this.chart_PastData.Series["Regression Series"].Color = Color.SteelBlue;

            this.chart_PastData.Series["Series3"].ChartType =
                                SeriesChartType.FastLine;
            this.chart_PastData.Series["Series3"].Color = Color.Orange;
            this.chart_PastData.Series["Series3"].Enabled = false;

            this.chart_PastData.Series["Series4"].ChartType =
                                SeriesChartType.FastLine;
            this.chart_PastData.Series["Series4"].Color = Color.Olive;
            this.chart_PastData.Series["Series4"].Enabled = false;


        }

        #endregion


        /*
         * Main window panel
         * This is the first window open in the application
         */
        #region Main Panel

        /*
         * Event listener for the Admin tile
         */
        private void tile_admin_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form(1, this);
            login.Show();
            this.Enabled = false;
        }

        /*
         * Event listener for the Analysist tile
         */
        private void tile_analyst_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form(2, this);
            login.Show();
            this.Enabled = false;
        }

        /*
         * Event listener for the mouse hover action in admin tile
         */
        private void tile_admin_MouseHover(object sender, EventArgs e)
        {
            this.tile_admin.BackColor = Color.MediumSlateBlue;
        }

        /*
         * Event listener for the mouse leave action in admin tile
         */
        private void tile_admin_MouseLeave(object sender, EventArgs e)
        {
            this.tile_admin.BackColor = Color.SlateBlue;
        }

        /*
         * Event listener for the mouse hover action in analysist tile
         */
        private void tile_analyst_MouseHover(object sender, EventArgs e)
        {
            this.tile_analyst.BackColor = Color.PaleVioletRed;
        }

        /*
         * Event listener for the mouse leave action in analysist tile
         */
        private void tile_analyst_MouseLeave(object sender, EventArgs e)
        {
            this.tile_analyst.BackColor = Color.MediumVioletRed;
        }

        /*
         * Event listener for the mouse hover action in review analyser tile
         */
        private void tile_reviewer_MouseLeave(object sender, EventArgs e)
        {
            this.tile_reviewer.BackColor = Color.OrangeRed;
        }

        /*
         * Event listener for the mouse leave action in review analyser tile
         */
        private void tile_reviewer_MouseHover(object sender, EventArgs e)
        {
            this.tile_reviewer.BackColor = Color.Orange;
        }

        /*
         * Event listener for the Review Analyser tile
         */
        private void tile_reviewer_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Login_Form login = new Login_Form(3, this);
            login.Show();
        }

        /*
         * Method to do after successful login of an anlysist
         */
        public void analysistLoginSuccessful(string name)
        {
            this.panel_choice.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }

        /*
         * Method to do after successful login of an admin
         */
        public void adminLoginSuccessful(string name)
        {
            this.panel_choice.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }

        /*
         * Method to do after successful login of a review analyser
         */
        public void reviewerLoginSuccessful(string name)
        {
            this.panel_choice.Hide();
            this.panel_Reviewer.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }


        #endregion


        /*
         * Admin Panel
         * This is the panel pop up after an admin login to the system
         */
        #region Admin Panel

        /*
         * Event listener for new admin tile
         */
        private void tile_newAdmin_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewAdmin.Show();
            this.button_logout.Hide();
        }

        /*
         * Event listener for new dealer tile
         */
        private void tile_newDealer_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewDealer.Show();
            this.button_logout.Hide();
        }

        /*
         * Event listener for new analysist tile
         */
        private void tile_newAnalysist_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewAnalysist.Show();
            this.button_logout.Hide();
        }

        /*
         * Event listener for new review analyser tile
         */
        private void tile_NewReviewer_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewReviewer.Show();
            this.button_logout.Hide();
        }

        /*
         * Event listener for chnage password tile
         */
        private void tile_AdminChangePassword_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ChangePasswordWindow password_change = new ChangePasswordWindow(1, this);
            password_change.Show();
        }

        private void tile_newAdmin_MouseHover(object sender, EventArgs e)
        {
            this.tile_newAdmin.BackColor = Color.DarkOrange;
        }

        private void tile_newAdmin_MouseLeave(object sender, EventArgs e)
        {
            this.tile_newAdmin.BackColor = Color.OrangeRed;
        }

        private void tile_newAnalysist_MouseHover(object sender, EventArgs e)
        {
            this.tile_newAnalysist.BackColor = Color.PaleVioletRed;
        }

        private void tile_newAnalysist_MouseLeave(object sender, EventArgs e)
        {
            this.tile_newAnalysist.BackColor = Color.MediumVioletRed;
        }

        private void tile_newDealer_MouseHover(object sender, EventArgs e)
        {
            this.tile_newDealer.BackColor = Color.MediumSlateBlue;
        }

        private void tile_newDealer_MouseLeave(object sender, EventArgs e)
        {
            this.tile_newDealer.BackColor = Color.SlateBlue;
        }

        private void tile_newReviewer_MouseHover(object sender, EventArgs e)
        {
            this.tile_NewReviewer.BackColor = Color.LightSeaGreen;
        }

        private void tile_newReviewer_MouseLeave(object sender, EventArgs e)
        {
            this.tile_NewReviewer.BackColor = Color.MediumSeaGreen;
        }

        private void tile_AdminChangePassword_MouseHover(object sender, EventArgs e)
        {
            this.tile_AdminChangePassword.BackColor = Color.PaleTurquoise;
        }

        private void tile_AdminChangePassword_MouseLeave(object sender, EventArgs e)
        {
            this.tile_AdminChangePassword.BackColor = Color.Turquoise;
        }

        #endregion

        #region Analysist Panel

        private void tile_PastSalesData_Click(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_pastData.Show();
            this.button_logout.Hide();
        }

        private void tile_ForecastedData_Click(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_Chart.Show();
            this.chart_PastData.Hide();
            this.button_logout.Hide();
        }

        private void tile_ForecastedData_Click_2(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_ForecastedData.Show();
            this.panel_forecastedGrid.Hide();
            this.button_logout.Hide();
        }

        private void button_BackAnalysist_Click(object sender, EventArgs e)
        {
            this.panel_NewAnalysist.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        private void tile_AnalysistChangePassword_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ChangePasswordWindow password_change = new ChangePasswordWindow(2, this);
            password_change.Show();
        }

        private void tile_PastSalesDataGrid_MouseHover(object sender, EventArgs e)
        {
            this.tile_PastSalesDataGrid.BackColor = Color.Orange;
        }

        private void tile_PastSalesDataGrid_MouseLeave(object sender, EventArgs e)
        {
            this.tile_PastSalesDataGrid.BackColor = Color.OrangeRed;
        }

        private void tile_PastSalesDataGraph_MouseHover(object sender, EventArgs e)
        {
            this.tile_PastSalesDataGraph.BackColor = Color.MediumSlateBlue;
        }

        private void tile_PastSalesDataGraph_MouseLeave(object sender, EventArgs e)
        {
            this.tile_PastSalesDataGraph.BackColor = Color.SlateBlue;
        }

        private void tile_ForecastedData_MouseHover(object sender, EventArgs e)
        {
            this.tile_ForecastedData.BackColor = Color.PaleVioletRed;
        }

        private void tile_ForecastedData_MouseLeave(object sender, EventArgs e)
        {
            this.tile_ForecastedData.BackColor = Color.MediumVioletRed;
        }

        private void tile_AnalysistChangePassword_MouseHover(object sender, EventArgs e)
        {
            this.tile_AnalysistChangePassword.BackColor = Color.MediumTurquoise;
        }

        private void tile_AnalysistChangePassword_MouseLeave(object sender, EventArgs e)
        {
            this.tile_AnalysistChangePassword.BackColor = Color.Turquoise;
        }

        #endregion

        #region Review Analyser Panel

        private void tile_ReviewerChangePassword_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ChangePasswordWindow password_change = new ChangePasswordWindow(3, this);
            password_change.Show();
        }

        private void tile_ViewReviews_Click(object sender, EventArgs e)
        {
            DataSet ds = dataArranger.getReviews();
            grid_CustomerReviews.DataSource = ds.Tables[0].DefaultView;
            grid_CustomerReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.panel_Reviewer.Hide();
            this.panel_Reviews.Show();
            this.button_logout.Hide();
        }

        private void pictureBox_ReviewPanelBack_Click(object sender, EventArgs e)
        {
            this.panel_Reviews.Hide();
            this.panel_Reviewer.Show();
            this.button_logout.Show();
        }

        private void tile_ViewReviews_MouseHover(object sender, EventArgs e)
        {
            this.tile_ViewReviews.BackColor = Color.Orange;
        }

        private void tile_ViewReviews_MouseLeave(object sender, EventArgs e)
        {
            this.tile_ViewReviews.BackColor = Color.OrangeRed;
        }

        private void tile_ReviewerChangePassword_MouseHover(object sender, EventArgs e)
        {
            this.tile_ReviewerChangePassword.BackColor = Color.PaleTurquoise;
        }

        private void tile_ReviewerChangePassword_MouseLeave(object sender, EventArgs e)
        {
            this.tile_ReviewerChangePassword.BackColor = Color.Turquoise;
        }

        #endregion

        #region New Admin Create Panel

        private void button_SubmitNewAdmin_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameAdmin.Text;
            string email = this.textBox_EmailAdmin.Text;
            string username = this.textBox_UsernameAdmin.Text;
            string password1 = this.textBox_PasswordAdmin.Text;
            string password2 = this.textBox_RePasswordAdmin.Text;

            int result = dataArranger.checkNewAccountdetails(1, name, email, username, password1, password2, this, null, null);
            if (result == 0)
            {
                this.textBox_NameAdmin.Text = "";
                this.textBox_EmailAdmin.Text = "";
                this.textBox_UsernameAdmin.Text = "";
                this.textBox_PasswordAdmin.Text = "";
                this.textBox_RePasswordAdmin.Text = "";
            }
        }

        private void pictureBox_NewAdminBack_Click(object sender, EventArgs e)
        {
            this.panel_NewAdmin.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        #endregion

        #region New Analysist Create Panel

        private void button_SubmitNewAnalysist_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameAnalysist.Text;
            string email = this.textBox_EmailAnalysist.Text;
            string username = this.textBox_UsernameAnalysist.Text;
            string password1 = this.textBox_PasswordAnalysist.Text;
            string password2 = this.textBox_RePasswordAnalysist.Text;

            int result = dataArranger.checkNewAccountdetails(2, name, email, username, password1, password2, this, null, null);
            if (result == 0)
            {
                this.textBox_NameAnalysist.Text = "";
                this.textBox_EmailAnalysist.Text = "";
                this.textBox_UsernameAnalysist.Text = "";
                this.textBox_PasswordAnalysist.Text = "";
                this.textBox_RePasswordAnalysist.Text = "";
            }
        }

        #endregion

        #region New Dealer Create Panel

        private void button_SubmitNewDealer_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameDealer.Text;
            string email = this.textBox_EmailDealer.Text;
            string username = this.textBox_UsernameDealer.Text;
            string password1 = this.textBox_PasswordDealer.Text;
            string password2 = this.textBox_RePasswordDealer.Text;
            if (this.textBox_ImageUpload.Text.Equals(""))
            {
                this.image_file_name = "";
                this.image_file_path = null;
            }

            int result = dataArranger.checkNewAccountdetails(3, name, email, username, password1, password2, this, image_file_path, image_file_name);
            if (result == 0)
            {
                this.textBox_NameDealer.Text = "";
                this.textBox_EmailDealer.Text = "";
                this.textBox_UsernameDealer.Text = "";
                this.textBox_PasswordDealer.Text = "";
                this.textBox_RePasswordDealer.Text = "";
                this.textBox_ImageUpload.Text = "";
            }
        }

        private void button_ImageBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Image Files|*.jpg;*.png;*.jpeg|JPG Images (*.jpg)|*.jpg|JPEG Images (*.jpeg)|*.jpeg|PNG Images (*.png)|*.png";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                image_file_path = file;
                image_file_name = openFileDialog1.SafeFileName;
                this.textBox_ImageUpload.Text = file;
            }
        }

        private void button_BackDealer_Click(object sender, EventArgs e)
        {
            this.panel_NewDealer.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        #endregion

        #region New Review Analyser Create Panel

        private void pictureBox_NewReviewer_Click(object sender, EventArgs e)
        {
            this.panel_NewReviewer.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        private void button_SubmitNewReviewer_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameReviewer.Text;
            string email = this.textBox_EmailReviewer.Text;
            string username = this.textBox_UsernameReviewer.Text;
            string password1 = this.textBox_PasswordReviewer.Text;
            string password2 = this.textBox_RePassReviewer.Text;

            int result = dataArranger.checkNewAccountdetails(4, name, email, username, password1, password2, this, null, null);
            if (result == 0)
            {
                this.textBox_NameReviewer.Text = "";
                this.textBox_EmailReviewer.Text = "";
                this.textBox_UsernameReviewer.Text = "";
                this.textBox_PasswordReviewer.Text = "";
                this.textBox_RePassReviewer.Text = "";
            }
        }


        #endregion

        #region Past Sales Data Grid View Panel

        private void comboBox_pastDataCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCountryID = (comboBox_pastDataCountry.SelectedItem as Country).country_id;
            List<Region> regionList = dataArranger.getRegionsOfCountry(selectedCountryID);
            this.comboBox_PastDataRegion.Items.Clear();
            for (int i = 0; i < regionList.Count; i++)
            {
                this.comboBox_PastDataRegion.Items.Add(regionList.ElementAt(i));
            }
            comboBox_PastDataRegion.SelectedIndex = 0;
        }

        private void button_pastSalesData_Click(object sender, EventArgs e)
        {
            if (comboBox_PastDataRegion.SelectedItem != null)
            {
                string selected_region = (comboBox_PastDataRegion.SelectedItem as Region).region_name.ToString();
                int region_id = (comboBox_PastDataRegion.SelectedItem as Region).region_id;

                DataSet ds = dataArranger.getRegionData(region_id);
                grid_pastData.DataSource = ds.Tables[0].DefaultView;
            }

        }

        private void button_PastDataBack_Click(object sender, EventArgs e)
        {
            this.panel_pastData.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }

        #endregion

        #region Past Sales Data Chart View Panel

        private void comboBox_ChartCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCountryID = (comboBox_ChartCountry.SelectedItem as Country).country_id;
            List<Region> regionList = dataArranger.getRegionsOfCountry(selectedCountryID);
            this.comboBox_ChartRegion.Items.Clear();
            for (int i = 0; i < regionList.Count; i++)
            {
                this.comboBox_ChartRegion.Items.Add(regionList.ElementAt(i));
            }
            comboBox_ChartRegion.SelectedIndex = 0;
        }

        private void radioButton_ChartQuantity_CheckedChanged(object sender, EventArgs e)
        {
            this.chart_sales_data_type = 1;
        }

        private void radioButton_ChartIncome_CheckedChanged(object sender, EventArgs e)
        {
            this.chart_sales_data_type = 2;
        }

        private void radioButton_ChartMonth_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = true;
            isSeason = false;
            isAllData = false;
            comboBox_ChartXAxis.Items.Clear();
            var americanCulture = new CultureInfo("en-US");
            comboBox_ChartXAxis.Items.AddRange(americanCulture.DateTimeFormat.MonthNames);
            comboBox_ChartXAxis.SelectedIndex = 0;
            comboBox_ChartXAxis.Enabled = true;
        }

        private void radioButton_ChartSeason_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = false;
            isSeason = true;
            isAllData = false;
            comboBox_ChartXAxis.Items.Clear();

            comboBox_ChartXAxis.Items.Add("Winter");
            comboBox_ChartXAxis.Items.Add("Spring");
            comboBox_ChartXAxis.Items.Add("Summer");
            comboBox_ChartXAxis.Items.Add("Autumn");

            comboBox_ChartXAxis.SelectedIndex = 0;
            comboBox_ChartXAxis.Enabled = true;
        }

        private void button_ViewChart_Click(object sender, EventArgs e)
        {
            int month_min = 0;
            int month_max = 0;
            if (isMonth)
            {
                month_min = comboBox_ChartXAxis.SelectedIndex + 1;
                month_max = 25;
            }
            else if (isSeason)
            {
                if (comboBox_ChartXAxis.SelectedIndex == 0)
                {
                    month_min = 1;
                    month_max = 3;
                }
                else if (comboBox_ChartXAxis.SelectedIndex == 1)
                {
                    month_min = 4;
                    month_max = 6;
                }
                else if (comboBox_ChartXAxis.SelectedIndex == 2)
                {
                    month_min = 7;
                    month_max = 9;
                }
                else
                {
                    month_min = 10;
                    month_max = 12;
                }
            }
            else
            {
                month_min = 0;
                month_max = 0;
            }
            if (comboBox_ChartRegion.SelectedItem != null)
            {
                int region_id = (comboBox_ChartRegion.SelectedItem as Region).region_id;

                List<SalesData> chart_axis_data = dataArranger.getGraphData(region_id, chart_sales_data_type, month_min, month_max);

                chart_ydata = new double[chart_axis_data.Count];
                chart_xdata = new DateTime[chart_axis_data.Count];

                if (this.chart_sales_data_type == 1)
                {
                    for (int i = 0; i < chart_axis_data.Count; i++)
                    {
                        chart_ydata[i] = chart_axis_data.ElementAt(i).quantity;
                        chart_xdata[i] = chart_axis_data.ElementAt(i).date_of_sale;
                    }
                }
                else
                {
                    for (int i = 0; i < chart_axis_data.Count; i++)
                    {
                        chart_ydata[i] = chart_axis_data.ElementAt(i).total_income;
                        chart_xdata[i] = chart_axis_data.ElementAt(i).date_of_sale;
                    }
                }

                chart_PastData.Series["Past Sales Data"].Points.Clear();
                chart_PastData.Series["Regression Series"].Points.Clear();
                chart_PastData.Series["Series3"].Points.Clear();
                chart_PastData.Series["Past Sales Data"].XValueType = ChartValueType.DateTime;
                for (int i = 0; i < chart_xdata.Length; i++)
                {
                    this.chart_PastData.Series["Past Sales Data"].Points.AddXY(chart_xdata[i], chart_ydata[i]);
                }

                this.chart_PastData.Show();
            }
        }

        private void pictureBox_ChartBack_Click(object sender, EventArgs e)
        {
            this.panel_Chart.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }

        private void radioButton_AllData_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = false;
            isSeason = false;
            isAllData = true;
            comboBox_ChartXAxis.Enabled = false;

        }

        private void comboBox_RegressionType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_RegressionType.SelectedIndex == 0)
            {
                //if(panel_Chart.s)
                chart_PastData.Series["Regression Series"].Points.Clear();
                chart_PastData.Series["Series3"].Points.Clear();
            }

            else if (comboBox_RegressionType.SelectedIndex == 1)
            {
                chart_PastData.Series["Regression Series"].ToolTip = "Linear Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("2," + chart_point_count + ",true,true"), "Past Sales Data:Y", "Regression Series:Y,Series3:Y,Series3:Y");

            }
            else if (comboBox_RegressionType.SelectedIndex == 2)
            {
                chart_PastData.Series["Regression Series"].ToolTip = "Exponential Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("3," + chart_point_count + ",true,true"), "Past Sales Data:Y", "Regression Series:Y,Series3:Y,Series3:Y");
            }
            else if (comboBox_RegressionType.SelectedIndex == 3)
            {
                chart_PastData.Series["Regression Series"].ToolTip = "Logarithmic Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("4," + chart_point_count + ",true,true"), "Past Sales Data:Y", "Regression Series:Y,Series3:Y,Series3:Y");
            }
            else
            {
                chart_PastData.Series["Regression Series"].ToolTip = "Power Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("5," + chart_point_count + ",true,true"), "Past Sales Data:Y", "Regression Series:Y,Series3:Y,Series3:Y");
            }
        }

        private void comboBox_ChartType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_ChartType.SelectedIndex == 0)
            {
                chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.FastPoint;
            }

            else if (comboBox_ChartType.SelectedIndex == 1)
            {
                chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.FastLine; //SeriesChartType.FastLine;
            }
            else if (comboBox_ChartType.SelectedIndex == 2)
            {
                chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.Spline;
            }
            else if (comboBox_ChartType.SelectedIndex == 3)
            {
                chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart_PastData.Series["Past Sales Data"].ChartType = SeriesChartType.Area;
            }
        }

        private void comboBox_RegressionChartType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_RegressionChartType.SelectedIndex == 0)
            {
                chart_PastData.Series["Regression Series"].ChartType = SeriesChartType.FastLine;
            }

            else if (comboBox_RegressionChartType.SelectedIndex == 1)
            {
                chart_PastData.Series["Regression Series"].ChartType = SeriesChartType.FastPoint; //SeriesChartType.FastLine;
            }
            else if (comboBox_RegressionChartType.SelectedIndex == 2)
            {
                chart_PastData.Series["Regression Series"].ChartType = SeriesChartType.Spline;
            }
            else if (comboBox_RegressionChartType.SelectedIndex == 3)
            {
                chart_PastData.Series["Regression Series"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart_PastData.Series["Regression Series"].ChartType = SeriesChartType.Area;
            }
        }

        #endregion

        #region Forecasted Sales Data View Panel

        private void comboBox_ForecastedCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCountryID = (comboBox_ForecastedCountry.SelectedItem as Country).country_id;
            List<Region> regionList = dataArranger.getRegionsOfCountry(selectedCountryID);
            this.comboBox_ForecastedRegion.Items.Clear();
            for (int i = 0; i < regionList.Count; i++)
            {
                this.comboBox_ForecastedRegion.Items.Add(regionList.ElementAt(i));
            }
            comboBox_ForecastedRegion.SelectedIndex = 0;
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.forecasted_yData_type = 1;
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.forecasted_yData_type = 2;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = true;
            isSeason = false;
            comboBox_ForecastedDateRange.Items.Clear();
            var americanCulture = new CultureInfo("en-US");
            comboBox_ForecastedDateRange.Items.AddRange(americanCulture.DateTimeFormat.MonthNames);
            comboBox_ForecastedDateRange.SelectedIndex = 0;
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = false;
            isSeason = true;
            comboBox_ForecastedDateRange.Items.Clear();

            comboBox_ForecastedDateRange.Items.Add("Winter");
            comboBox_ForecastedDateRange.Items.Add("Spring");
            comboBox_ForecastedDateRange.Items.Add("Summer");
            comboBox_ForecastedDateRange.Items.Add("Autumn");

            comboBox_ForecastedDateRange.SelectedIndex = 0;
        }

        private void button_ForecastedDataView_Click_1(object sender, EventArgs e)
        {
            int month_min = 0;
            int month_max = 0;
            if (isMonth)
            {
                month_min = comboBox_ForecastedDateRange.SelectedIndex + 1;
                month_max = 25;
            }
            else
            {
                if (comboBox_ForecastedDateRange.SelectedIndex == 0)
                {
                    month_min = 1;
                    month_max = 3;
                }
                else if (comboBox_ForecastedDateRange.SelectedIndex == 1)
                {
                    month_min = 4;
                    month_max = 6;
                }
                else if (comboBox_ForecastedDateRange.SelectedIndex == 2)
                {
                    month_min = 7;
                    month_max = 9;
                }
                else
                {
                    month_min = 10;
                    month_max = 12;
                }
            }
            if (comboBox_ForecastedRegion.SelectedItem != null)
            {
                int region_id = (comboBox_ForecastedRegion.SelectedItem as Region).region_id;
                int forecastingType = comboBox_ForecastingType.SelectedIndex;
                string number = textBox_ForecastingNumber.Text;

                ForecastTable ft = dataArranger.getForecastTable(region_id, forecasted_yData_type, month_min, month_max, forecastingType, number, this);
                this.grid_ForecastedData.DataSource = ft;


                if (ft != null)
                {
                    this.panel_forecastedGrid.Show();
                    ForecastingMethods fm = new ForecastingMethods();
                    this.textBox_MSE.Text = fm.MeanSignedError(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_MAE.Text = fm.MeanAbsoluteError(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_MPE.Text = fm.MeanPercentError(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_MAPE.Text = fm.MeanAbsolutePercentError(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_TS.Text = fm.TrackingSignal(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_MSqE.Text = fm.MeanSquaredError(ft, false, DEFAULT_IGNORE, 0).ToString();
                    this.textBox_CSE.Text = fm.CumulativeSignedError(ft, false, DEFAULT_IGNORE).ToString();
                    this.textBox_CAE.Text = fm.CumulativeAbsoluteError(ft, false, DEFAULT_IGNORE).ToString();
                }

            }
        }

        private void pictureBox_ForecastedBack_Click(object sender, EventArgs e)
        {
            this.panel_ForecastedData.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }


        #endregion





    }
}
