﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace FleetTrackingInformationSystem
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            toolTip();

            cboEmpPosition.SelectedItem = "Manager"; // Sets the Default value showing in the Drop Down list as Manager
            cboEmpPosition.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
        }
        string R_DOB;
        string R_NAME;
        string R_SNAME;
        string R_UNAME;
        string R_PWORD;
        string R_EMAIL;
        string R_MEMAIL = "cargofleetdonotreply@gmail.com";
        string R_EPWORD = "Pass123456";
        string R_CURRDATE;
        string R_EMPPOS;

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Exit The Application: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin log = new frmLogin(); // Goes back to Login Form
                log.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back To Previous Form: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Clear();
                txtName.Clear(); // Clears Text Box
                txtSurname.Clear();
                txtUserName.Clear();
                txtPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Clear The Form: " + ex.Message); // Shows an error message 
            }
        }

        private string CurrDate(string date)
        {
            DateTime localDate = DateTime.Now;

            var culture = new CultureInfo("en-GB");
            date = localDate.ToString(culture);

            return date;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//this is used to show the user that a process is occuring

            R_DOB = dtpDateOfBirth.Value.ToShortDateString();
            R_NAME = txtName.Text;
            R_SNAME = txtSurname.Text;
            R_UNAME = txtUserName.Text;
            R_PWORD = txtPass.Text;
            R_EMAIL = txtEmail.Text;
            R_CURRDATE = CurrDate(R_CURRDATE);
            R_EMPPOS = cboEmpPosition.SelectedItem.ToString();
            bool email = false;

            if (!R_NAME.Equals(""))
            {
                if (!R_SNAME.Equals(""))
                {
                    if (!(cboEmpPosition.SelectedIndex < 0))
                    {
                        if (!R_EMAIL.Equals(""))
                        {
                            try
                            {
                                var addr = new System.Net.Mail.MailAddress(R_EMAIL);// validates email address
                                email = true;
                            }
                            catch
                            {

                            }
                            if (email == true)
                            {
                                if (!R_UNAME.Equals(""))
                                {
                                    if (!R_PWORD.Equals(""))
                                    {
                                        try
                                        {
                                            Check check = new Check();
                                            bool executeSQL = check.CheckDB("Register", "R_UNAME", R_UNAME);

                                            if (executeSQL == false)
                                            {
                                                DBConnect objDBConnect = new DBConnect();
                                                objDBConnect.OpenConnection();

                                                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Register VALUES (@R_UNAME,@R_DOB, @R_NAME, @R_SNAME,@R_EMPPOS,@R_EMAIL, @R_PWORD)", objDBConnect.sqlConn);
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", R_UNAME);
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DOB", SqlDbType.Date).Value = dtpDateOfBirth.Value.Date;
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_NAME", R_NAME);
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_SNAME", R_SNAME);
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_EMPPOS", R_EMPPOS);
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_EMAIL", R_EMAIL);
                                                
                                                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_PWORD", R_PWORD);

                                                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                                                objDBConnect.sqlDR.Close();
                                                objDBConnect.sqlConn.Close();
                                                string s = R_DOB + "," + R_NAME + "," + R_SNAME + "," + R_EMPPOS + "," + R_UNAME + "," + R_PWORD;
                                                MessageBox.Show("You have been successfully registered. Please be patient while an email is sent to you.");
                                                try
                                                {

                                                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                                                    client.Port = 587;
                                                    client.EnableSsl = true;
                                                    client.Timeout = 100000;
                                                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                                    client.UseDefaultCredentials = false;

                                                    client.Credentials = new NetworkCredential(
                                                      R_MEMAIL, R_EPWORD);//logs into your email account

                                                    //gets values from the textboxes
                                                    MailMessage msg = new MailMessage();
                                                    msg.To.Add(txtEmail.Text);
                                                    msg.From = new MailAddress(R_MEMAIL);//checks that email address exists
                                                    msg.Subject = "Successful Registration - Fleet Tracking Application";
                                                    msg.Body = "Hello " + R_NAME.ToUpper() + " " + R_SNAME.ToUpper() + "\n\nThis is confirmation indicating that you have successfully registered to use the Fleet Tracking Application. \n\nDate: " + R_CURRDATE + "\nUser Name: " + R_UNAME + "\n(Use this to log into the application, along with your password)\n\nKind Regards,\nFleet Tracking Team\n(0312521212)";

                                                    client.Send(msg);
                                                    MessageBox.Show("Registration Successful\nConfirmation Email Sent to: " + R_MEMAIL);
                                                    Cursor.Current = Cursors.Default;// when processing is done default curser will appear
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Email Confirmation Not Sent:\n" + ex.Message);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("That username already exists");
                                            }

                                        }
                                        catch (SqlException ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error Cannot Be Registered: " + ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter A Password");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter a Username");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email Address: " + R_EMAIL);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Your Email Address");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select The Employees Position");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Surname");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Name");
            }
        }

        public void toolTip()
        {
            try
            {
                // tooltip properties
                int ttAutoDelay = 5000;
                int ttInitDelay = 1000;
                int ttRshwDelay = 500;

                ToolTip objTooltipbtnRegister = new ToolTip();
                objTooltipbtnRegister.AutoPopDelay = ttAutoDelay;
                objTooltipbtnRegister.InitialDelay = ttInitDelay;
                objTooltipbtnRegister.ReshowDelay = ttRshwDelay;
                objTooltipbtnRegister.SetToolTip(this.btnRegister, "Registers entry to the database");

                ToolTip objTooltipbtnClear = new ToolTip();
                objTooltipbtnClear.AutoPopDelay = ttAutoDelay;
                objTooltipbtnClear.InitialDelay = ttInitDelay;
                objTooltipbtnClear.ReshowDelay = ttRshwDelay;
                objTooltipbtnClear.SetToolTip(this.btnClear, "Clears the text fields");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
