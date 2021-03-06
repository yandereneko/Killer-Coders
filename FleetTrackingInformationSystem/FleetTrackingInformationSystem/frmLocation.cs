﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    public partial class frmLocation : Form
    {
        string L_MANAGER;
        string L_ID;
        string L_NAME;
        string L_CITY;
        int L_VEHICLES;
        int L_EMPLOYEES;
        string L_PROVINCE;
        public frmLocation()
        {
            InitializeComponent();
            toolTip();

            cboCity.SelectedItem = "Durban"; // Sets the Default value showing in the Drop Down list as Durban
            cboCity.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  

            cboProvince.SelectedItem = "KwaZulu-Natal."; // Sets the Default value showing in the Drop Down list as KZN
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List

            txtLocationID.MaxLength = 8; // only allows you to insert a max length of 8
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back to Previous Form: " + ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Exit the Application: " + ex); // Shows an error message 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocationID.Clear();
                txtManager.Clear();
                updEmployees.Value = 0;
                updVehicles.Value = 0;
                txtLocName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear the Form: " + ex); // Shows an error message 
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            getValues();
            Check check = new Check();
            bool exit = false;

            exit = check.CheckEmpty(L_ID, "Location ID", exit);
            exit = check.CheckEmpty(L_MANAGER, "Manager In Charge", exit);
            exit = check.CheckEmpty(L_CITY, "City", exit);
            exit = check.CheckEmpty(L_NAME, "Location", exit);
            exit = check.CheckEmpty(L_PROVINCE, "Province", exit);
            exit = check.CheckForNumbers(L_MANAGER, "Manager In Charge");

            if (exit == false)
            {
                try
                {
                    bool executeSQL = check.CheckDB("Location", "Location_ID", L_ID);
                    if (executeSQL == false)
                    {
                        DBConnect objDBConnect = new DBConnect();

                        objDBConnect.OpenConnection();

                        objDBConnect.sqlCmd = new SqlCommand("INSERT INTO LOCATION VALUES (@Location_ID, @Location_Name, @Location_City, @Location_NumVehicles, @Location_NumEmployees, @Location_Manager)", objDBConnect.sqlConn);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Name", L_NAME);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_City", L_CITY);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumVehicles", L_VEHICLES);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumEmployees", L_EMPLOYEES);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Manager", L_MANAGER);

                        objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                        MessageBox.Show("SUCCESSFULLY INSERTED");
                        objDBConnect.sqlDR.Close();
                        objDBConnect.sqlConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("That Location ID already exists in the database");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Submit Location Details: " + ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            L_ID = Interaction.InputBox("Please enter Location ID: ", "Location ID", "Default Text");

            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM Location WHERE (Location_ID ='" + L_ID + "');";

                objDBConnect.sqlCmd = new SqlCommand();
                objDBConnect.sqlCmd.CommandText = sql;
                objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();


                MessageBox.Show("SUCCESS");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Delete Location Details: " + ex.Message);
            }

        }
        int update;
        string sql;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try// allows user to choose which fields they want to update.
            {
                L_ID = Interaction.InputBox("Please enter Location ID: ", "Location ID", "");

                update = int.Parse(Interaction.InputBox("Please enter the number associated with field you want to update:\n 1.Number of Employees\n2. Number of Vehicles\n3. Location Manager ", "Updates", "Default Text"));



                while(update!=1 && update!=2 && update!=3)
                {
                    update = int.Parse(Interaction.InputBox("Please enter  correct number associated with field you want to update:\n 1.Number of Employees\n2. Number of Vehicles\n3. Location Manager ", "Updates", "Default Text"));

                }


                if (update == 1)
                {
                    L_EMPLOYEES = int.Parse(Interaction.InputBox("Please enter Number of Employees: ", "Number of Employees", ""));

                    sql = "Location_NumEmployees= " + L_EMPLOYEES;
                }
                else
                {
                    if (update == 2)
                    {
                        L_VEHICLES = int.Parse(Interaction.InputBox("Please enter Number of Vehicles: ", "Number of vehicles", ""));

                        sql = "Location_NumVehicles = " + L_VEHICLES;
                    }
                    else
                    {
                        if (update == 3)
                        {
                            L_MANAGER = Interaction.InputBox("Please enter Location Manager: ", "Location Manager", "");

                            sql = "Location_Manager = " + L_MANAGER;
                        }
                        else
                        {
                            MessageBox.Show("Please enter corresponding numbers only");

                        }
                    }

                }



                try
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();
                    objDBConnect.sqlCmd = new SqlCommand("UPDATE LOCATION SET " + sql + " WHERE Location_ID = @Location_ID", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                    MessageBox.Show("SUCCESSFULLY UPDATED");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Update Location Details: " + ex.Message);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid option: Cannot Update.");
                
            }



        }
        
    

        public void getValues()
        {
            L_ID = txtLocationID.Text;
            try
            {
                L_NAME = this.txtLocName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("TextBox error: " + ex.Message);
            }
            try
            {
                L_CITY = this.cboCity.GetItemText(this.cboCity.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combobox error: " + ex.Message);
            }
            try
            {
                L_PROVINCE = this.cboProvince.GetItemText(this.cboProvince.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combobox error: " + ex.Message);
            }
            L_VEHICLES = int.Parse(updVehicles.Text);
            L_EMPLOYEES = int.Parse(updEmployees.Text);
            L_MANAGER = txtManager.Text;
        }

        public void toolTip()
        {
            try
            {
                // tooltip properties
                int ttAutoDelay = 5000;
                int ttInitDelay = 1000;
                int ttRshwDelay = 500;

                ToolTip objTooltipbtnAdd = new ToolTip();
                objTooltipbtnAdd.AutoPopDelay = ttAutoDelay;
                objTooltipbtnAdd.InitialDelay = ttInitDelay;
                objTooltipbtnAdd.ReshowDelay = ttRshwDelay;
                objTooltipbtnAdd.SetToolTip(this.btnAdd, "Adds entry to the database");

                ToolTip objTooltipbtnDelete = new ToolTip();
                objTooltipbtnDelete.AutoPopDelay = ttAutoDelay;
                objTooltipbtnDelete.InitialDelay = ttInitDelay;
                objTooltipbtnDelete.ReshowDelay = ttRshwDelay;
                objTooltipbtnDelete.SetToolTip(this.btnDelete, "Deletes entry from the database");

                ToolTip objTooltipbtnClear = new ToolTip();
                objTooltipbtnClear.AutoPopDelay = ttAutoDelay;
                objTooltipbtnClear.InitialDelay = ttInitDelay;
                objTooltipbtnClear.ReshowDelay = ttRshwDelay;
                objTooltipbtnClear.SetToolTip(this.btnClear, "Clears the text fields");

                ToolTip objTooltipbtnUpdate = new ToolTip();
                objTooltipbtnUpdate.AutoPopDelay = ttAutoDelay;
                objTooltipbtnUpdate.InitialDelay = ttInitDelay;
                objTooltipbtnUpdate.ReshowDelay = ttRshwDelay;
                objTooltipbtnUpdate.SetToolTip(this.btnUpdate, "Updates entry to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

