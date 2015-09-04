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

namespace Modern_UI
{
    public partial class Main_Form : MetroForm
    {
        public const int DEFAULT_IGNORE = 3;
        public const int DEFAULT_HOLDOUT = 6;
        private DataArranger dataArranger = new DataArranger();
        private DateTime[] chart_xdata;
        private double[] chart_ydata;
        private int chart_point_count = 10;
        private int forecasted_yData_type = 0; 
        private int forecasting_type = 0;

        private string info = "Value: " + "#VAL{N2}" + "\n" + "Average: " + "#AVG{N2}" + "\n" + "Minimum: " + "#MIN{N2}" + "\n" + "Maximum: " + "#MAX{N2}" + "\n"
            + "First: " + "#FIRST{N2}" + "\n" + "Last: " + "#LAST{N2}" + "\n" + "Date: " + "#VALX";

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
            loadCountries();
            init_Charts();
            loadComboBoxes();
            //this.BackgroundImage = SalesAnalyser.Properties.Resources._2880x1800_light_sky_blue_solid_color_background;
            this.tile_reviewer.BackColor = Color.OrangeRed;
            this.tile_admin.BackColor = Color.SlateBlue;
            this.tile_analyst.BackColor = Color.MediumVioletRed;
            this.panel_choice.BackColor = Color.Transparent;

        }

        public void init_Charts()
        {
            this.chart_PastData.Series["Past Sales Data"].ChartType =
                //SeriesChartType.Area;
                //SeriesChartType.FastLine;
                //SeriesChartType.Candlestick;
                //SeriesChartType.StepLine;
                                    SeriesChartType.Point;
            this.chart_PastData.Series["Past Sales Data"].Color = Color.DarkMagenta;
            chart_PastData.Series["Past Sales Data"].ToolTip = "Sales Data point" + "\n" + info;


            this.chart_PastData.Series["Series2"].ChartType =
                                SeriesChartType.FastLine; //SeriesChartType.FastLine;
            this.chart_PastData.Series["Series2"].Color = Color.Blue;

            this.chart_PastData.Series["Series3"].ChartType =
                                SeriesChartType.FastLine; //SeriesChartType.FastLine;
            this.chart_PastData.Series["Series3"].Color = Color.Orange;
            this.chart_PastData.Series["Series3"].Enabled = false;

            this.chart_PastData.Series["Series4"].ChartType =
                                SeriesChartType.FastLine; //SeriesChartType.FastLine;
            this.chart_PastData.Series["Series4"].Color = Color.Olive;
            this.chart_PastData.Series["Series4"].Enabled = false;


        }


        private void tile_PastSalesData_Click(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_pastData.Show();
            this.button_logout.Hide();
        }

        private void tile_analyst_Click(object sender, EventArgs e)
        {
            
            /*this.panel_choice.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();*/
            
            Login_Form login = new Login_Form(2,this);
            login.Show();
            this.Enabled = false;
            /*bool validity = login.getValidity();
            if (validity)
            {
                login.Hide();
            }
            else 
            {
                MetroFramework.MetroMessageBox.Show(this, "Login attempt failed" + "\n" + "Username or password is incorrect", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        public void loadCountries()
        {
            List<Country> country_list = dataArranger.getAllCountries();
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

            comboBox_ForecastingType.Items.Add("Naive");
            comboBox_ForecastingType.Items.Add("Simple Moving Average");
            comboBox_ForecastingType.Items.Add("Weighted Moving Average");
            comboBox_ForecastingType.Items.Add("Adaptive Rate Smoothing");
            comboBox_ForecastingType.Items.Add("Exponential Smoothing");

            comboBox_ForecastingType.SelectedIndex = 0;
        }

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

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.button_logout.Hide();
            this.label_LoggedName.Text = "";
            this.label_LoggedName.Hide();
            this.panel_Analyst.Hide();
            this.panel_Admin.Hide();
            this.panel_choice.Show();
        }

        private void tile_admin_Click(object sender, EventArgs e)
        {
            /*this.panel_choice.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();*/

            Login_Form login = new Login_Form(1, this);
            login.Show();
            this.Enabled = false;
        }

        private void button_PastDataBack_Click(object sender, EventArgs e)
        {
            this.panel_pastData.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }


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

