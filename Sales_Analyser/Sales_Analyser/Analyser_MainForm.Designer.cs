namespace Modern_UI
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_choice = new MetroFramework.Controls.MetroPanel();
            this.tile_reviewer = new MetroFramework.Controls.MetroTile();
            this.tile_analyst = new MetroFramework.Controls.MetroTile();
            this.tile_admin = new MetroFramework.Controls.MetroTile();
            this.panel_Analyst = new MetroFramework.Controls.MetroPanel();
            this.tile_ForecastedData = new MetroFramework.Controls.MetroTile();
            this.tile_PastSalesDataGraph = new MetroFramework.Controls.MetroTile();
            this.tile_PastSalesDataGrid = new MetroFramework.Controls.MetroTile();
            this.button_logout = new MetroFramework.Controls.MetroButton();
            this.panel_pastData = new MetroFramework.Controls.MetroPanel();
            this.button_PastDataBack = new MetroFramework.Controls.MetroButton();
            this.label_PastSalesData = new MetroFramework.Controls.MetroLabel();
            this.button_pastSalesData = new MetroFramework.Controls.MetroButton();
            this.comboBox_PastDataRegion = new MetroFramework.Controls.MetroComboBox();
            this.label_pastDataRegion = new MetroFramework.Controls.MetroLabel();
            this.label_PastDataCountry = new MetroFramework.Controls.MetroLabel();
            this.comboBox_pastDataCountry = new MetroFramework.Controls.MetroComboBox();
            this.grid_pastData = new MetroFramework.Controls.MetroGrid();
            this.panel_Chart = new MetroFramework.Controls.MetroPanel();
            this.comboBox_ChartType = new MetroFramework.Controls.MetroComboBox();
            this.label_ChartType = new MetroFramework.Controls.MetroLabel();
            this.comboBox_RegressionType = new MetroFramework.Controls.MetroComboBox();
            this.label_RegressionType = new MetroFramework.Controls.MetroLabel();
            this.button_ViewChart = new MetroFramework.Controls.MetroButton();
            this.button_ChartBack = new MetroFramework.Controls.MetroButton();
            this.label_ChartTitle = new MetroFramework.Controls.MetroLabel();
            this.chart_PastData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ChartSeason = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton_ChartMonth = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ChartIncome = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton_ChartQuantity = new MetroFramework.Controls.MetroRadioButton();
            this.comboBox_ChartXAxis = new MetroFramework.Controls.MetroComboBox();
            this.label_ChartXAxis = new MetroFramework.Controls.MetroLabel();
            this.label_ChartYAxis = new MetroFramework.Controls.MetroLabel();
            this.comboBox_ChartRegion = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_ChartCountry = new MetroFramework.Controls.MetroComboBox();
            this.label_ChartRegion = new MetroFramework.Controls.MetroLabel();
            this.label_ChartCountry = new MetroFramework.Controls.MetroLabel();
            this.panel_Admin = new MetroFramework.Controls.MetroPanel();
            this.tile_newDealer = new MetroFramework.Controls.MetroTile();
            this.tile_newAnalysist = new MetroFramework.Controls.MetroTile();
            this.tile_newAdmin = new MetroFramework.Controls.MetroTile();
            this.panel_ForecastedData = new MetroFramework.Controls.MetroPanel();
            this.panel_forecastedGrid = new MetroFramework.Controls.MetroPanel();
            this.textBox_MAPE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_MSqE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_CSE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_TS = new MetroFramework.Controls.MetroTextBox();
            this.textBox_CAE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_MAE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_MPE = new MetroFramework.Controls.MetroTextBox();
            this.textBox_MSE = new MetroFramework.Controls.MetroTextBox();
            this.label_MAE = new MetroFramework.Controls.MetroLabel();
            this.label_TS = new MetroFramework.Controls.MetroLabel();
            this.grid_ForecastedData = new MetroFramework.Controls.MetroGrid();
            this.label_MPE = new MetroFramework.Controls.MetroLabel();
            this.label_MSE = new MetroFramework.Controls.MetroLabel();
            this.label_MAPE = new MetroFramework.Controls.MetroLabel();
            this.label_CAE = new MetroFramework.Controls.MetroLabel();
            this.label_CSE = new MetroFramework.Controls.MetroLabel();
            this.label_MSqE = new MetroFramework.Controls.MetroLabel();
            this.textBox_ForecastingNumber = new MetroFramework.Controls.MetroTextBox();
            this.button_ForecastedDataView = new MetroFramework.Controls.MetroButton();
            this.comboBox_ForecastingType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_ForecastedSeason = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton_ForecastedMonth = new MetroFramework.Controls.MetroRadioButton();
            this.label_ForecastingNumber = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_ForecastedIncome = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton_ForecastedQuantity = new MetroFramework.Controls.MetroRadioButton();
            this.label_ForecastingType = new MetroFramework.Controls.MetroLabel();
            this.comboBox_ForecastedDateRange = new MetroFramework.Controls.MetroComboBox();
            this.label_ForecastedDateRange = new MetroFramework.Controls.MetroLabel();
            this.label_ForecastedValue = new MetroFramework.Controls.MetroLabel();
            this.comboBox_ForecastedRegion = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_ForecastedCountry = new MetroFramework.Controls.MetroComboBox();
            this.label_ForecastedRegion = new MetroFramework.Controls.MetroLabel();
            this.label_ForecastedCountry = new MetroFramework.Controls.MetroLabel();
            this.label_ForecastedTitle = new MetroFramework.Controls.MetroLabel();
            this.button_ForecastedBack = new MetroFramework.Controls.MetroButton();
            this.panel_NewAdmin = new MetroFramework.Controls.MetroPanel();
            this.button_SubmitNewAdmin = new MetroFramework.Controls.MetroButton();
            this.textBox_EmailAdmin = new MetroFramework.Controls.MetroTextBox();
            this.textBox_UsernameAdmin = new MetroFramework.Controls.MetroTextBox();
            this.textBox_PasswordAdmin = new MetroFramework.Controls.MetroTextBox();
            this.textBox_RePasswordAdmin = new MetroFramework.Controls.MetroTextBox();
            this.textBox_NameAdmin = new MetroFramework.Controls.MetroTextBox();
            this.label_PasswordAdmin = new MetroFramework.Controls.MetroLabel();
            this.label_RePasswordAdmin = new MetroFramework.Controls.MetroLabel();
            this.label_NameAdmin = new MetroFramework.Controls.MetroLabel();
            this.label_EmailAdmin = new MetroFramework.Controls.MetroLabel();
            this.label_UsernameAdmin = new MetroFramework.Controls.MetroLabel();
            this.button_BackNewAdmin = new MetroFramework.Controls.MetroButton();
            this.label_TitleNewAdmin = new MetroFramework.Controls.MetroLabel();
            this.panel_NewDealer = new MetroFramework.Controls.MetroPanel();
            this.button_SubmitNewDealer = new MetroFramework.Controls.MetroButton();
            this.textBox_EmailDealer = new MetroFramework.Controls.MetroTextBox();
            this.textBox_UsernameDealer = new MetroFramework.Controls.MetroTextBox();
            this.textBox_PasswordDealer = new MetroFramework.Controls.MetroTextBox();
            this.textBox_RePasswordDealer = new MetroFramework.Controls.MetroTextBox();
            this.textBox_NameDealer = new MetroFramework.Controls.MetroTextBox();
            this.label_PasswordDealer = new MetroFramework.Controls.MetroLabel();
            this.label_RePasswordDealer = new MetroFramework.Controls.MetroLabel();
            this.label_NameDealer = new MetroFramework.Controls.MetroLabel();
            this.label_EmailDealer = new MetroFramework.Controls.MetroLabel();
            this.label_UsernameDealer = new MetroFramework.Controls.MetroLabel();
            this.button_BackDealer = new MetroFramework.Controls.MetroButton();
            this.label_NewDealerTitle = new MetroFramework.Controls.MetroLabel();
            this.panel_NewAnalysist = new MetroFramework.Controls.MetroPanel();
            this.button_SubmitNewAnalysist = new MetroFramework.Controls.MetroButton();
            this.textBox_EmailAnalysist = new MetroFramework.Controls.MetroTextBox();
            this.textBox_UsernameAnalysist = new MetroFramework.Controls.MetroTextBox();
            this.textBox_PasswordAnalysist = new MetroFramework.Controls.MetroTextBox();
            this.textBox_RePasswordAnalysist = new MetroFramework.Controls.MetroTextBox();
            this.textBox_NameAnalysist = new MetroFramework.Controls.MetroTextBox();
            this.label_PasswordAnalysist = new MetroFramework.Controls.MetroLabel();
            this.label_RePasswordAnalysist = new MetroFramework.Controls.MetroLabel();
            this.label_NameAnalysist = new MetroFramework.Controls.MetroLabel();
            this.label_EmailAnalysist = new MetroFramework.Controls.MetroLabel();
            this.label_UsernameAnalysist = new MetroFramework.Controls.MetroLabel();
            this.button_BackAnalysist = new MetroFramework.Controls.MetroButton();
            this.label_NewAnalysistTitle = new MetroFramework.Controls.MetroLabel();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.label_LoggedName = new MetroFramework.Controls.MetroLabel();
            this.panel_choice.SuspendLayout();
            this.panel_Analyst.SuspendLayout();
            this.panel_pastData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pastData)).BeginInit();
            this.panel_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PastData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_Admin.SuspendLayout();
            this.panel_ForecastedData.SuspendLayout();
            this.panel_forecastedGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ForecastedData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel_NewAdmin.SuspendLayout();
            this.panel_NewDealer.SuspendLayout();
            this.panel_NewAnalysist.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_choice
            // 
            this.panel_choice.BackColor = System.Drawing.Color.Transparent;
            this.panel_choice.Controls.Add(this.tile_reviewer);
            this.panel_choice.Controls.Add(this.tile_analyst);
            this.panel_choice.Controls.Add(this.tile_admin);
            this.panel_choice.HorizontalScrollbarBarColor = true;
            this.panel_choice.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_choice.HorizontalScrollbarSize = 10;
            this.panel_choice.Location = new System.Drawing.Point(136, 206);
            this.panel_choice.Name = "panel_choice";
            this.panel_choice.Size = new System.Drawing.Size(625, 237);
            this.panel_choice.TabIndex = 8;
            this.panel_choice.UseCustomBackColor = true;
            this.panel_choice.VerticalScrollbarBarColor = true;
            this.panel_choice.VerticalScrollbarHighlightOnWheel = false;
            this.panel_choice.VerticalScrollbarSize = 10;
            // 
            // tile_reviewer
            // 
            this.tile_reviewer.ActiveControl = null;
            this.tile_reviewer.Location = new System.Drawing.Point(426, 18);
            this.tile_reviewer.Name = "tile_reviewer";
            this.tile_reviewer.Size = new System.Drawing.Size(190, 200);
            this.tile_reviewer.TabIndex = 10;
            this.tile_reviewer.Text = "Reviewer";
            this.tile_reviewer.TileImage = global::SalesAnalyser.Properties.Resources.Reviewer;
            this.tile_reviewer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_reviewer.UseCustomBackColor = true;
            this.tile_reviewer.UseSelectable = true;
            this.tile_reviewer.UseTileImage = true;
            this.tile_reviewer.MouseLeave += new System.EventHandler(this.tile_reviewer_MouseLeave);
            this.tile_reviewer.MouseHover += new System.EventHandler(this.tile_reviewer_MouseHover);
            // 
            // tile_analyst
            // 
            this.tile_analyst.ActiveControl = null;
            this.tile_analyst.Location = new System.Drawing.Point(216, 18);
            this.tile_analyst.Name = "tile_analyst";
            this.tile_analyst.Size = new System.Drawing.Size(190, 200);
            this.tile_analyst.TabIndex = 9;
            this.tile_analyst.Text = "Analyst";
            this.tile_analyst.TileImage = global::SalesAnalyser.Properties.Resources.Manager;
            this.tile_analyst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_analyst.UseCustomBackColor = true;
            this.tile_analyst.UseSelectable = true;
            this.tile_analyst.UseTileImage = true;
            this.tile_analyst.Click += new System.EventHandler(this.tile_analyst_Click);
            this.tile_analyst.MouseLeave += new System.EventHandler(this.tile_analyst_MouseLeave);
            this.tile_analyst.MouseHover += new System.EventHandler(this.tile_analyst_MouseHover);
            // 
            // tile_admin
            // 
            this.tile_admin.ActiveControl = null;
            this.tile_admin.Location = new System.Drawing.Point(8, 18);
            this.tile_admin.Name = "tile_admin";
            this.tile_admin.Size = new System.Drawing.Size(190, 200);
            this.tile_admin.TabIndex = 8;
            this.tile_admin.Text = "Administrator";
            this.tile_admin.TileImage = global::SalesAnalyser.Properties.Resources.admin;
            this.tile_admin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.tile_admin, "Log in as an administrator");
            this.tile_admin.UseCustomBackColor = true;
            this.tile_admin.UseSelectable = true;
            this.tile_admin.UseTileImage = true;
            this.tile_admin.Click += new System.EventHandler(this.tile_admin_Click);
            this.tile_admin.MouseLeave += new System.EventHandler(this.tile_admin_MouseLeave);
            this.tile_admin.MouseHover += new System.EventHandler(this.tile_admin_MouseHover);
            // 
            // panel_Analyst
            // 
            this.panel_Analyst.Controls.Add(this.tile_ForecastedData);
            this.panel_Analyst.Controls.Add(this.tile_PastSalesDataGraph);
            this.panel_Analyst.Controls.Add(this.tile_PastSalesDataGrid);
            this.panel_Analyst.HorizontalScrollbarBarColor = true;
            this.panel_Analyst.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Analyst.HorizontalScrollbarSize = 10;
            this.panel_Analyst.Location = new System.Drawing.Point(100, 154);
            this.panel_Analyst.Name = "panel_Analyst";
            this.panel_Analyst.Size = new System.Drawing.Size(764, 297);
            this.panel_Analyst.TabIndex = 9;
            this.panel_Analyst.VerticalScrollbarBarColor = true;
            this.panel_Analyst.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Analyst.VerticalScrollbarSize = 10;
            // 
            // tile_ForecastedData
            // 
            this.tile_ForecastedData.ActiveControl = null;
            this.tile_ForecastedData.Location = new System.Drawing.Point(494, 57);
            this.tile_ForecastedData.Name = "tile_ForecastedData";
            this.tile_ForecastedData.Size = new System.Drawing.Size(190, 200);
            this.tile_ForecastedData.TabIndex = 4;
            this.tile_ForecastedData.Text = "Forecasted Data\r\n(Predicted Data)";
            this.toolTip.SetToolTip(this.tile_ForecastedData, "View predictions in sales using forecasting methods");
            this.tile_ForecastedData.UseSelectable = true;
            this.tile_ForecastedData.Click += new System.EventHandler(this.tile_ForecastedData_Click_2);
            // 
            // tile_PastSalesDataGraph
            // 
            this.tile_PastSalesDataGraph.ActiveControl = null;
            this.tile_PastSalesDataGraph.Location = new System.Drawing.Point(266, 57);
            this.tile_PastSalesDataGraph.Name = "tile_PastSalesDataGraph";
            this.tile_PastSalesDataGraph.Size = new System.Drawing.Size(190, 200);
            this.tile_PastSalesDataGraph.TabIndex = 3;
            this.tile_PastSalesDataGraph.Text = "Past Sales Data \r\n(Chart View)";
            this.tile_PastSalesDataGraph.TileImage = global::SalesAnalyser.Properties.Resources.chart;
            this.tile_PastSalesDataGraph.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.tile_PastSalesDataGraph, "View past sales data on a chart");
            this.tile_PastSalesDataGraph.UseSelectable = true;
            this.tile_PastSalesDataGraph.UseTileImage = true;
            this.tile_PastSalesDataGraph.Click += new System.EventHandler(this.tile_ForecastedData_Click);
            // 
            // tile_PastSalesDataGrid
            // 
            this.tile_PastSalesDataGrid.ActiveControl = null;
            this.tile_PastSalesDataGrid.Location = new System.Drawing.Point(38, 57);
            this.tile_PastSalesDataGrid.Name = "tile_PastSalesDataGrid";
            this.tile_PastSalesDataGrid.Size = new System.Drawing.Size(190, 200);
            this.tile_PastSalesDataGrid.TabIndex = 2;
            this.tile_PastSalesDataGrid.Text = "Past Sales Data\r\n(Grid View)";
            this.tile_PastSalesDataGrid.TileImage = global::SalesAnalyser.Properties.Resources.Data_Grid;
            this.tile_PastSalesDataGrid.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.tile_PastSalesDataGrid, "View past sales data on a grid");
            this.tile_PastSalesDataGrid.UseSelectable = true;
            this.tile_PastSalesDataGrid.UseTileImage = true;
            this.tile_PastSalesDataGrid.Click += new System.EventHandler(this.tile_PastSalesData_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(1071, 37);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 10;
            this.button_logout.Text = "Logout";
            this.button_logout.UseSelectable = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_pastData
            // 
            this.panel_pastData.Controls.Add(this.button_PastDataBack);
            this.panel_pastData.Controls.Add(this.label_PastSalesData);
            this.panel_pastData.Controls.Add(this.button_pastSalesData);
            this.panel_pastData.Controls.Add(this.comboBox_PastDataRegion);
            this.panel_pastData.Controls.Add(this.label_pastDataRegion);
            this.panel_pastData.Controls.Add(this.label_PastDataCountry);
            this.panel_pastData.Controls.Add(this.comboBox_pastDataCountry);
            this.panel_pastData.Controls.Add(this.grid_pastData);
            this.panel_pastData.HorizontalScrollbarBarColor = true;
            this.panel_pastData.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pastData.HorizontalScrollbarSize = 10;
            this.panel_pastData.Location = new System.Drawing.Point(7, 63);
            this.panel_pastData.Name = "panel_pastData";
            this.panel_pastData.Size = new System.Drawing.Size(1179, 579);
            this.panel_pastData.TabIndex = 11;
            this.panel_pastData.VerticalScrollbarBarColor = true;
            this.panel_pastData.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pastData.VerticalScrollbarSize = 10;
            // 
            // button_PastDataBack
            // 
            this.button_PastDataBack.Location = new System.Drawing.Point(17, 4);
            this.button_PastDataBack.Name = "button_PastDataBack";
            this.button_PastDataBack.Size = new System.Drawing.Size(75, 23);
            this.button_PastDataBack.TabIndex = 9;
            this.button_PastDataBack.Text = "Back";
            this.button_PastDataBack.UseSelectable = true;
            this.button_PastDataBack.Click += new System.EventHandler(this.button_PastDataBack_Click);
            // 
            // label_PastSalesData
            // 
            this.label_PastSalesData.AutoSize = true;
            this.label_PastSalesData.Location = new System.Drawing.Point(51, 58);
            this.label_PastSalesData.Name = "label_PastSalesData";
            this.label_PastSalesData.Size = new System.Drawing.Size(96, 19);
            this.label_PastSalesData.TabIndex = 8;
            this.label_PastSalesData.Text = "Past Sales Data";
            // 
            // button_pastSalesData
            // 
            this.button_pastSalesData.Location = new System.Drawing.Point(272, 212);
            this.button_pastSalesData.Name = "button_pastSalesData";
            this.button_pastSalesData.Size = new System.Drawing.Size(75, 23);
            this.button_pastSalesData.TabIndex = 7;
            this.button_pastSalesData.Text = "Submit";
            this.button_pastSalesData.UseSelectable = true;
            this.button_pastSalesData.Click += new System.EventHandler(this.button_pastSalesData_Click);
            // 
            // comboBox_PastDataRegion
            // 
            this.comboBox_PastDataRegion.FormattingEnabled = true;
            this.comboBox_PastDataRegion.ItemHeight = 23;
            this.comboBox_PastDataRegion.Location = new System.Drawing.Point(226, 151);
            this.comboBox_PastDataRegion.Name = "comboBox_PastDataRegion";
            this.comboBox_PastDataRegion.Size = new System.Drawing.Size(121, 29);
            this.comboBox_PastDataRegion.TabIndex = 6;
            this.comboBox_PastDataRegion.UseSelectable = true;
            // 
            // label_pastDataRegion
            // 
            this.label_pastDataRegion.AutoSize = true;
            this.label_pastDataRegion.Location = new System.Drawing.Point(51, 161);
            this.label_pastDataRegion.Name = "label_pastDataRegion";
            this.label_pastDataRegion.Size = new System.Drawing.Size(88, 19);
            this.label_pastDataRegion.TabIndex = 5;
            this.label_pastDataRegion.Text = "Select Region";
            // 
            // label_PastDataCountry
            // 
            this.label_PastDataCountry.AutoSize = true;
            this.label_PastDataCountry.Location = new System.Drawing.Point(51, 108);
            this.label_PastDataCountry.Name = "label_PastDataCountry";
            this.label_PastDataCountry.Size = new System.Drawing.Size(94, 19);
            this.label_PastDataCountry.TabIndex = 4;
            this.label_PastDataCountry.Text = "Select Country";
            // 
            // comboBox_pastDataCountry
            // 
            this.comboBox_pastDataCountry.FormattingEnabled = true;
            this.comboBox_pastDataCountry.ItemHeight = 23;
            this.comboBox_pastDataCountry.Location = new System.Drawing.Point(226, 98);
            this.comboBox_pastDataCountry.Name = "comboBox_pastDataCountry";
            this.comboBox_pastDataCountry.Size = new System.Drawing.Size(121, 29);
            this.comboBox_pastDataCountry.TabIndex = 3;
            this.comboBox_pastDataCountry.UseSelectable = true;
            this.comboBox_pastDataCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_pastDataCountry_SelectedIndexChanged);
            // 
            // grid_pastData
            // 
            this.grid_pastData.AllowUserToResizeRows = false;
            this.grid_pastData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_pastData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_pastData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_pastData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pastData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_pastData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pastData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_pastData.EnableHeadersVisualStyles = false;
            this.grid_pastData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_pastData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_pastData.Location = new System.Drawing.Point(382, 98);
            this.grid_pastData.Name = "grid_pastData";
            this.grid_pastData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pastData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_pastData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_pastData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_pastData.Size = new System.Drawing.Size(685, 466);
            this.grid_pastData.TabIndex = 2;
            // 
            // panel_Chart
            // 
            this.panel_Chart.Controls.Add(this.comboBox_ChartType);
            this.panel_Chart.Controls.Add(this.label_ChartType);
            this.panel_Chart.Controls.Add(this.comboBox_RegressionType);
            this.panel_Chart.Controls.Add(this.label_RegressionType);
            this.panel_Chart.Controls.Add(this.button_ViewChart);
            this.panel_Chart.Controls.Add(this.button_ChartBack);
            this.panel_Chart.Controls.Add(this.label_ChartTitle);
            this.panel_Chart.Controls.Add(this.chart_PastData);
            this.panel_Chart.Controls.Add(this.groupBox2);
            this.panel_Chart.Controls.Add(this.groupBox1);
            this.panel_Chart.Controls.Add(this.comboBox_ChartXAxis);
            this.panel_Chart.Controls.Add(this.label_ChartXAxis);
            this.panel_Chart.Controls.Add(this.label_ChartYAxis);
            this.panel_Chart.Controls.Add(this.comboBox_ChartRegion);
            this.panel_Chart.Controls.Add(this.comboBox_ChartCountry);
            this.panel_Chart.Controls.Add(this.label_ChartRegion);
            this.panel_Chart.Controls.Add(this.label_ChartCountry);
            this.panel_Chart.HorizontalScrollbarBarColor = true;
            this.panel_Chart.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Chart.HorizontalScrollbarSize = 10;
            this.panel_Chart.Location = new System.Drawing.Point(7, 63);
            this.panel_Chart.Name = "panel_Chart";
            this.panel_Chart.Size = new System.Drawing.Size(1179, 576);
            this.panel_Chart.TabIndex = 8;
            this.panel_Chart.VerticalScrollbarBarColor = true;
            this.panel_Chart.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Chart.VerticalScrollbarSize = 10;
            // 
            // comboBox_ChartType
            // 
            this.comboBox_ChartType.FormattingEnabled = true;
            this.comboBox_ChartType.ItemHeight = 23;
            this.comboBox_ChartType.Location = new System.Drawing.Point(989, 95);
            this.comboBox_ChartType.Name = "comboBox_ChartType";
            this.comboBox_ChartType.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ChartType.TabIndex = 22;
            this.comboBox_ChartType.UseSelectable = true;
            this.comboBox_ChartType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChartType_SelectedIndexChanged);
            // 
            // label_ChartType
            // 
            this.label_ChartType.AutoSize = true;
            this.label_ChartType.Location = new System.Drawing.Point(822, 98);
            this.label_ChartType.Name = "label_ChartType";
            this.label_ChartType.Size = new System.Drawing.Size(111, 19);
            this.label_ChartType.TabIndex = 21;
            this.label_ChartType.Text = "Select Chart Type";
            // 
            // comboBox_RegressionType
            // 
            this.comboBox_RegressionType.FormattingEnabled = true;
            this.comboBox_RegressionType.ItemHeight = 23;
            this.comboBox_RegressionType.Location = new System.Drawing.Point(600, 95);
            this.comboBox_RegressionType.Name = "comboBox_RegressionType";
            this.comboBox_RegressionType.Size = new System.Drawing.Size(121, 29);
            this.comboBox_RegressionType.TabIndex = 20;
            this.comboBox_RegressionType.UseSelectable = true;
            this.comboBox_RegressionType.SelectedIndexChanged += new System.EventHandler(this.comboBox_RegressionType_SelectedIndexChanged);
            // 
            // label_RegressionType
            // 
            this.label_RegressionType.AutoSize = true;
            this.label_RegressionType.Location = new System.Drawing.Point(433, 98);
            this.label_RegressionType.Name = "label_RegressionType";
            this.label_RegressionType.Size = new System.Drawing.Size(141, 19);
            this.label_RegressionType.TabIndex = 19;
            this.label_RegressionType.Text = "Select Regression Type";
            // 
            // button_ViewChart
            // 
            this.button_ViewChart.Location = new System.Drawing.Point(274, 357);
            this.button_ViewChart.Name = "button_ViewChart";
            this.button_ViewChart.Size = new System.Drawing.Size(75, 23);
            this.button_ViewChart.TabIndex = 18;
            this.button_ViewChart.Text = "View Chart";
            this.button_ViewChart.UseSelectable = true;
            this.button_ViewChart.Click += new System.EventHandler(this.button_ViewChart_Click);
            // 
            // button_ChartBack
            // 
            this.button_ChartBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ChartBack.DisplayFocus = true;
            this.button_ChartBack.Location = new System.Drawing.Point(16, 3);
            this.button_ChartBack.Name = "button_ChartBack";
            this.button_ChartBack.Size = new System.Drawing.Size(32, 33);
            this.button_ChartBack.Style = MetroFramework.MetroColorStyle.Red;
            this.button_ChartBack.TabIndex = 17;
            this.button_ChartBack.UseSelectable = true;
            this.button_ChartBack.Click += new System.EventHandler(this.button_ChartBack_Click);
            // 
            // label_ChartTitle
            // 
            this.label_ChartTitle.AutoSize = true;
            this.label_ChartTitle.Location = new System.Drawing.Point(71, 47);
            this.label_ChartTitle.Name = "label_ChartTitle";
            this.label_ChartTitle.Size = new System.Drawing.Size(169, 19);
            this.label_ChartTitle.TabIndex = 16;
            this.label_ChartTitle.Text = "Past Sales Data With Charts";
            // 
            // chart_PastData
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_PastData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_PastData.Legends.Add(legend1);
            this.chart_PastData.Location = new System.Drawing.Point(433, 142);
            this.chart_PastData.Name = "chart_PastData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Past Sales Data";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart_PastData.Series.Add(series1);
            this.chart_PastData.Series.Add(series2);
            this.chart_PastData.Series.Add(series3);
            this.chart_PastData.Series.Add(series4);
            this.chart_PastData.Size = new System.Drawing.Size(706, 431);
            this.chart_PastData.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_ChartSeason);
            this.groupBox2.Controls.Add(this.radioButton_ChartMonth);
            this.groupBox2.Location = new System.Drawing.Point(200, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 32);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_ChartSeason
            // 
            this.radioButton_ChartSeason.AutoSize = true;
            this.radioButton_ChartSeason.Location = new System.Drawing.Point(83, 12);
            this.radioButton_ChartSeason.Name = "radioButton_ChartSeason";
            this.radioButton_ChartSeason.Size = new System.Drawing.Size(60, 15);
            this.radioButton_ChartSeason.TabIndex = 11;
            this.radioButton_ChartSeason.Text = "Season";
            this.radioButton_ChartSeason.UseSelectable = true;
            this.radioButton_ChartSeason.CheckedChanged += new System.EventHandler(this.radioButton_ChartSeason_CheckedChanged);
            // 
            // radioButton_ChartMonth
            // 
            this.radioButton_ChartMonth.AutoSize = true;
            this.radioButton_ChartMonth.Location = new System.Drawing.Point(8, 12);
            this.radioButton_ChartMonth.Name = "radioButton_ChartMonth";
            this.radioButton_ChartMonth.Size = new System.Drawing.Size(59, 15);
            this.radioButton_ChartMonth.TabIndex = 10;
            this.radioButton_ChartMonth.Text = "Month";
            this.radioButton_ChartMonth.UseSelectable = true;
            this.radioButton_ChartMonth.CheckedChanged += new System.EventHandler(this.radioButton_ChartMonth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ChartIncome);
            this.groupBox1.Controls.Add(this.radioButton_ChartQuantity);
            this.groupBox1.Location = new System.Drawing.Point(200, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 32);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_ChartIncome
            // 
            this.radioButton_ChartIncome.AutoSize = true;
            this.radioButton_ChartIncome.Location = new System.Drawing.Point(83, 11);
            this.radioButton_ChartIncome.Name = "radioButton_ChartIncome";
            this.radioButton_ChartIncome.Size = new System.Drawing.Size(63, 15);
            this.radioButton_ChartIncome.TabIndex = 8;
            this.radioButton_ChartIncome.Text = "Income";
            this.radioButton_ChartIncome.UseSelectable = true;
            this.radioButton_ChartIncome.CheckedChanged += new System.EventHandler(this.radioButton_ChartIncome_CheckedChanged);
            // 
            // radioButton_ChartQuantity
            // 
            this.radioButton_ChartQuantity.AutoSize = true;
            this.radioButton_ChartQuantity.Location = new System.Drawing.Point(6, 11);
            this.radioButton_ChartQuantity.Name = "radioButton_ChartQuantity";
            this.radioButton_ChartQuantity.Size = new System.Drawing.Size(69, 15);
            this.radioButton_ChartQuantity.TabIndex = 7;
            this.radioButton_ChartQuantity.Text = "Quantity";
            this.radioButton_ChartQuantity.UseSelectable = true;
            this.radioButton_ChartQuantity.CheckedChanged += new System.EventHandler(this.radioButton_ChartQuantity_CheckedChanged);
            // 
            // comboBox_ChartXAxis
            // 
            this.comboBox_ChartXAxis.FormattingEnabled = true;
            this.comboBox_ChartXAxis.ItemHeight = 23;
            this.comboBox_ChartXAxis.Location = new System.Drawing.Point(228, 298);
            this.comboBox_ChartXAxis.Name = "comboBox_ChartXAxis";
            this.comboBox_ChartXAxis.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ChartXAxis.TabIndex = 12;
            this.comboBox_ChartXAxis.UseSelectable = true;
            // 
            // label_ChartXAxis
            // 
            this.label_ChartXAxis.AutoSize = true;
            this.label_ChartXAxis.Location = new System.Drawing.Point(71, 260);
            this.label_ChartXAxis.Name = "label_ChartXAxis";
            this.label_ChartXAxis.Size = new System.Drawing.Size(84, 19);
            this.label_ChartXAxis.TabIndex = 9;
            this.label_ChartXAxis.Text = "Select X-Axis";
            // 
            // label_ChartYAxis
            // 
            this.label_ChartYAxis.AutoSize = true;
            this.label_ChartYAxis.Location = new System.Drawing.Point(71, 220);
            this.label_ChartYAxis.Name = "label_ChartYAxis";
            this.label_ChartYAxis.Size = new System.Drawing.Size(84, 19);
            this.label_ChartYAxis.TabIndex = 6;
            this.label_ChartYAxis.Text = "Select Y-Axis";
            // 
            // comboBox_ChartRegion
            // 
            this.comboBox_ChartRegion.FormattingEnabled = true;
            this.comboBox_ChartRegion.ItemHeight = 23;
            this.comboBox_ChartRegion.Location = new System.Drawing.Point(226, 142);
            this.comboBox_ChartRegion.Name = "comboBox_ChartRegion";
            this.comboBox_ChartRegion.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ChartRegion.TabIndex = 5;
            this.comboBox_ChartRegion.UseSelectable = true;
            // 
            // comboBox_ChartCountry
            // 
            this.comboBox_ChartCountry.FormattingEnabled = true;
            this.comboBox_ChartCountry.ItemHeight = 23;
            this.comboBox_ChartCountry.Location = new System.Drawing.Point(226, 95);
            this.comboBox_ChartCountry.Name = "comboBox_ChartCountry";
            this.comboBox_ChartCountry.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ChartCountry.TabIndex = 4;
            this.comboBox_ChartCountry.UseSelectable = true;
            this.comboBox_ChartCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChartCountry_SelectedIndexChanged);
            // 
            // label_ChartRegion
            // 
            this.label_ChartRegion.AutoSize = true;
            this.label_ChartRegion.Location = new System.Drawing.Point(71, 145);
            this.label_ChartRegion.Name = "label_ChartRegion";
            this.label_ChartRegion.Size = new System.Drawing.Size(88, 19);
            this.label_ChartRegion.TabIndex = 3;
            this.label_ChartRegion.Text = "Select Region";
            // 
            // label_ChartCountry
            // 
            this.label_ChartCountry.AutoSize = true;
            this.label_ChartCountry.Location = new System.Drawing.Point(71, 98);
            this.label_ChartCountry.Name = "label_ChartCountry";
            this.label_ChartCountry.Size = new System.Drawing.Size(94, 19);
            this.label_ChartCountry.TabIndex = 2;
            this.label_ChartCountry.Text = "Select Country";
            // 
            // panel_Admin
            // 
            this.panel_Admin.Controls.Add(this.tile_newDealer);
            this.panel_Admin.Controls.Add(this.tile_newAnalysist);
            this.panel_Admin.Controls.Add(this.tile_newAdmin);
            this.panel_Admin.HorizontalScrollbarBarColor = true;
            this.panel_Admin.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Admin.HorizontalScrollbarSize = 10;
            this.panel_Admin.Location = new System.Drawing.Point(119, 212);
            this.panel_Admin.Name = "panel_Admin";
            this.panel_Admin.Size = new System.Drawing.Size(700, 288);
            this.panel_Admin.TabIndex = 2;
            this.panel_Admin.VerticalScrollbarBarColor = true;
            this.panel_Admin.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Admin.VerticalScrollbarSize = 10;
            // 
            // tile_newDealer
            // 
            this.tile_newDealer.ActiveControl = null;
            this.tile_newDealer.Location = new System.Drawing.Point(488, 49);
            this.tile_newDealer.Name = "tile_newDealer";
            this.tile_newDealer.Size = new System.Drawing.Size(190, 200);
            this.tile_newDealer.TabIndex = 3;
            this.tile_newDealer.Text = "Create New\r\nDealer";
            this.tile_newDealer.UseSelectable = true;
            this.tile_newDealer.Click += new System.EventHandler(this.tile_newDealer_Click);
            // 
            // tile_newAnalysist
            // 
            this.tile_newAnalysist.ActiveControl = null;
            this.tile_newAnalysist.Location = new System.Drawing.Point(263, 49);
            this.tile_newAnalysist.Name = "tile_newAnalysist";
            this.tile_newAnalysist.Size = new System.Drawing.Size(190, 200);
            this.tile_newAnalysist.TabIndex = 3;
            this.tile_newAnalysist.Text = "Create New\r\nAnalysist";
            this.tile_newAnalysist.UseSelectable = true;
            this.tile_newAnalysist.Click += new System.EventHandler(this.tile_newAnalysist_Click);
            // 
            // tile_newAdmin
            // 
            this.tile_newAdmin.ActiveControl = null;
            this.tile_newAdmin.Location = new System.Drawing.Point(42, 49);
            this.tile_newAdmin.Name = "tile_newAdmin";
            this.tile_newAdmin.Size = new System.Drawing.Size(190, 200);
            this.tile_newAdmin.TabIndex = 2;
            this.tile_newAdmin.Text = "Create New \r\nAdmininstrator";
            this.tile_newAdmin.UseSelectable = true;
            this.tile_newAdmin.Click += new System.EventHandler(this.tile_newAdmin_Click);
            // 
            // panel_ForecastedData
            // 
            this.panel_ForecastedData.Controls.Add(this.panel_forecastedGrid);
            this.panel_ForecastedData.Controls.Add(this.textBox_ForecastingNumber);
            this.panel_ForecastedData.Controls.Add(this.button_ForecastedDataView);
            this.panel_ForecastedData.Controls.Add(this.comboBox_ForecastingType);
            this.panel_ForecastedData.Controls.Add(this.groupBox3);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastingNumber);
            this.panel_ForecastedData.Controls.Add(this.groupBox4);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastingType);
            this.panel_ForecastedData.Controls.Add(this.comboBox_ForecastedDateRange);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastedDateRange);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastedValue);
            this.panel_ForecastedData.Controls.Add(this.comboBox_ForecastedRegion);
            this.panel_ForecastedData.Controls.Add(this.comboBox_ForecastedCountry);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastedRegion);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastedCountry);
            this.panel_ForecastedData.Controls.Add(this.label_ForecastedTitle);
            this.panel_ForecastedData.Controls.Add(this.button_ForecastedBack);
            this.panel_ForecastedData.HorizontalScrollbarBarColor = true;
            this.panel_ForecastedData.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_ForecastedData.HorizontalScrollbarSize = 10;
            this.panel_ForecastedData.Location = new System.Drawing.Point(7, 63);
            this.panel_ForecastedData.Name = "panel_ForecastedData";
            this.panel_ForecastedData.Size = new System.Drawing.Size(1179, 579);
            this.panel_ForecastedData.TabIndex = 23;
            this.panel_ForecastedData.VerticalScrollbarBarColor = true;
            this.panel_ForecastedData.VerticalScrollbarHighlightOnWheel = false;
            this.panel_ForecastedData.VerticalScrollbarSize = 10;
            // 
            // panel_forecastedGrid
            // 
            this.panel_forecastedGrid.Controls.Add(this.textBox_MAPE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_MSqE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_CSE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_TS);
            this.panel_forecastedGrid.Controls.Add(this.textBox_CAE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_MAE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_MPE);
            this.panel_forecastedGrid.Controls.Add(this.textBox_MSE);
            this.panel_forecastedGrid.Controls.Add(this.label_MAE);
            this.panel_forecastedGrid.Controls.Add(this.label_TS);
            this.panel_forecastedGrid.Controls.Add(this.grid_ForecastedData);
            this.panel_forecastedGrid.Controls.Add(this.label_MPE);
            this.panel_forecastedGrid.Controls.Add(this.label_MSE);
            this.panel_forecastedGrid.Controls.Add(this.label_MAPE);
            this.panel_forecastedGrid.Controls.Add(this.label_CAE);
            this.panel_forecastedGrid.Controls.Add(this.label_CSE);
            this.panel_forecastedGrid.Controls.Add(this.label_MSqE);
            this.panel_forecastedGrid.HorizontalScrollbarBarColor = true;
            this.panel_forecastedGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_forecastedGrid.HorizontalScrollbarSize = 10;
            this.panel_forecastedGrid.Location = new System.Drawing.Point(493, 47);
            this.panel_forecastedGrid.Name = "panel_forecastedGrid";
            this.panel_forecastedGrid.Size = new System.Drawing.Size(666, 517);
            this.panel_forecastedGrid.TabIndex = 44;
            this.panel_forecastedGrid.VerticalScrollbarBarColor = true;
            this.panel_forecastedGrid.VerticalScrollbarHighlightOnWheel = false;
            this.panel_forecastedGrid.VerticalScrollbarSize = 10;
            // 
            // textBox_MAPE
            // 
            this.textBox_MAPE.Lines = new string[0];
            this.textBox_MAPE.Location = new System.Drawing.Point(163, 151);
            this.textBox_MAPE.MaxLength = 32767;
            this.textBox_MAPE.Name = "textBox_MAPE";
            this.textBox_MAPE.PasswordChar = '\0';
            this.textBox_MAPE.ReadOnly = true;
            this.textBox_MAPE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MAPE.SelectedText = "";
            this.textBox_MAPE.Size = new System.Drawing.Size(156, 23);
            this.textBox_MAPE.TabIndex = 51;
            this.textBox_MAPE.UseSelectable = true;
            // 
            // textBox_MSqE
            // 
            this.textBox_MSqE.Lines = new string[0];
            this.textBox_MSqE.Location = new System.Drawing.Point(496, 92);
            this.textBox_MSqE.MaxLength = 32767;
            this.textBox_MSqE.Name = "textBox_MSqE";
            this.textBox_MSqE.PasswordChar = '\0';
            this.textBox_MSqE.ReadOnly = true;
            this.textBox_MSqE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MSqE.SelectedText = "";
            this.textBox_MSqE.Size = new System.Drawing.Size(165, 23);
            this.textBox_MSqE.TabIndex = 50;
            this.textBox_MSqE.UseSelectable = true;
            // 
            // textBox_CSE
            // 
            this.textBox_CSE.Lines = new string[0];
            this.textBox_CSE.Location = new System.Drawing.Point(496, 121);
            this.textBox_CSE.MaxLength = 32767;
            this.textBox_CSE.Name = "textBox_CSE";
            this.textBox_CSE.PasswordChar = '\0';
            this.textBox_CSE.ReadOnly = true;
            this.textBox_CSE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_CSE.SelectedText = "";
            this.textBox_CSE.Size = new System.Drawing.Size(165, 23);
            this.textBox_CSE.TabIndex = 49;
            this.textBox_CSE.UseSelectable = true;
            // 
            // textBox_TS
            // 
            this.textBox_TS.Lines = new string[0];
            this.textBox_TS.Location = new System.Drawing.Point(496, 63);
            this.textBox_TS.MaxLength = 32767;
            this.textBox_TS.Name = "textBox_TS";
            this.textBox_TS.PasswordChar = '\0';
            this.textBox_TS.ReadOnly = true;
            this.textBox_TS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_TS.SelectedText = "";
            this.textBox_TS.Size = new System.Drawing.Size(165, 23);
            this.textBox_TS.TabIndex = 48;
            this.textBox_TS.UseSelectable = true;
            // 
            // textBox_CAE
            // 
            this.textBox_CAE.Lines = new string[0];
            this.textBox_CAE.Location = new System.Drawing.Point(496, 151);
            this.textBox_CAE.MaxLength = 32767;
            this.textBox_CAE.Name = "textBox_CAE";
            this.textBox_CAE.PasswordChar = '\0';
            this.textBox_CAE.ReadOnly = true;
            this.textBox_CAE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_CAE.SelectedText = "";
            this.textBox_CAE.Size = new System.Drawing.Size(165, 23);
            this.textBox_CAE.TabIndex = 47;
            this.textBox_CAE.UseSelectable = true;
            // 
            // textBox_MAE
            // 
            this.textBox_MAE.Lines = new string[0];
            this.textBox_MAE.Location = new System.Drawing.Point(163, 92);
            this.textBox_MAE.MaxLength = 32767;
            this.textBox_MAE.Name = "textBox_MAE";
            this.textBox_MAE.PasswordChar = '\0';
            this.textBox_MAE.ReadOnly = true;
            this.textBox_MAE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MAE.SelectedText = "";
            this.textBox_MAE.Size = new System.Drawing.Size(156, 23);
            this.textBox_MAE.TabIndex = 46;
            this.textBox_MAE.UseSelectable = true;
            // 
            // textBox_MPE
            // 
            this.textBox_MPE.Lines = new string[0];
            this.textBox_MPE.Location = new System.Drawing.Point(163, 121);
            this.textBox_MPE.MaxLength = 32767;
            this.textBox_MPE.Name = "textBox_MPE";
            this.textBox_MPE.PasswordChar = '\0';
            this.textBox_MPE.ReadOnly = true;
            this.textBox_MPE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MPE.SelectedText = "";
            this.textBox_MPE.Size = new System.Drawing.Size(156, 23);
            this.textBox_MPE.TabIndex = 45;
            this.textBox_MPE.UseSelectable = true;
            // 
            // textBox_MSE
            // 
            this.textBox_MSE.Lines = new string[0];
            this.textBox_MSE.Location = new System.Drawing.Point(163, 64);
            this.textBox_MSE.MaxLength = 32767;
            this.textBox_MSE.Name = "textBox_MSE";
            this.textBox_MSE.PasswordChar = '\0';
            this.textBox_MSE.ReadOnly = true;
            this.textBox_MSE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MSE.SelectedText = "";
            this.textBox_MSE.Size = new System.Drawing.Size(156, 23);
            this.textBox_MSE.TabIndex = 44;
            this.textBox_MSE.UseSelectable = true;
            // 
            // label_MAE
            // 
            this.label_MAE.AutoSize = true;
            this.label_MAE.Location = new System.Drawing.Point(13, 92);
            this.label_MAE.Name = "label_MAE";
            this.label_MAE.Size = new System.Drawing.Size(131, 19);
            this.label_MAE.TabIndex = 40;
            this.label_MAE.Text = "Mean Absolute Error";
            // 
            // label_TS
            // 
            this.label_TS.AutoSize = true;
            this.label_TS.Location = new System.Drawing.Point(329, 63);
            this.label_TS.Name = "label_TS";
            this.label_TS.Size = new System.Drawing.Size(95, 19);
            this.label_TS.TabIndex = 43;
            this.label_TS.Text = "Tracking Signal";
            // 
            // grid_ForecastedData
            // 
            this.grid_ForecastedData.AllowUserToResizeRows = false;
            this.grid_ForecastedData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_ForecastedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_ForecastedData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_ForecastedData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ForecastedData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_ForecastedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ForecastedData.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_ForecastedData.EnableHeadersVisualStyles = false;
            this.grid_ForecastedData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_ForecastedData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_ForecastedData.Location = new System.Drawing.Point(23, 190);
            this.grid_ForecastedData.Name = "grid_ForecastedData";
            this.grid_ForecastedData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ForecastedData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_ForecastedData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_ForecastedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ForecastedData.Size = new System.Drawing.Size(623, 308);
            this.grid_ForecastedData.TabIndex = 34;
            // 
            // label_MPE
            // 
            this.label_MPE.AutoSize = true;
            this.label_MPE.Location = new System.Drawing.Point(13, 121);
            this.label_MPE.Name = "label_MPE";
            this.label_MPE.Size = new System.Drawing.Size(123, 19);
            this.label_MPE.TabIndex = 36;
            this.label_MPE.Text = "Mean Percent Error";
            // 
            // label_MSE
            // 
            this.label_MSE.AutoSize = true;
            this.label_MSE.Location = new System.Drawing.Point(13, 63);
            this.label_MSE.Name = "label_MSE";
            this.label_MSE.Size = new System.Drawing.Size(120, 19);
            this.label_MSE.TabIndex = 42;
            this.label_MSE.Text = "Mean Signed Error";
            // 
            // label_MAPE
            // 
            this.label_MAPE.AutoSize = true;
            this.label_MAPE.Location = new System.Drawing.Point(13, 152);
            this.label_MAPE.Name = "label_MAPE";
            this.label_MAPE.Size = new System.Drawing.Size(144, 19);
            this.label_MAPE.TabIndex = 37;
            this.label_MAPE.Text = "Mean Ab Percent Error";
            // 
            // label_CAE
            // 
            this.label_CAE.AutoSize = true;
            this.label_CAE.Location = new System.Drawing.Point(329, 152);
            this.label_CAE.Name = "label_CAE";
            this.label_CAE.Size = new System.Drawing.Size(163, 19);
            this.label_CAE.TabIndex = 41;
            this.label_CAE.Text = "Cumulative Absolute Error";
            // 
            // label_CSE
            // 
            this.label_CSE.AutoSize = true;
            this.label_CSE.Location = new System.Drawing.Point(329, 121);
            this.label_CSE.Name = "label_CSE";
            this.label_CSE.Size = new System.Drawing.Size(152, 19);
            this.label_CSE.TabIndex = 38;
            this.label_CSE.Text = "Cumulative Signed Error";
            // 
            // label_MSqE
            // 
            this.label_MSqE.AutoSize = true;
            this.label_MSqE.Location = new System.Drawing.Point(329, 92);
            this.label_MSqE.Name = "label_MSqE";
            this.label_MSqE.Size = new System.Drawing.Size(129, 19);
            this.label_MSqE.TabIndex = 39;
            this.label_MSqE.Text = "Mean Squared Error";
            // 
            // textBox_ForecastingNumber
            // 
            this.textBox_ForecastingNumber.Lines = new string[0];
            this.textBox_ForecastingNumber.Location = new System.Drawing.Point(343, 465);
            this.textBox_ForecastingNumber.MaxLength = 32767;
            this.textBox_ForecastingNumber.Name = "textBox_ForecastingNumber";
            this.textBox_ForecastingNumber.PasswordChar = '\0';
            this.textBox_ForecastingNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_ForecastingNumber.SelectedText = "";
            this.textBox_ForecastingNumber.Size = new System.Drawing.Size(121, 23);
            this.textBox_ForecastingNumber.TabIndex = 35;
            this.textBox_ForecastingNumber.UseSelectable = true;
            // 
            // button_ForecastedDataView
            // 
            this.button_ForecastedDataView.Location = new System.Drawing.Point(343, 512);
            this.button_ForecastedDataView.Name = "button_ForecastedDataView";
            this.button_ForecastedDataView.Size = new System.Drawing.Size(121, 23);
            this.button_ForecastedDataView.TabIndex = 28;
            this.button_ForecastedDataView.Text = "View Forecasted Data";
            this.button_ForecastedDataView.UseSelectable = true;
            this.button_ForecastedDataView.Click += new System.EventHandler(this.button_ForecastedDataView_Click_1);
            // 
            // comboBox_ForecastingType
            // 
            this.comboBox_ForecastingType.FormattingEnabled = true;
            this.comboBox_ForecastingType.ItemHeight = 23;
            this.comboBox_ForecastingType.Location = new System.Drawing.Point(343, 413);
            this.comboBox_ForecastingType.Name = "comboBox_ForecastingType";
            this.comboBox_ForecastingType.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ForecastingType.TabIndex = 31;
            this.comboBox_ForecastingType.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_ForecastedSeason);
            this.groupBox3.Controls.Add(this.radioButton_ForecastedMonth);
            this.groupBox3.Location = new System.Drawing.Point(315, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 32);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // radioButton_ForecastedSeason
            // 
            this.radioButton_ForecastedSeason.AutoSize = true;
            this.radioButton_ForecastedSeason.Location = new System.Drawing.Point(83, 12);
            this.radioButton_ForecastedSeason.Name = "radioButton_ForecastedSeason";
            this.radioButton_ForecastedSeason.Size = new System.Drawing.Size(60, 15);
            this.radioButton_ForecastedSeason.TabIndex = 11;
            this.radioButton_ForecastedSeason.Text = "Season";
            this.radioButton_ForecastedSeason.UseSelectable = true;
            this.radioButton_ForecastedSeason.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // radioButton_ForecastedMonth
            // 
            this.radioButton_ForecastedMonth.AutoSize = true;
            this.radioButton_ForecastedMonth.Location = new System.Drawing.Point(8, 12);
            this.radioButton_ForecastedMonth.Name = "radioButton_ForecastedMonth";
            this.radioButton_ForecastedMonth.Size = new System.Drawing.Size(59, 15);
            this.radioButton_ForecastedMonth.TabIndex = 10;
            this.radioButton_ForecastedMonth.Text = "Month";
            this.radioButton_ForecastedMonth.UseSelectable = true;
            this.radioButton_ForecastedMonth.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // label_ForecastingNumber
            // 
            this.label_ForecastingNumber.AutoSize = true;
            this.label_ForecastingNumber.Location = new System.Drawing.Point(71, 465);
            this.label_ForecastingNumber.Name = "label_ForecastingNumber";
            this.label_ForecastingNumber.Size = new System.Drawing.Size(220, 19);
            this.label_ForecastingNumber.TabIndex = 32;
            this.label_ForecastingNumber.Text = "Select extended number to Forecast";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_ForecastedIncome);
            this.groupBox4.Controls.Add(this.radioButton_ForecastedQuantity);
            this.groupBox4.Location = new System.Drawing.Point(315, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 32);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // radioButton_ForecastedIncome
            // 
            this.radioButton_ForecastedIncome.AutoSize = true;
            this.radioButton_ForecastedIncome.Location = new System.Drawing.Point(83, 11);
            this.radioButton_ForecastedIncome.Name = "radioButton_ForecastedIncome";
            this.radioButton_ForecastedIncome.Size = new System.Drawing.Size(63, 15);
            this.radioButton_ForecastedIncome.TabIndex = 8;
            this.radioButton_ForecastedIncome.Text = "Income";
            this.radioButton_ForecastedIncome.UseSelectable = true;
            this.radioButton_ForecastedIncome.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // radioButton_ForecastedQuantity
            // 
            this.radioButton_ForecastedQuantity.AutoSize = true;
            this.radioButton_ForecastedQuantity.Location = new System.Drawing.Point(6, 11);
            this.radioButton_ForecastedQuantity.Name = "radioButton_ForecastedQuantity";
            this.radioButton_ForecastedQuantity.Size = new System.Drawing.Size(69, 15);
            this.radioButton_ForecastedQuantity.TabIndex = 7;
            this.radioButton_ForecastedQuantity.Text = "Quantity";
            this.radioButton_ForecastedQuantity.UseSelectable = true;
            this.radioButton_ForecastedQuantity.CheckedChanged += new System.EventHandler(this.metroRadioButton4_CheckedChanged);
            // 
            // label_ForecastingType
            // 
            this.label_ForecastingType.AutoSize = true;
            this.label_ForecastingType.Location = new System.Drawing.Point(71, 418);
            this.label_ForecastingType.Name = "label_ForecastingType";
            this.label_ForecastingType.Size = new System.Drawing.Size(145, 19);
            this.label_ForecastingType.TabIndex = 31;
            this.label_ForecastingType.Text = "Select Forecasting Type";
            // 
            // comboBox_ForecastedDateRange
            // 
            this.comboBox_ForecastedDateRange.FormattingEnabled = true;
            this.comboBox_ForecastedDateRange.ItemHeight = 23;
            this.comboBox_ForecastedDateRange.Location = new System.Drawing.Point(343, 319);
            this.comboBox_ForecastedDateRange.Name = "comboBox_ForecastedDateRange";
            this.comboBox_ForecastedDateRange.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ForecastedDateRange.TabIndex = 25;
            this.comboBox_ForecastedDateRange.UseSelectable = true;
            // 
            // label_ForecastedDateRange
            // 
            this.label_ForecastedDateRange.AutoSize = true;
            this.label_ForecastedDateRange.Location = new System.Drawing.Point(71, 283);
            this.label_ForecastedDateRange.Name = "label_ForecastedDateRange";
            this.label_ForecastedDateRange.Size = new System.Drawing.Size(115, 19);
            this.label_ForecastedDateRange.TabIndex = 24;
            this.label_ForecastedDateRange.Text = "Select Date Range";
            // 
            // label_ForecastedValue
            // 
            this.label_ForecastedValue.AutoSize = true;
            this.label_ForecastedValue.Location = new System.Drawing.Point(71, 243);
            this.label_ForecastedValue.Name = "label_ForecastedValue";
            this.label_ForecastedValue.Size = new System.Drawing.Size(146, 19);
            this.label_ForecastedValue.TabIndex = 23;
            this.label_ForecastedValue.Text = "Select Value to Forecast";
            // 
            // comboBox_ForecastedRegion
            // 
            this.comboBox_ForecastedRegion.FormattingEnabled = true;
            this.comboBox_ForecastedRegion.ItemHeight = 23;
            this.comboBox_ForecastedRegion.Location = new System.Drawing.Point(343, 164);
            this.comboBox_ForecastedRegion.Name = "comboBox_ForecastedRegion";
            this.comboBox_ForecastedRegion.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ForecastedRegion.TabIndex = 22;
            this.comboBox_ForecastedRegion.UseSelectable = true;
            // 
            // comboBox_ForecastedCountry
            // 
            this.comboBox_ForecastedCountry.FormattingEnabled = true;
            this.comboBox_ForecastedCountry.ItemHeight = 23;
            this.comboBox_ForecastedCountry.Location = new System.Drawing.Point(343, 121);
            this.comboBox_ForecastedCountry.Name = "comboBox_ForecastedCountry";
            this.comboBox_ForecastedCountry.Size = new System.Drawing.Size(121, 29);
            this.comboBox_ForecastedCountry.TabIndex = 21;
            this.comboBox_ForecastedCountry.UseSelectable = true;
            this.comboBox_ForecastedCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_ForecastedCountry_SelectedIndexChanged);
            // 
            // label_ForecastedRegion
            // 
            this.label_ForecastedRegion.AutoSize = true;
            this.label_ForecastedRegion.Location = new System.Drawing.Point(71, 168);
            this.label_ForecastedRegion.Name = "label_ForecastedRegion";
            this.label_ForecastedRegion.Size = new System.Drawing.Size(88, 19);
            this.label_ForecastedRegion.TabIndex = 20;
            this.label_ForecastedRegion.Text = "Select Region";
            // 
            // label_ForecastedCountry
            // 
            this.label_ForecastedCountry.AutoSize = true;
            this.label_ForecastedCountry.Location = new System.Drawing.Point(71, 121);
            this.label_ForecastedCountry.Name = "label_ForecastedCountry";
            this.label_ForecastedCountry.Size = new System.Drawing.Size(94, 19);
            this.label_ForecastedCountry.TabIndex = 19;
            this.label_ForecastedCountry.Text = "Select Country";
            // 
            // label_ForecastedTitle
            // 
            this.label_ForecastedTitle.AutoSize = true;
            this.label_ForecastedTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_ForecastedTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_ForecastedTitle.Location = new System.Drawing.Point(71, 70);
            this.label_ForecastedTitle.Name = "label_ForecastedTitle";
            this.label_ForecastedTitle.Size = new System.Drawing.Size(146, 50);
            this.label_ForecastedTitle.TabIndex = 3;
            this.label_ForecastedTitle.Text = "Forecasted Value\r\n";
            // 
            // button_ForecastedBack
            // 
            this.button_ForecastedBack.Location = new System.Drawing.Point(17, 4);
            this.button_ForecastedBack.Name = "button_ForecastedBack";
            this.button_ForecastedBack.Size = new System.Drawing.Size(75, 23);
            this.button_ForecastedBack.TabIndex = 2;
            this.button_ForecastedBack.Text = "Back";
            this.button_ForecastedBack.UseSelectable = true;
            this.button_ForecastedBack.Click += new System.EventHandler(this.button_ForecastedBack_Click);
            // 
            // panel_NewAdmin
            // 
            this.panel_NewAdmin.Controls.Add(this.button_SubmitNewAdmin);
            this.panel_NewAdmin.Controls.Add(this.textBox_EmailAdmin);
            this.panel_NewAdmin.Controls.Add(this.textBox_UsernameAdmin);
            this.panel_NewAdmin.Controls.Add(this.textBox_PasswordAdmin);
            this.panel_NewAdmin.Controls.Add(this.textBox_RePasswordAdmin);
            this.panel_NewAdmin.Controls.Add(this.textBox_NameAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_PasswordAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_RePasswordAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_NameAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_EmailAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_UsernameAdmin);
            this.panel_NewAdmin.Controls.Add(this.button_BackNewAdmin);
            this.panel_NewAdmin.Controls.Add(this.label_TitleNewAdmin);
            this.panel_NewAdmin.HorizontalScrollbarBarColor = true;
            this.panel_NewAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_NewAdmin.HorizontalScrollbarSize = 10;
            this.panel_NewAdmin.Location = new System.Drawing.Point(7, 63);
            this.panel_NewAdmin.Name = "panel_NewAdmin";
            this.panel_NewAdmin.Size = new System.Drawing.Size(1179, 579);
            this.panel_NewAdmin.TabIndex = 30;
            this.panel_NewAdmin.VerticalScrollbarBarColor = true;
            this.panel_NewAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.panel_NewAdmin.VerticalScrollbarSize = 10;
            // 
            // button_SubmitNewAdmin
            // 
            this.button_SubmitNewAdmin.Location = new System.Drawing.Point(445, 414);
            this.button_SubmitNewAdmin.Name = "button_SubmitNewAdmin";
            this.button_SubmitNewAdmin.Size = new System.Drawing.Size(75, 23);
            this.button_SubmitNewAdmin.TabIndex = 14;
            this.button_SubmitNewAdmin.Text = "Submit";
            this.button_SubmitNewAdmin.UseSelectable = true;
            this.button_SubmitNewAdmin.Click += new System.EventHandler(this.button_SubmitNewAdmin_Click);
            // 
            // textBox_EmailAdmin
            // 
            this.textBox_EmailAdmin.Lines = new string[0];
            this.textBox_EmailAdmin.Location = new System.Drawing.Point(307, 198);
            this.textBox_EmailAdmin.MaxLength = 32767;
            this.textBox_EmailAdmin.Name = "textBox_EmailAdmin";
            this.textBox_EmailAdmin.PasswordChar = '\0';
            this.textBox_EmailAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_EmailAdmin.SelectedText = "";
            this.textBox_EmailAdmin.Size = new System.Drawing.Size(213, 23);
            this.textBox_EmailAdmin.TabIndex = 13;
            this.textBox_EmailAdmin.UseSelectable = true;
            // 
            // textBox_UsernameAdmin
            // 
            this.textBox_UsernameAdmin.Lines = new string[0];
            this.textBox_UsernameAdmin.Location = new System.Drawing.Point(307, 246);
            this.textBox_UsernameAdmin.MaxLength = 32767;
            this.textBox_UsernameAdmin.Name = "textBox_UsernameAdmin";
            this.textBox_UsernameAdmin.PasswordChar = '\0';
            this.textBox_UsernameAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_UsernameAdmin.SelectedText = "";
            this.textBox_UsernameAdmin.Size = new System.Drawing.Size(213, 23);
            this.textBox_UsernameAdmin.TabIndex = 12;
            this.textBox_UsernameAdmin.UseSelectable = true;
            // 
            // textBox_PasswordAdmin
            // 
            this.textBox_PasswordAdmin.Lines = new string[0];
            this.textBox_PasswordAdmin.Location = new System.Drawing.Point(307, 298);
            this.textBox_PasswordAdmin.MaxLength = 32767;
            this.textBox_PasswordAdmin.Name = "textBox_PasswordAdmin";
            this.textBox_PasswordAdmin.PasswordChar = '*';
            this.textBox_PasswordAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_PasswordAdmin.SelectedText = "";
            this.textBox_PasswordAdmin.Size = new System.Drawing.Size(213, 23);
            this.textBox_PasswordAdmin.TabIndex = 11;
            this.textBox_PasswordAdmin.UseSelectable = true;
            // 
            // textBox_RePasswordAdmin
            // 
            this.textBox_RePasswordAdmin.Lines = new string[0];
            this.textBox_RePasswordAdmin.Location = new System.Drawing.Point(307, 351);
            this.textBox_RePasswordAdmin.MaxLength = 32767;
            this.textBox_RePasswordAdmin.Name = "textBox_RePasswordAdmin";
            this.textBox_RePasswordAdmin.PasswordChar = '*';
            this.textBox_RePasswordAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_RePasswordAdmin.SelectedText = "";
            this.textBox_RePasswordAdmin.Size = new System.Drawing.Size(213, 23);
            this.textBox_RePasswordAdmin.TabIndex = 10;
            this.textBox_RePasswordAdmin.UseSelectable = true;
            // 
            // textBox_NameAdmin
            // 
            this.textBox_NameAdmin.Lines = new string[0];
            this.textBox_NameAdmin.Location = new System.Drawing.Point(307, 148);
            this.textBox_NameAdmin.MaxLength = 32767;
            this.textBox_NameAdmin.Name = "textBox_NameAdmin";
            this.textBox_NameAdmin.PasswordChar = '\0';
            this.textBox_NameAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_NameAdmin.SelectedText = "";
            this.textBox_NameAdmin.Size = new System.Drawing.Size(213, 23);
            this.textBox_NameAdmin.TabIndex = 9;
            this.textBox_NameAdmin.UseSelectable = true;
            // 
            // label_PasswordAdmin
            // 
            this.label_PasswordAdmin.AutoSize = true;
            this.label_PasswordAdmin.Location = new System.Drawing.Point(82, 302);
            this.label_PasswordAdmin.Name = "label_PasswordAdmin";
            this.label_PasswordAdmin.Size = new System.Drawing.Size(63, 19);
            this.label_PasswordAdmin.TabIndex = 8;
            this.label_PasswordAdmin.Text = "Password";
            // 
            // label_RePasswordAdmin
            // 
            this.label_RePasswordAdmin.AutoSize = true;
            this.label_RePasswordAdmin.Location = new System.Drawing.Point(82, 351);
            this.label_RePasswordAdmin.Name = "label_RePasswordAdmin";
            this.label_RePasswordAdmin.Size = new System.Drawing.Size(118, 19);
            this.label_RePasswordAdmin.TabIndex = 7;
            this.label_RePasswordAdmin.Text = "Re-Enter Password";
            // 
            // label_NameAdmin
            // 
            this.label_NameAdmin.AutoSize = true;
            this.label_NameAdmin.Location = new System.Drawing.Point(82, 148);
            this.label_NameAdmin.Name = "label_NameAdmin";
            this.label_NameAdmin.Size = new System.Drawing.Size(45, 19);
            this.label_NameAdmin.TabIndex = 6;
            this.label_NameAdmin.Text = "Name";
            // 
            // label_EmailAdmin
            // 
            this.label_EmailAdmin.AutoSize = true;
            this.label_EmailAdmin.Location = new System.Drawing.Point(82, 198);
            this.label_EmailAdmin.Name = "label_EmailAdmin";
            this.label_EmailAdmin.Size = new System.Drawing.Size(92, 19);
            this.label_EmailAdmin.TabIndex = 5;
            this.label_EmailAdmin.Text = "Email Address";
            // 
            // label_UsernameAdmin
            // 
            this.label_UsernameAdmin.AutoSize = true;
            this.label_UsernameAdmin.Location = new System.Drawing.Point(82, 250);
            this.label_UsernameAdmin.Name = "label_UsernameAdmin";
            this.label_UsernameAdmin.Size = new System.Drawing.Size(68, 19);
            this.label_UsernameAdmin.TabIndex = 4;
            this.label_UsernameAdmin.Text = "Username";
            // 
            // button_BackNewAdmin
            // 
            this.button_BackNewAdmin.Location = new System.Drawing.Point(17, 4);
            this.button_BackNewAdmin.Name = "button_BackNewAdmin";
            this.button_BackNewAdmin.Size = new System.Drawing.Size(75, 23);
            this.button_BackNewAdmin.TabIndex = 3;
            this.button_BackNewAdmin.Text = "Back";
            this.button_BackNewAdmin.UseSelectable = true;
            this.button_BackNewAdmin.Click += new System.EventHandler(this.button_BackNewAdmin_Click);
            // 
            // label_TitleNewAdmin
            // 
            this.label_TitleNewAdmin.AutoSize = true;
            this.label_TitleNewAdmin.Location = new System.Drawing.Point(82, 66);
            this.label_TitleNewAdmin.Name = "label_TitleNewAdmin";
            this.label_TitleNewAdmin.Size = new System.Drawing.Size(162, 19);
            this.label_TitleNewAdmin.TabIndex = 2;
            this.label_TitleNewAdmin.Text = "Create New Administrator";
            // 
            // panel_NewDealer
            // 
            this.panel_NewDealer.Controls.Add(this.button_SubmitNewDealer);
            this.panel_NewDealer.Controls.Add(this.textBox_EmailDealer);
            this.panel_NewDealer.Controls.Add(this.textBox_UsernameDealer);
            this.panel_NewDealer.Controls.Add(this.textBox_PasswordDealer);
            this.panel_NewDealer.Controls.Add(this.textBox_RePasswordDealer);
            this.panel_NewDealer.Controls.Add(this.textBox_NameDealer);
            this.panel_NewDealer.Controls.Add(this.label_PasswordDealer);
            this.panel_NewDealer.Controls.Add(this.label_RePasswordDealer);
            this.panel_NewDealer.Controls.Add(this.label_NameDealer);
            this.panel_NewDealer.Controls.Add(this.label_EmailDealer);
            this.panel_NewDealer.Controls.Add(this.label_UsernameDealer);
            this.panel_NewDealer.Controls.Add(this.button_BackDealer);
            this.panel_NewDealer.Controls.Add(this.label_NewDealerTitle);
            this.panel_NewDealer.HorizontalScrollbarBarColor = true;
            this.panel_NewDealer.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_NewDealer.HorizontalScrollbarSize = 10;
            this.panel_NewDealer.Location = new System.Drawing.Point(7, 63);
            this.panel_NewDealer.Name = "panel_NewDealer";
            this.panel_NewDealer.Size = new System.Drawing.Size(1179, 579);
            this.panel_NewDealer.TabIndex = 31;
            this.panel_NewDealer.VerticalScrollbarBarColor = true;
            this.panel_NewDealer.VerticalScrollbarHighlightOnWheel = false;
            this.panel_NewDealer.VerticalScrollbarSize = 10;
            // 
            // button_SubmitNewDealer
            // 
            this.button_SubmitNewDealer.Location = new System.Drawing.Point(445, 414);
            this.button_SubmitNewDealer.Name = "button_SubmitNewDealer";
            this.button_SubmitNewDealer.Size = new System.Drawing.Size(75, 23);
            this.button_SubmitNewDealer.TabIndex = 27;
            this.button_SubmitNewDealer.Text = "Submit";
            this.button_SubmitNewDealer.UseSelectable = true;
            this.button_SubmitNewDealer.Click += new System.EventHandler(this.button_SubmitNewDealer_Click);
            // 
            // textBox_EmailDealer
            // 
            this.textBox_EmailDealer.Lines = new string[0];
            this.textBox_EmailDealer.Location = new System.Drawing.Point(307, 198);
            this.textBox_EmailDealer.MaxLength = 32767;
            this.textBox_EmailDealer.Name = "textBox_EmailDealer";
            this.textBox_EmailDealer.PasswordChar = '\0';
            this.textBox_EmailDealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_EmailDealer.SelectedText = "";
            this.textBox_EmailDealer.Size = new System.Drawing.Size(213, 23);
            this.textBox_EmailDealer.TabIndex = 26;
            this.textBox_EmailDealer.UseSelectable = true;
            // 
            // textBox_UsernameDealer
            // 
            this.textBox_UsernameDealer.Lines = new string[0];
            this.textBox_UsernameDealer.Location = new System.Drawing.Point(307, 246);
            this.textBox_UsernameDealer.MaxLength = 32767;
            this.textBox_UsernameDealer.Name = "textBox_UsernameDealer";
            this.textBox_UsernameDealer.PasswordChar = '\0';
            this.textBox_UsernameDealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_UsernameDealer.SelectedText = "";
            this.textBox_UsernameDealer.Size = new System.Drawing.Size(213, 23);
            this.textBox_UsernameDealer.TabIndex = 25;
            this.textBox_UsernameDealer.UseSelectable = true;
            // 
            // textBox_PasswordDealer
            // 
            this.textBox_PasswordDealer.Lines = new string[0];
            this.textBox_PasswordDealer.Location = new System.Drawing.Point(307, 298);
            this.textBox_PasswordDealer.MaxLength = 32767;
            this.textBox_PasswordDealer.Name = "textBox_PasswordDealer";
            this.textBox_PasswordDealer.PasswordChar = '*';
            this.textBox_PasswordDealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_PasswordDealer.SelectedText = "";
            this.textBox_PasswordDealer.Size = new System.Drawing.Size(213, 23);
            this.textBox_PasswordDealer.TabIndex = 24;
            this.textBox_PasswordDealer.UseSelectable = true;
            // 
            // textBox_RePasswordDealer
            // 
            this.textBox_RePasswordDealer.Lines = new string[0];
            this.textBox_RePasswordDealer.Location = new System.Drawing.Point(307, 351);
            this.textBox_RePasswordDealer.MaxLength = 32767;
            this.textBox_RePasswordDealer.Name = "textBox_RePasswordDealer";
            this.textBox_RePasswordDealer.PasswordChar = '*';
            this.textBox_RePasswordDealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_RePasswordDealer.SelectedText = "";
            this.textBox_RePasswordDealer.Size = new System.Drawing.Size(213, 23);
            this.textBox_RePasswordDealer.TabIndex = 23;
            this.textBox_RePasswordDealer.UseSelectable = true;
            // 
            // textBox_NameDealer
            // 
            this.textBox_NameDealer.Lines = new string[0];
            this.textBox_NameDealer.Location = new System.Drawing.Point(307, 148);
            this.textBox_NameDealer.MaxLength = 32767;
            this.textBox_NameDealer.Name = "textBox_NameDealer";
            this.textBox_NameDealer.PasswordChar = '\0';
            this.textBox_NameDealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_NameDealer.SelectedText = "";
            this.textBox_NameDealer.Size = new System.Drawing.Size(213, 23);
            this.textBox_NameDealer.TabIndex = 22;
            this.textBox_NameDealer.UseSelectable = true;
            // 
            // label_PasswordDealer
            // 
            this.label_PasswordDealer.AutoSize = true;
            this.label_PasswordDealer.Location = new System.Drawing.Point(82, 302);
            this.label_PasswordDealer.Name = "label_PasswordDealer";
            this.label_PasswordDealer.Size = new System.Drawing.Size(63, 19);
            this.label_PasswordDealer.TabIndex = 21;
            this.label_PasswordDealer.Text = "Password";
            // 
            // label_RePasswordDealer
            // 
            this.label_RePasswordDealer.AutoSize = true;
            this.label_RePasswordDealer.Location = new System.Drawing.Point(82, 351);
            this.label_RePasswordDealer.Name = "label_RePasswordDealer";
            this.label_RePasswordDealer.Size = new System.Drawing.Size(118, 19);
            this.label_RePasswordDealer.TabIndex = 20;
            this.label_RePasswordDealer.Text = "Re-Enter Password";
            // 
            // label_NameDealer
            // 
            this.label_NameDealer.AutoSize = true;
            this.label_NameDealer.Location = new System.Drawing.Point(82, 148);
            this.label_NameDealer.Name = "label_NameDealer";
            this.label_NameDealer.Size = new System.Drawing.Size(45, 19);
            this.label_NameDealer.TabIndex = 19;
            this.label_NameDealer.Text = "Name";
            // 
            // label_EmailDealer
            // 
            this.label_EmailDealer.AutoSize = true;
            this.label_EmailDealer.Location = new System.Drawing.Point(82, 198);
            this.label_EmailDealer.Name = "label_EmailDealer";
            this.label_EmailDealer.Size = new System.Drawing.Size(92, 19);
            this.label_EmailDealer.TabIndex = 18;
            this.label_EmailDealer.Text = "Email Address";
            // 
            // label_UsernameDealer
            // 
            this.label_UsernameDealer.AutoSize = true;
            this.label_UsernameDealer.Location = new System.Drawing.Point(82, 250);
            this.label_UsernameDealer.Name = "label_UsernameDealer";
            this.label_UsernameDealer.Size = new System.Drawing.Size(68, 19);
            this.label_UsernameDealer.TabIndex = 17;
            this.label_UsernameDealer.Text = "Username";
            // 
            // button_BackDealer
            // 
            this.button_BackDealer.Location = new System.Drawing.Point(17, 4);
            this.button_BackDealer.Name = "button_BackDealer";
            this.button_BackDealer.Size = new System.Drawing.Size(75, 23);
            this.button_BackDealer.TabIndex = 16;
            this.button_BackDealer.Text = "Back";
            this.button_BackDealer.UseSelectable = true;
            this.button_BackDealer.Click += new System.EventHandler(this.button_BackDealer_Click);
            // 
            // label_NewDealerTitle
            // 
            this.label_NewDealerTitle.AutoSize = true;
            this.label_NewDealerTitle.Location = new System.Drawing.Point(82, 66);
            this.label_NewDealerTitle.Name = "label_NewDealerTitle";
            this.label_NewDealerTitle.Size = new System.Drawing.Size(171, 19);
            this.label_NewDealerTitle.TabIndex = 15;
            this.label_NewDealerTitle.Text = "Create New Dealer Account";
            // 
            // panel_NewAnalysist
            // 
            this.panel_NewAnalysist.Controls.Add(this.button_SubmitNewAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.textBox_EmailAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.textBox_UsernameAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.textBox_PasswordAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.textBox_RePasswordAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.textBox_NameAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_PasswordAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_RePasswordAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_NameAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_EmailAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_UsernameAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.button_BackAnalysist);
            this.panel_NewAnalysist.Controls.Add(this.label_NewAnalysistTitle);
            this.panel_NewAnalysist.HorizontalScrollbarBarColor = true;
            this.panel_NewAnalysist.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_NewAnalysist.HorizontalScrollbarSize = 10;
            this.panel_NewAnalysist.Location = new System.Drawing.Point(7, 63);
            this.panel_NewAnalysist.Name = "panel_NewAnalysist";
            this.panel_NewAnalysist.Size = new System.Drawing.Size(1179, 579);
            this.panel_NewAnalysist.TabIndex = 32;
            this.panel_NewAnalysist.VerticalScrollbarBarColor = true;
            this.panel_NewAnalysist.VerticalScrollbarHighlightOnWheel = false;
            this.panel_NewAnalysist.VerticalScrollbarSize = 10;
            // 
            // button_SubmitNewAnalysist
            // 
            this.button_SubmitNewAnalysist.Location = new System.Drawing.Point(445, 414);
            this.button_SubmitNewAnalysist.Name = "button_SubmitNewAnalysist";
            this.button_SubmitNewAnalysist.Size = new System.Drawing.Size(75, 23);
            this.button_SubmitNewAnalysist.TabIndex = 27;
            this.button_SubmitNewAnalysist.Text = "Submit";
            this.button_SubmitNewAnalysist.UseSelectable = true;
            this.button_SubmitNewAnalysist.Click += new System.EventHandler(this.button_SubmitNewAnalysist_Click);
            // 
            // textBox_EmailAnalysist
            // 
            this.textBox_EmailAnalysist.Lines = new string[0];
            this.textBox_EmailAnalysist.Location = new System.Drawing.Point(307, 198);
            this.textBox_EmailAnalysist.MaxLength = 32767;
            this.textBox_EmailAnalysist.Name = "textBox_EmailAnalysist";
            this.textBox_EmailAnalysist.PasswordChar = '\0';
            this.textBox_EmailAnalysist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_EmailAnalysist.SelectedText = "";
            this.textBox_EmailAnalysist.Size = new System.Drawing.Size(213, 23);
            this.textBox_EmailAnalysist.TabIndex = 26;
            this.textBox_EmailAnalysist.UseSelectable = true;
            // 
            // textBox_UsernameAnalysist
            // 
            this.textBox_UsernameAnalysist.Lines = new string[0];
            this.textBox_UsernameAnalysist.Location = new System.Drawing.Point(307, 246);
            this.textBox_UsernameAnalysist.MaxLength = 32767;
            this.textBox_UsernameAnalysist.Name = "textBox_UsernameAnalysist";
            this.textBox_UsernameAnalysist.PasswordChar = '\0';
            this.textBox_UsernameAnalysist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_UsernameAnalysist.SelectedText = "";
            this.textBox_UsernameAnalysist.Size = new System.Drawing.Size(213, 23);
            this.textBox_UsernameAnalysist.TabIndex = 25;
            this.textBox_UsernameAnalysist.UseSelectable = true;
            // 
            // textBox_PasswordAnalysist
            // 
            this.textBox_PasswordAnalysist.Lines = new string[0];
            this.textBox_PasswordAnalysist.Location = new System.Drawing.Point(307, 298);
            this.textBox_PasswordAnalysist.MaxLength = 32767;
            this.textBox_PasswordAnalysist.Name = "textBox_PasswordAnalysist";
            this.textBox_PasswordAnalysist.PasswordChar = '*';
            this.textBox_PasswordAnalysist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_PasswordAnalysist.SelectedText = "";
            this.textBox_PasswordAnalysist.Size = new System.Drawing.Size(213, 23);
            this.textBox_PasswordAnalysist.TabIndex = 24;
            this.textBox_PasswordAnalysist.UseSelectable = true;
            // 
            // textBox_RePasswordAnalysist
            // 
            this.textBox_RePasswordAnalysist.Lines = new string[0];
            this.textBox_RePasswordAnalysist.Location = new System.Drawing.Point(307, 351);
            this.textBox_RePasswordAnalysist.MaxLength = 32767;
            this.textBox_RePasswordAnalysist.Name = "textBox_RePasswordAnalysist";
            this.textBox_RePasswordAnalysist.PasswordChar = '*';
            this.textBox_RePasswordAnalysist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_RePasswordAnalysist.SelectedText = "";
            this.textBox_RePasswordAnalysist.Size = new System.Drawing.Size(213, 23);
            this.textBox_RePasswordAnalysist.TabIndex = 23;
            this.textBox_RePasswordAnalysist.UseSelectable = true;
            // 
            // textBox_NameAnalysist
            // 
            this.textBox_NameAnalysist.Lines = new string[0];
            this.textBox_NameAnalysist.Location = new System.Drawing.Point(307, 148);
            this.textBox_NameAnalysist.MaxLength = 32767;
            this.textBox_NameAnalysist.Name = "textBox_NameAnalysist";
            this.textBox_NameAnalysist.PasswordChar = '\0';
            this.textBox_NameAnalysist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_NameAnalysist.SelectedText = "";
            this.textBox_NameAnalysist.Size = new System.Drawing.Size(213, 23);
            this.textBox_NameAnalysist.TabIndex = 22;
            this.textBox_NameAnalysist.UseSelectable = true;
            // 
            // label_PasswordAnalysist
            // 
            this.label_PasswordAnalysist.AutoSize = true;
            this.label_PasswordAnalysist.Location = new System.Drawing.Point(82, 302);
            this.label_PasswordAnalysist.Name = "label_PasswordAnalysist";
            this.label_PasswordAnalysist.Size = new System.Drawing.Size(63, 19);
            this.label_PasswordAnalysist.TabIndex = 21;
            this.label_PasswordAnalysist.Text = "Password";
            // 
            // label_RePasswordAnalysist
            // 
            this.label_RePasswordAnalysist.AutoSize = true;
            this.label_RePasswordAnalysist.Location = new System.Drawing.Point(82, 351);
            this.label_RePasswordAnalysist.Name = "label_RePasswordAnalysist";
            this.label_RePasswordAnalysist.Size = new System.Drawing.Size(118, 19);
            this.label_RePasswordAnalysist.TabIndex = 20;
            this.label_RePasswordAnalysist.Text = "Re-Enter Password";
            // 
            // label_NameAnalysist
            // 
            this.label_NameAnalysist.AutoSize = true;
            this.label_NameAnalysist.Location = new System.Drawing.Point(82, 148);
            this.label_NameAnalysist.Name = "label_NameAnalysist";
            this.label_NameAnalysist.Size = new System.Drawing.Size(45, 19);
            this.label_NameAnalysist.TabIndex = 19;
            this.label_NameAnalysist.Text = "Name";
            // 
            // label_EmailAnalysist
            // 
            this.label_EmailAnalysist.AutoSize = true;
            this.label_EmailAnalysist.Location = new System.Drawing.Point(82, 198);
            this.label_EmailAnalysist.Name = "label_EmailAnalysist";
            this.label_EmailAnalysist.Size = new System.Drawing.Size(92, 19);
            this.label_EmailAnalysist.TabIndex = 18;
            this.label_EmailAnalysist.Text = "Email Address";
            // 
            // label_UsernameAnalysist
            // 
            this.label_UsernameAnalysist.AutoSize = true;
            this.label_UsernameAnalysist.Location = new System.Drawing.Point(82, 250);
            this.label_UsernameAnalysist.Name = "label_UsernameAnalysist";
            this.label_UsernameAnalysist.Size = new System.Drawing.Size(68, 19);
            this.label_UsernameAnalysist.TabIndex = 17;
            this.label_UsernameAnalysist.Text = "Username";
            // 
            // button_BackAnalysist
            // 
            this.button_BackAnalysist.Location = new System.Drawing.Point(17, 4);
            this.button_BackAnalysist.Name = "button_BackAnalysist";
            this.button_BackAnalysist.Size = new System.Drawing.Size(75, 23);
            this.button_BackAnalysist.TabIndex = 16;
            this.button_BackAnalysist.Text = "Back";
            this.button_BackAnalysist.UseSelectable = true;
            this.button_BackAnalysist.Click += new System.EventHandler(this.button_BackAnalysist_Click);
            // 
            // label_NewAnalysistTitle
            // 
            this.label_NewAnalysistTitle.AutoSize = true;
            this.label_NewAnalysistTitle.Location = new System.Drawing.Point(82, 66);
            this.label_NewAnalysistTitle.Name = "label_NewAnalysistTitle";
            this.label_NewAnalysistTitle.Size = new System.Drawing.Size(182, 19);
            this.label_NewAnalysistTitle.TabIndex = 15;
            this.label_NewAnalysistTitle.Text = "Create New Analysist Account";
            // 
            // toolTip
            // 
            this.toolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label_LoggedName
            // 
            this.label_LoggedName.AutoSize = true;
            this.label_LoggedName.Location = new System.Drawing.Point(924, 41);
            this.label_LoggedName.Name = "label_LoggedName";
            this.label_LoggedName.Size = new System.Drawing.Size(0, 0);
            this.label_LoggedName.TabIndex = 33;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 2000;
            this.ClientSize = new System.Drawing.Size(1189, 645);
            this.Controls.Add(this.panel_Chart);
            this.Controls.Add(this.panel_ForecastedData);
            this.Controls.Add(this.label_LoggedName);
            this.Controls.Add(this.panel_choice);
            this.Controls.Add(this.panel_Analyst);
            this.Controls.Add(this.panel_NewAdmin);
            this.Controls.Add(this.panel_Admin);
            this.Controls.Add(this.panel_pastData);
            this.Controls.Add(this.panel_NewDealer);
            this.Controls.Add(this.panel_NewAnalysist);
            this.Controls.Add(this.button_logout);
            this.Name = "Main_Form";
            this.Text = "Sales Analyser";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panel_choice.ResumeLayout(false);
            this.panel_Analyst.ResumeLayout(false);
            this.panel_pastData.ResumeLayout(false);
            this.panel_pastData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pastData)).EndInit();
            this.panel_Chart.ResumeLayout(false);
            this.panel_Chart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PastData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_Admin.ResumeLayout(false);
            this.panel_ForecastedData.ResumeLayout(false);
            this.panel_ForecastedData.PerformLayout();
            this.panel_forecastedGrid.ResumeLayout(false);
            this.panel_forecastedGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ForecastedData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel_NewAdmin.ResumeLayout(false);
            this.panel_NewAdmin.PerformLayout();
            this.panel_NewDealer.ResumeLayout(false);
            this.panel_NewDealer.PerformLayout();
            this.panel_NewAnalysist.ResumeLayout(false);
            this.panel_NewAnalysist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_choice;
        private MetroFramework.Controls.MetroTile tile_reviewer;
        private MetroFramework.Controls.MetroTile tile_analyst;
        private MetroFramework.Controls.MetroTile tile_admin;
        private MetroFramework.Controls.MetroPanel panel_Analyst;
        private MetroFramework.Controls.MetroButton button_logout;
        private MetroFramework.Controls.MetroTile tile_PastSalesDataGraph;
        private MetroFramework.Controls.MetroTile tile_PastSalesDataGrid;
        private MetroFramework.Controls.MetroPanel panel_pastData;
        private MetroFramework.Controls.MetroComboBox comboBox_PastDataRegion;
        private MetroFramework.Controls.MetroLabel label_pastDataRegion;
        private MetroFramework.Controls.MetroLabel label_PastDataCountry;
        private MetroFramework.Controls.MetroComboBox comboBox_pastDataCountry;
        private MetroFramework.Controls.MetroGrid grid_pastData;
        private MetroFramework.Controls.MetroButton button_pastSalesData;
        private MetroFramework.Controls.MetroPanel panel_Chart;
        private MetroFramework.Controls.MetroPanel panel_Admin;
        private MetroFramework.Controls.MetroTile tile_newDealer;
        private MetroFramework.Controls.MetroTile tile_newAnalysist;
        private MetroFramework.Controls.MetroTile tile_newAdmin;
        private MetroFramework.Controls.MetroComboBox comboBox_ChartRegion;
        private MetroFramework.Controls.MetroComboBox comboBox_ChartCountry;
        private MetroFramework.Controls.MetroLabel label_ChartRegion;
        private MetroFramework.Controls.MetroLabel label_ChartCountry;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PastData;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton radioButton_ChartSeason;
        private MetroFramework.Controls.MetroRadioButton radioButton_ChartMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton radioButton_ChartIncome;
        private MetroFramework.Controls.MetroRadioButton radioButton_ChartQuantity;
        private MetroFramework.Controls.MetroComboBox comboBox_ChartXAxis;
        private MetroFramework.Controls.MetroLabel label_ChartXAxis;
        private MetroFramework.Controls.MetroLabel label_ChartYAxis;
        private MetroFramework.Controls.MetroButton button_PastDataBack;
        private MetroFramework.Controls.MetroLabel label_PastSalesData;
        private MetroFramework.Controls.MetroLabel label_ChartTitle;
        private MetroFramework.Controls.MetroButton button_ChartBack;
        private MetroFramework.Controls.MetroButton button_ViewChart;
        private MetroFramework.Controls.MetroComboBox comboBox_ChartType;
        private MetroFramework.Controls.MetroLabel label_ChartType;
        private MetroFramework.Controls.MetroComboBox comboBox_RegressionType;
        private MetroFramework.Controls.MetroLabel label_RegressionType;
        private MetroFramework.Controls.MetroTile tile_ForecastedData;
        private MetroFramework.Controls.MetroPanel panel_ForecastedData;
        private MetroFramework.Controls.MetroButton button_ForecastedDataView;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton radioButton_ForecastedIncome;
        private MetroFramework.Controls.MetroRadioButton radioButton_ForecastedQuantity;
        private MetroFramework.Controls.MetroComboBox comboBox_ForecastedDateRange;
        private MetroFramework.Controls.MetroLabel label_ForecastedDateRange;
        private MetroFramework.Controls.MetroLabel label_ForecastedValue;
        private MetroFramework.Controls.MetroComboBox comboBox_ForecastedRegion;
        private MetroFramework.Controls.MetroComboBox comboBox_ForecastedCountry;
        private MetroFramework.Controls.MetroLabel label_ForecastedRegion;
        private MetroFramework.Controls.MetroLabel label_ForecastedCountry;
        private MetroFramework.Controls.MetroLabel label_ForecastedTitle;
        private MetroFramework.Controls.MetroButton button_ForecastedBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton radioButton_ForecastedSeason;
        private MetroFramework.Controls.MetroRadioButton radioButton_ForecastedMonth;
        private MetroFramework.Controls.MetroPanel panel_NewAdmin;
        private MetroFramework.Controls.MetroTextBox textBox_EmailAdmin;
        private MetroFramework.Controls.MetroTextBox textBox_UsernameAdmin;
        private MetroFramework.Controls.MetroTextBox textBox_PasswordAdmin;
        private MetroFramework.Controls.MetroTextBox textBox_RePasswordAdmin;
        private MetroFramework.Controls.MetroTextBox textBox_NameAdmin;
        private MetroFramework.Controls.MetroLabel label_PasswordAdmin;
        private MetroFramework.Controls.MetroLabel label_RePasswordAdmin;
        private MetroFramework.Controls.MetroLabel label_NameAdmin;
        private MetroFramework.Controls.MetroLabel label_EmailAdmin;
        private MetroFramework.Controls.MetroLabel label_UsernameAdmin;
        private MetroFramework.Controls.MetroButton button_BackNewAdmin;
        private MetroFramework.Controls.MetroLabel label_TitleNewAdmin;
        private MetroFramework.Controls.MetroButton button_SubmitNewAdmin;
        private MetroFramework.Controls.MetroPanel panel_NewDealer;
        private MetroFramework.Controls.MetroButton button_SubmitNewDealer;
        private MetroFramework.Controls.MetroTextBox textBox_EmailDealer;
        private MetroFramework.Controls.MetroTextBox textBox_UsernameDealer;
        private MetroFramework.Controls.MetroTextBox textBox_PasswordDealer;
        private MetroFramework.Controls.MetroTextBox textBox_RePasswordDealer;
        private MetroFramework.Controls.MetroTextBox textBox_NameDealer;
        private MetroFramework.Controls.MetroLabel label_PasswordDealer;
        private MetroFramework.Controls.MetroLabel label_RePasswordDealer;
        private MetroFramework.Controls.MetroLabel label_NameDealer;
        private MetroFramework.Controls.MetroLabel label_EmailDealer;
        private MetroFramework.Controls.MetroLabel label_UsernameDealer;
        private MetroFramework.Controls.MetroButton button_BackDealer;
        private MetroFramework.Controls.MetroLabel label_NewDealerTitle;
        private MetroFramework.Controls.MetroPanel panel_NewAnalysist;
        private MetroFramework.Controls.MetroButton button_SubmitNewAnalysist;
        private MetroFramework.Controls.MetroTextBox textBox_EmailAnalysist;
        private MetroFramework.Controls.MetroTextBox textBox_UsernameAnalysist;
        private MetroFramework.Controls.MetroTextBox textBox_PasswordAnalysist;
        private MetroFramework.Controls.MetroTextBox textBox_RePasswordAnalysist;
        private MetroFramework.Controls.MetroTextBox textBox_NameAnalysist;
        private MetroFramework.Controls.MetroLabel label_PasswordAnalysist;
        private MetroFramework.Controls.MetroLabel label_RePasswordAnalysist;
        private MetroFramework.Controls.MetroLabel label_NameAnalysist;
        private MetroFramework.Controls.MetroLabel label_EmailAnalysist;
        private MetroFramework.Controls.MetroLabel label_UsernameAnalysist;
        private MetroFramework.Controls.MetroButton button_BackAnalysist;
        private MetroFramework.Controls.MetroLabel label_NewAnalysistTitle;
        private MetroFramework.Components.MetroToolTip toolTip;
        private MetroFramework.Controls.MetroGrid grid_ForecastedData;
        private MetroFramework.Controls.MetroTextBox textBox_ForecastingNumber;
        private MetroFramework.Controls.MetroComboBox comboBox_ForecastingType;
        private MetroFramework.Controls.MetroLabel label_ForecastingNumber;
        private MetroFramework.Controls.MetroLabel label_ForecastingType;
        private MetroFramework.Controls.MetroLabel label_MPE;
        private MetroFramework.Controls.MetroLabel label_MAPE;
        private MetroFramework.Controls.MetroPanel panel_forecastedGrid;
        private MetroFramework.Controls.MetroLabel label_MAE;
        private MetroFramework.Controls.MetroLabel label_TS;
        private MetroFramework.Controls.MetroLabel label_MSE;
        private MetroFramework.Controls.MetroLabel label_CAE;
        private MetroFramework.Controls.MetroLabel label_CSE;
        private MetroFramework.Controls.MetroLabel label_MSqE;
        private MetroFramework.Controls.MetroTextBox textBox_MAPE;
        private MetroFramework.Controls.MetroTextBox textBox_MSqE;
        private MetroFramework.Controls.MetroTextBox textBox_CSE;
        private MetroFramework.Controls.MetroTextBox textBox_TS;
        private MetroFramework.Controls.MetroTextBox textBox_CAE;
        private MetroFramework.Controls.MetroTextBox textBox_MAE;
        private MetroFramework.Controls.MetroTextBox textBox_MPE;
        private MetroFramework.Controls.MetroTextBox textBox_MSE;
        private MetroFramework.Controls.MetroLabel label_LoggedName;




    }
}

