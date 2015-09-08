using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using SalesAnalyser;
using System.Drawing;

namespace Modern_UI
{
    class DataArranger
    {
        private DataRetriever dr = new DataRetriever();
        private ForecastingMethods fm = new ForecastingMethods();
        public static string ENCRYPT_KEY = "Sales_Analyser@120434D";
        private Encrypter encrypter = new Encrypter();

        public List<Region> getAllRegions()
        {
            List<Region> regionList = new List<Region>();
            DataSet ds = dr.getAllCountries();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Region region = new Region();
                region.region_name = row["region"].ToString();
                region.region_id = Convert.ToInt32(row["region_id"].ToString());
                regionList.Add(region);
            }
            return regionList;
        }

        public List<Country> getAllCountries()
        {
            List<Country> countryList = new List<Country>();
            DataSet ds = dr.getAllCountries();
            if (ds != null) 
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Country country = new Country();
                    country.country_name = row["country"].ToString();
                    country.country_id = Convert.ToInt32(row["country_id"].ToString());
                    countryList.Add(country);
                }
                return countryList;
            }
            return null;
        }

        public DataSet getRegionData(int region_id)
        {
            DataSet ds = dr.getRegionData(region_id);
            return ds;
        }

        public List<Region> getRegionsOfCountry(int country_id)
        {
            List<Region> regionList = new List<Region>();
            DataSet ds = dr.getRegionsOfCountry(country_id);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Region region = new Region();
                region.region_name = row["region"].ToString();
                region.region_id = Convert.ToInt32(row["region_id"].ToString());
                regionList.Add(region);
            }
            return regionList;
        }

        public List<SalesData> getGraphData(int region_id, int chart_sales_data_type, int month_min, int month_max)
        {
            if (month_max > 12)
            {
                DataSet ds = dr.getGraphDataOnMonth(region_id, month_min);
                int count = ds.Tables[0].Rows.Count;

                List<SalesData> data_list = new List<SalesData>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    double quantity = Convert.ToDouble(row["quantity"].ToString());
                    DateTime date = DateTime.Parse(row["date_of_sale"].ToString());//DateTime.ParseExact(row["date_of_sale"].ToString(), "yyyy-M-d HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
                    double income = Convert.ToDouble(row["total_income"].ToString());
                    SalesData temp_sale = new SalesData(quantity, income, date);
                    data_list.Add(temp_sale);

                }
                return data_list;
            }
            else if (month_max == 0)
            {
                DataSet ds = dr.getGraphDataAllData(region_id);
                int count = ds.Tables[0].Rows.Count;

                List<SalesData> data_list = new List<SalesData>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    double quantity = Convert.ToDouble(row["quantity"].ToString());
                    DateTime date = DateTime.Parse(row["date_of_sale"].ToString());//DateTime.ParseExact(row["date_of_sale"].ToString(), "yyyy-M-d HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
                    double income = Convert.ToDouble(row["total_income"].ToString());
                    SalesData temp_sale = new SalesData(quantity, income, date);
                    data_list.Add(temp_sale);

                }
                return data_list;
            }
            else 
            {
                DataSet ds = dr.getGraphDataOnRange(region_id, month_min, month_max);
                int count = ds.Tables[0].Rows.Count;

                List<SalesData> data_list = new List<SalesData>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    double quantity = Convert.ToDouble(row["quantity"].ToString());
                    DateTime date = DateTime.Parse(row["date_of_sale"].ToString());//DateTime.ParseExact(row["date_of_sale"].ToString(), "yyyy-M-d HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
                    double income = Convert.ToDouble(row["total_income"].ToString());
                    SalesData temp_sale = new SalesData(quantity, income, date);
                    data_list.Add(temp_sale);

                }
                return data_list;
            }
        }

        internal int checkNewAccountdetails(int type, string name, string email, string username, string password1, string password2, Main_Form main_Form, string filePath, string filename)
        {
            if (type == 1)
            {
                if ((name != "") || (email != "") || (username != "") || (password1 != "") || (password2 != ""))
                {
                    DataSet ds = dr.getAdminOnUsername(username);
                    int count = ds.Tables[0].Rows.Count;
                    if (count > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(main_Form, "Username is already in use", "Username should be Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (password1.Equals(password2))
                        {
                            string password = encrypter.Encrypt(password1, ENCRYPT_KEY);
                            dr.createNewAdmin(name, email, username, password);
                            MetroFramework.MetroMessageBox.Show(main_Form, "New administrator account was successfully created", "New account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(main_Form, "Passwords are not similar", "Passwords do not Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(main_Form, "There are incomplete text fields", "Form is Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (type == 2)
            {
                if ((name != "") || (email != "") || (username != "") || (password1 != "") || (password2 != ""))
                {
                    DataSet ds = dr.getAnalystOnUsername(username);
                    int count = ds.Tables[0].Rows.Count;
                    if (count > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(main_Form, "Username is already in use", "Username should be Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (password1.Equals(password2))
                        {
                            string password = encrypter.Encrypt(password1, ENCRYPT_KEY);
                            dr.createNewAnalysist(name, email, username, password);
                            MetroFramework.MetroMessageBox.Show(main_Form, "New anlysist account was successfully created", "New account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(main_Form, "Passwords are not similar", "Passwords do not Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(main_Form, "There are incomplete text fields", "Form is Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (type == 3)
            {
                if ((name != "") || (email != "") || (username != "") || (password1 != "") || (password2 != ""))
                {
                    DataSet ds = dr.getDealerOnUsername(username);
                    int count = ds.Tables[0].Rows.Count;
                    if (count > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(main_Form, "Username is already in use", "Username should be Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (password1.Equals(password2))
                        {
                            if (filename.Equals(""))
                            {
                                MetroFramework.MetroMessageBox.Show(main_Form, "Image has not chosen", "Please choose an image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else 
                            {
                                string password = encrypter.Encrypt(password1, ENCRYPT_KEY);
                                bool result = dr.uploadDealerImage(filePath);
                                if (result)
                                {
                                    string ImagePathInWeb = "http://dinindu.pe.hu/Images/" + filename;
                                    dr.createNewDealer(name, email, username, password, ImagePathInWeb);
                                    MetroFramework.MetroMessageBox.Show(main_Form, "New dealer account was successfully created", "New account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return 0;
                                }
                                else 
                                {
                                    MetroFramework.MetroMessageBox.Show(main_Form, "An Error Occured", "An error occurred while saving the image file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(main_Form, "Passwords are not similar", "Passwords do not match with each other", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(main_Form, "There are incomplete text fields", "Form is Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                if ((name != "") || (email != "") || (username != "") || (password1 != "") || (password2 != ""))
                {
                    DataSet ds = dr.getReviewerOnUsername(username);
                    int count = ds.Tables[0].Rows.Count;
                    if (count > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(main_Form, "Username is already in use", "Username should be Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (password1.Equals(password2))
                        {
                            string password = encrypter.Encrypt(password1, ENCRYPT_KEY);
                            dr.createNewReviewer(name, email, username, password);
                            MetroFramework.MetroMessageBox.Show(main_Form, "New reviewer account was successfully created", "New account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(main_Form, "Passwords are not similar", "Passwords do not match with each other", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(main_Form, "There are incomplete text fields", "Form is Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 1;
        }

        internal ForecastTable getForecastTable(int region_id, int forecasted_yData_type, int month_min, int month_max, int forecasting_Type,string number, Main_Form main_Form)
        {
            int tempnumber;

            bool result = Int32.TryParse(number, out tempnumber);
            if (!result)
            {
                MetroFramework.MetroMessageBox.Show(main_Form, "Forecasting number should be an integer value" + "\n" + "Please insert a correct value", "Forecasting number is not an integer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                if (month_max > 12)
                {
                    DataSet ds = dr.getGraphDataOnMonth(region_id, month_min);
                    int count = ds.Tables[0].Rows.Count;
                    Console.WriteLine(count);

                    decimal[] array = new decimal[count];

                    if (forecasted_yData_type == 1)
                    {
                        int index = 0;
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            array[index] = Convert.ToDecimal(row["quantity"].ToString());
                            index++;
                        }

                        int forecasting_number = Convert.ToInt32(number);
                        ForecastTable ft = this.getForecastedTable(array, forecasting_number, forecasting_Type);//fm.naive(array, 10, 0);
                        return ft;
                    }
                    else
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            decimal income = Convert.ToDecimal(row["total_income"].ToString());
                        }

                        ForecastTable ft = fm.naive(array, 10, 0);
                        return ft;
                    }

                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        private ForecastTable getForecastedTable(decimal[] array, int forecasting_number, int forecasting_Type)
        {
            Console.WriteLine(forecasting_Type + "----" + forecasting_number);
            if (forecasting_Type == 0) 
            {
                ForecastTable ft = fm.naive(array, forecasting_number, 0);
                return ft;
            }
            else if (forecasting_Type == 1) 
            {
                ForecastTable ft = fm.simpleMovingAverage(array, forecasting_number, 3, 0);
                return ft;
            }
            else if (forecasting_Type == 2) 
            {
                ForecastTable ft = fm.weightedMovingAverage(array, forecasting_number, (Decimal)0.05, (Decimal)0.15, (Decimal)0.8);
                return ft;
            }
            else if (forecasting_Type == 3) 
            {
                ForecastTable ft = fm.adaptiveRateSmoothing(array, forecasting_number, (Decimal)0.2, (Decimal)0.8);
                return ft;
            }
            else 
            {
                ForecastTable ft = fm.exponentialSmoothing(array, forecasting_number, (Decimal)0.8);
                return ft;
            }
        }

        public string checkLoginAuthentication(int type, string username, string password, Login_Form login) 
        {
            if ((username.Equals("")) || (password.Equals(""))) 
            {
                MetroFramework.MetroMessageBox.Show(login, "Login attempt failed" + "\n" + "Required fields are missing", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else 
            {
                string encryptedPassword = encrypter.Encrypt(password,ENCRYPT_KEY);
                encryptedPassword = encryptedPassword.Trim();
                if (type == 1)
                {
                    DataSet ds = dr.getAdmin(username, encryptedPassword);
                    if (ds != null) 
                    {
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(login, "Username or Password is incorrect", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                        else
                        {
                            return ds.Tables[0].Rows[0]["name"].ToString();
                        }
                    }
                    return null;
                    
                }
                else if (type == 2)
                {
                    DataSet ds = dr.getAnalyser(username, encryptedPassword);
                    if (ds != null) 
                    {
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(login, "Username or Password is incorrect", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                        else
                        {
                            return ds.Tables[0].Rows[0]["name"].ToString();
                        }
                    }
                    return null;
                    
                }
                else
                {
                    DataSet ds = dr.getReviewer(username, encryptedPassword);
                    if (ds != null) 
                    {
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(login, "Username or Password is incorrect", "Login was unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                        else
                        {
                            return ds.Tables[0].Rows[0]["name"].ToString();
                        }
                    }
                    return null;
                }
            }
            
        }

        internal bool changePassword(int type, string username, string old_password, string new_password_1, string new_password_2, ChangePasswordWindow password_change_window)
        {
            if ((username.Equals("")) || (new_password_1.Equals("")) || (old_password.Equals("")) || (new_password_2.Equals("")))
            {
                MetroFramework.MetroMessageBox.Show(password_change_window, "Incomplete form", "There are incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else 
            {
                string encryptedOldPassword = encrypter.Encrypt(old_password, ENCRYPT_KEY);
                encryptedOldPassword = encryptedOldPassword.Trim();

                string encryptedNewPassword1 = encrypter.Encrypt(new_password_1, ENCRYPT_KEY);

                if (new_password_1.Equals(new_password_2)) 
                {
                    if (type == 1)
                    {
                        DataSet ds = dr.getAdmin(username, encryptedOldPassword);
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Username or Password is incorrect", "Given Username or Password is incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr.changeAdminPassword(username,encryptedNewPassword1);
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Password was successfully changed", "Your account password was successfully chnaged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    else if (type == 2) 
                    {
                        DataSet ds = dr.getAnalyser(username, encryptedOldPassword);
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Username or Password is incorrect", "Given Username or Password is incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr.changeAnalysistPassword(username, encryptedNewPassword1);
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Password was successfully changed", "Your account password was successfully chnaged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    else 
                    {
                        DataSet ds = dr.getReviewer(username, encryptedOldPassword);
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 0)
                        {
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Username or Password is incorrect", "Given Username or Password is incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr.changeReviewerPassword(username, encryptedNewPassword1);
                            MetroFramework.MetroMessageBox.Show(password_change_window, "Password was successfully changed", "Your account password was successfully chnaged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
                else 
                {
                    MetroFramework.MetroMessageBox.Show(password_change_window, "Passwords do not match", "Two passwords do not match with each other", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                
            }
            return false;
        }

        internal DataSet getReviews()
        {
            DataSet ds = dr.getReviews();
            return ds;
        }
    }
}