        private void tile_ForecastedData_Click(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_Chart.Show();
            this.chart_PastData.Hide();
            this.button_logout.Hide();
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
            comboBox_ChartXAxis.Items.Clear();
            var americanCulture = new CultureInfo("en-US");
            comboBox_ChartXAxis.Items.AddRange(americanCulture.DateTimeFormat.MonthNames);
            comboBox_ChartXAxis.SelectedIndex = 0;
        }

        private void radioButton_ChartSeason_CheckedChanged(object sender, EventArgs e)
        {
            isMonth = false;
            isSeason = true;
            comboBox_ChartXAxis.Items.Clear();

            comboBox_ChartXAxis.Items.Add("Winter");
            comboBox_ChartXAxis.Items.Add("Spring");
            comboBox_ChartXAxis.Items.Add("Summer");
            comboBox_ChartXAxis.Items.Add("Autumn");

            comboBox_ChartXAxis.SelectedIndex = 0;
        }



        public int chart_sales_data_type { get; set; }

        public bool isMonth { get; set; }

        public bool isSeason { get; set; }

        private void button_ViewChart_Click(object sender, EventArgs e)
        {
            int month_min = 0;
            int month_max = 0;
            if (isMonth)
            {
                month_min = comboBox_ChartXAxis.SelectedIndex + 1;
                month_max = 25;
            }
            else
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
                chart_PastData.Series["Series2"].Points.Clear();
                chart_PastData.Series["Series3"].Points.Clear();
                chart_PastData.Series["Series4"].Points.Clear();
                //Tuple<DateTime, double> p = Fit.Line(xdata, ydata);
                //double a = p.Item1; // == 10; intercept
                //double b = p.Item2; // == 0.5; slope
                chart_PastData.Series["Past Sales Data"].XValueType = ChartValueType.DateTime;
                for (int i = 0; i < chart_xdata.Length; i++)
                {
                    this.chart_PastData.Series["Past Sales Data"].Points.AddXY(chart_xdata[i], chart_ydata[i]);
                    this.chart_PastData.Series["Series4"].Points.AddXY(chart_xdata[i], chart_ydata[i]);
                }

                this.chart_PastData.Show();
                //this.chart_point_count = 10;
                //radioButtonsChange();
            }
        }

        private void comboBox_RegressionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_RegressionType.SelectedIndex == 0)
            {
                //chart_PastData.Series["Series2"].ToolTip = "Linear Regression Series" + "\n" + info;
                //chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                //chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("1," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
            }

            else if (comboBox_RegressionType.SelectedIndex == 1)
            {
                chart_PastData.Series["Series2"].ToolTip = "Linear Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("2," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
            }
            else if (comboBox_RegressionType.SelectedIndex == 2)
            {
                chart_PastData.Series["Series2"].ToolTip = "Exponential Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("3," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
            }
            else if (comboBox_RegressionType.SelectedIndex == 3)
            {
                chart_PastData.Series["Series2"].ToolTip = "Logarithmic Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("4," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
            }
            else
            {
                chart_PastData.Series["Series2"].ToolTip = "Power Regression Series" + "\n" + info;
                chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("5," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
            }
        }

        private void comboBox_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ChartType.SelectedIndex == 0)
            {
                //chart_PastData.Series["Series2"].ToolTip = "Linear Regression Series" + "\n" + info;
                //chart_PastData.Series["Series3"].ToolTip = "Series name3..." + "\n" + info;
                //chart_PastData.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, ("1," + chart_point_count / 2 + ",true,true"), "Past Sales Data:Y", "Series2:Y,Series3:Y,Series3:Y");
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

        private void tile_ForecastedData_Click_2(object sender, EventArgs e)
        {
            this.panel_Analyst.Hide();
            this.panel_ForecastedData.Show();
            this.panel_forecastedGrid.Hide();
            this.button_logout.Hide();
        }

        private void tile_newAdmin_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewAdmin.Show();
            this.button_logout.Hide();
        }

        private void tile_newDealer_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewDealer.Show();
            this.button_logout.Hide();
        }

        private void tile_newAnalysist_Click(object sender, EventArgs e)
        {
            this.panel_Admin.Hide();
            this.panel_NewAnalysist.Show();
            this.button_logout.Hide();
        }

        private void button_BackAnalysist_Click(object sender, EventArgs e)
        {
            this.panel_NewAnalysist.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        private void button_SubmitNewAnalysist_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameAnalysist.Text;
            string email = this.textBox_EmailAnalysist.Text;
            string username = this.textBox_UsernameAnalysist.Text;
            string password1 = this.textBox_PasswordAnalysist.Text;
            string password2 = this.textBox_RePasswordAnalysist.Text;

            int result = dataArranger.checkNewAccountdetails(2, name, email, username, password1, password2, this);
            if (result == 0) {
                this.textBox_NameAnalysist.Text = "";
                this.textBox_EmailAnalysist.Text = "";
                this.textBox_UsernameAnalysist.Text = "";
                this.textBox_PasswordAnalysist.Text = "";
                this.textBox_RePasswordAnalysist.Text = "";
            }
        }

        private void button_SubmitNewDealer_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameDealer.Text;
            string email = this.textBox_EmailDealer.Text;
            string username = this.textBox_UsernameDealer.Text;
            string password1 = this.textBox_PasswordDealer.Text;
            string password2 = this.textBox_RePasswordDealer.Text;

            int result = dataArranger.checkNewAccountdetails(3, name, email, username, password1, password2, this);
            if (result == 0)
            {
                this.textBox_NameDealer.Text = "";
                this.textBox_EmailDealer.Text = "";
                this.textBox_UsernameDealer.Text = "";
                this.textBox_PasswordDealer.Text = "";
                this.textBox_RePasswordDealer.Text = "";
            }
        }

        private void button_SubmitNewAdmin_Click(object sender, EventArgs e)
        {
            string name = this.textBox_NameAdmin.Text;
            string email = this.textBox_EmailAdmin.Text;
            string username = this.textBox_UsernameAdmin.Text;
            string password1 = this.textBox_PasswordAdmin.Text;
            string password2 = this.textBox_RePasswordAdmin.Text;

            int result = dataArranger.checkNewAccountdetails(1, name, email, username, password1, password2, this);
            if (result == 0)
            {
                this.textBox_NameAdmin.Text = "";
                this.textBox_EmailAdmin.Text = "";
                this.textBox_UsernameAdmin.Text = "";
                this.textBox_PasswordAdmin.Text = "";
                this.textBox_RePasswordAdmin.Text = "";
            }
        }

        private void button_ForecastedDataView_Click_1(object sender, EventArgs e)
        {
            //int validity = dataArranger.checkForecastedDataValidity((this.comboBox_ForecastedRegion.SelectedItem as Region).region_id,this.forecasted_yData_type,this.);
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

                ForecastTable ft = dataArranger.getForecastTable(region_id, forecasted_yData_type, month_min, month_max, forecastingType,number,this);
                this.grid_ForecastedData.DataSource = ft;
                

                if (ft != null) {
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


        private void tile_admin_MouseHover(object sender, EventArgs e)
        {
            this.tile_admin.BackColor = Color.MediumSlateBlue;
        }

        private void tile_admin_MouseLeave(object sender, EventArgs e)
        {
            this.tile_admin.BackColor = Color.SlateBlue;
        }

        private void tile_analyst_MouseHover(object sender, EventArgs e)
        {
            this.tile_analyst.BackColor = Color.PaleVioletRed;
        }

        private void tile_analyst_MouseLeave(object sender, EventArgs e)
        {
            this.tile_analyst.BackColor = Color.MediumVioletRed;
        }

        private void tile_reviewer_MouseLeave(object sender, EventArgs e)
        {
            this.tile_reviewer.BackColor = Color.OrangeRed;
        }

        private void tile_reviewer_MouseHover(object sender, EventArgs e)
        {
            this.tile_reviewer.BackColor = Color.Orange;
        }

        private void button_BackNewAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void button_BackDealer_Click(object sender, EventArgs e)
        {
            this.panel_NewDealer.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }

        public void analysistLoginSuccessful(string name) 
        {
            this.panel_choice.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }

        public void adminLoginSuccessful(string name)
        {
            this.panel_choice.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }

        public void reviewerLoginSuccessful(string name)
        {
            this.panel_choice.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
            this.label_LoggedName.Text = name;
            this.label_LoggedName.Show();
        }

        private void pictureBox_ChartBack_Click(object sender, EventArgs e)
        {
            this.panel_Chart.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }

        private void pictureBox_ForecastedBack_Click(object sender, EventArgs e)
        {
            this.panel_ForecastedData.Hide();
            this.panel_Analyst.Show();
            this.button_logout.Show();
        }

        private void pictureBox_NewAdminBack_Click(object sender, EventArgs e)
        {
            this.panel_NewAdmin.Hide();
            this.panel_Admin.Show();
            this.button_logout.Show();
        }
    }
}
