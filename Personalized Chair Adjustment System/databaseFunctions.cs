using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalized_Chair_Adjustment_System
{
    class databaseFunctions
    {
        static string filePath = Application.StartupPath + "/Error_File.txt";
        //SqlConnection connection = new SqlConnection(Settings.connectionText);


        /***************************************************************************************************************************************************/
        /*************************************************************Insert Functions**********************************************************************/
        /***************************************************************************************************************************************************/
       
        /// <summary>
        /// Inserts records into staff table.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Gender">The gender.</param>
        /// <param name="Phone">The phone.</param>
        /// <param name="Username">The username.</param>
        /// <param name="ID">The identifier.</param>
        public void insertIntoStaffTable(TextBox Name, ComboBox Gender, NumericUpDown Phone, TextBox Username, NumericUpDown ID)
        {
            try
            {
                string status = "A";
                string infoMessage = "Entry Successful!";
                string cmdText = "insert into StaffTable(Name, Gender, Phone_Number, Username, ID_Number,Status) values(@name, @gender, @phone, @uName, @ID, @status)";
                DataTable tale = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", Name.Text),
                    new SqlParameter("@gender", Gender.SelectedItem.ToString()),
                    new SqlParameter("@phone", Phone.Text),
                    new SqlParameter("@uName", Username.Text),
                    new SqlParameter("@ID", Settings.Hash(ID.Value)),
                    new SqlParameter("@status", status));
                MessageBox.Show(infoMessage, "PCAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Insert Into Staff Table': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine( "Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " +DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Inserts records into supervisor table.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Gender">The gender.</param>
        /// <param name="Phone">The phone.</param>
        /// <param name="Username">The username.</param>
        /// <param name="ID">The identifier.</param>
        public void insertIntoSupervisorTable(TextBox Name, ComboBox Gender, NumericUpDown Phone, TextBox Username, NumericUpDown ID)
        {
            try
            {
                string infoMessage = "Entry Successful!";
                string cmdText = "insert into SupervisorTable(supervisorName, supervisorGender, supervisorPhone_Number, supervisorUsername, supervisorID_Number) values(@name, @gender, @phone, @uName, @ID)";
                DataTable tale = ProxyDB.execQuery(cmdText,
                  new SqlParameter("@name", Name.Text),
                  new SqlParameter("@gender", Gender.SelectedItem.ToString()),
                  new SqlParameter("@phone", Phone.Text),
                  new SqlParameter("@uName", Username.Text),
                  new SqlParameter("@ID", Settings.Hash(ID.Value)));
                MessageBox.Show(infoMessage, "PCAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Insert Into Supervisor Table': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Inserts records into audit table.
        /// </summary>
        public void insertIntoAuditTable()
        {
            try
            {
                int changer = -1;
                double expectedDuration = 10;
                TimeSpan ts = Settings.eTime.Subtract(Settings.fTime);
                double actualDuration = ts.Minutes;
                if (actualDuration > expectedDuration)
                {
                    actualDuration *= changer;
                }
                string expectedTime = Settings.fTime.AddMinutes(expectedDuration).ToString("hh:mm:ss:tt");
                string Null = " ";
                string condition = "A";
                string cmdText = "insert into AuditTable(Name, Chair_ID, CapturedDate, LoginTime, TimeAtStep1, TimeAtStep2A, TimeAtStep2B, TimeAtStep2C, TimeAtStep3, ActualFinishTime,ExpectedFinishTime,ExpectedDurationInMinutes,ActualDurationInMinutes,Status_Type,Condition) values(@name,@chair_id,@cDate,@logintime,@stp1,@stp2a,@stp2b,@stp2c,@stp3,@ActualFTime,@ExpectedFTime,@eD,@aD,@stat_type,@condition)";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", Settings.name),
                     new SqlParameter("@chair_id", Settings.typeOfChair),
                     new SqlParameter("@cDate", DateTime.Now.ToShortDateString()),
                      new SqlParameter("@logintime", Settings.fTime.ToString("hh:mm:ss:tt")),
                      new SqlParameter("@stp1", Settings.step1.ToString("hh:mm:ss:tt")),
                      new SqlParameter("@stp2a", Settings.step2a.ToString("hh:mm:ss:tt")),
                      new SqlParameter("@stp2b", Settings.step2b.ToString("hh:mm:ss:tt")),
                      new SqlParameter("@stp2c", Settings.step2c.ToString("hh:mm:ss:tt")),
                      new SqlParameter("@stp3", Settings.eTime.ToString("hh:mm:ss:tt")),
                       new SqlParameter("@ActualFTime", Settings.eTime.ToString("hh:mm:ss:tt")),
                        new SqlParameter("@ExpectedFTime", expectedTime),
                        new SqlParameter("@eD", expectedDuration.ToString()),
                        new SqlParameter("@aD", actualDuration.ToString()),
                         new SqlParameter("@stat_type", Null),
                          new SqlParameter("@condition", condition));
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Insert into Audit Table': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/



        /***************************************************************************************************************************************************/
        /*************************************************************Authenticate Functions****************************************************************/
        /***************************************************************************************************************************************************/

        /// <summary>
        /// Authenticates the login details for a regular.
        /// </summary>
        /// <param name="txtU">The text u.</param>
        /// <param name="nud">The nud.</param>
        /// <returns></returns>
        public bool authenticateLoginDetailsRegular(TextBox txtU, NumericUpDown nud)
        {
            try
            {
                string cmdText = "select Username, ID_Number from StaffTable where Username = @username and ID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", txtU.Text),
                    new SqlParameter("@id", Settings.Hash(nud.Value)));
                if (table.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Authenticate Login Details for Regular': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// Authenticates the login details for a supervisor.
        /// </summary>
        /// <param name="txtU">The text u.</param>
        /// <param name="nud">The nud.</param>
        /// <returns></returns>
        public bool authenticateLoginDetailsSupervisor(TextBox txtU, NumericUpDown nud)
        {
            try
            {
                string cmdText = "select supervisorUsername, supervisorID_Number from SupervisorTable where supervisorUsername = @username and supervisorID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", txtU.Text),
                    new SqlParameter("@id", Settings.Hash(nud.Value)));
                if (table.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Authenticate Login Details for Supervisor': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public Boolean authenticateUsername(TextBox uName)
        {
            try
            {
                if (Settings.isSupervisor == false)
                {
                    string cmdText = "select Username from StaffTable where Username = @username";
                    DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@username", uName.Text));
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }
                }
                else if(Settings.isSupervisor == true)
                {
                    string cmdText = "select supervisorUsername from SupervisorTable where supervisorUsername = @username";
                    DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@username", uName.Text));
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Authenticate Username': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public Boolean authenticateID(NumericUpDown pWord)
        {
            try
            {
                if (Settings.isSupervisor == false)
                {
                    string cmdText = "select ID_Number from StaffTable where ID_Number = @id";
                    DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@id", Settings.Hash(pWord.Value)));
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }
                }
                else if(Settings.isSupervisor == true)
                {
                    string cmdText = "select supervisorID_Number from SupervisorTable where supervisorID_Number = @id";
                    DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@id", Settings.Hash(pWord.Value)));
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Authenticate ID': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/


        /***************************************************************************************************************************************************/
        /*************************************************************Get Functions****************************************************************/
        /***************************************************************************************************************************************************/
        /// <summary>
        /// Gets the name of user.
        /// </summary>
        /// <param name="lb">The lb.</param>
        public void getNameOfUser(Label lb)
        {
            try
            {
                string cmdText = "select Name from StaffTable where Username = @username and ID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", Settings.Username),
                    new SqlParameter("@id", Settings.Hash(Settings.ID_Number)));
                Settings.name = table.Rows[0]["Name"].ToString();
                lb.Text = "Welcome " + table.Rows[0]["Name"].ToString();
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get name of User': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getName(Label lb)
        {
            try
            {
                string cmdText = "select Name from StaffTable where Username = @username and ID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", Settings.Username),
                    new SqlParameter("@id", Settings.Hash(Settings.ID_Number)));
                lb.Text = "Name: " + table.Rows[0]["Name"].ToString();
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get name of User': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getNameForGoodBye(Label lb)
        {
            try
            {
                string cmdText = "select Name from StaffTable where Username = @username and ID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", Settings.Username),
                    new SqlParameter("@id", Settings.Hash(Settings.ID_Number)));
                lb.Text = "Dear " + table.Rows[0]["Name"].ToString() + ",";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get name of User for Goodbye message': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the name of supervisor.
        /// </summary>
        /// <param name="lb">The lb.</param>
        public void getNameOfSupervisor(Label lb)
        {
            try
            {
                string cmdText = "select supervisorName from SupervisorTable where supervisorUsername = @username and supervisorID_Number = @id";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@username", Settings.Username),
                    new SqlParameter("@id", Settings.Hash(Settings.ID_Number)));
                lb.Text = "Welcome " + table.Rows[0]["supervisorName"].ToString();
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get name of Supervisor': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the type of chair.
        /// </summary>
        /// <param name="lb">The lb.</param>
        public void getChairType(Label lb)
        {
            try
            {
                string cmdText = "select Chair_Type from TypeOfChairTable where Chair_ID = @id";
                DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@id", Settings.typeOfChair));
                lb.Text = "Chair Type: " + table.Rows[0]["Chair_Type"].ToString();
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get chair type': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Gets all records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        /// <param name="txt">The text.</param>
        public void getAllRecords(DataGridView dgv, Label lb, string fDate, string eDate, TextBox txt)
        {
            try
            {
                string cmdText = "select * from Audit_View where CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " record(s)!";
                txt.Text = fDate + "-----" + eDate;
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get all records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + " Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the active records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        public void getActiveRecords(DataGridView dgv, Label lb, string fDate, string eDate)
        {
            try
            {
                string condition = "A";
                string cmdText = "select * from Audit_View where Condition = @condition and CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@condition", condition),
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " active record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get active records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the disabled records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        public void getDisabledRecords(DataGridView dgv, Label lb, string fDate, string eDate)
        {
            try
            {
                string condition = "X";
                string cmdText = "select * from Audit_View where Condition = @condition and CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@condition", condition),
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " disabled record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get disabled records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the query records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        public void getQueryRecords(DataGridView dgv, Label lb, string fDate, string eDate)
        {
            try
            {
                string status = "Query";
                string cmdText = "select * from Audit_View where Status_Type = @status and CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@status", status),
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " query record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get Query records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the complied records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        public void getCompliedRecords(DataGridView dgv, Label lb, string fDate, string eDate)
        {
            try
            {
                string condition = "Complied";
                string cmdText = "select * from Audit_View where Status_Type = @condition and CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@condition", condition),
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " complied record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get Complied records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the slow records.
        /// </summary>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        /// <param name="fDate">The f date.</param>
        /// <param name="eDate">The e date.</param>
        public void getSlowRecords(DataGridView dgv, Label lb, string fDate, string eDate)
        {
            try
            {
                string condition = "Slow";
                string cmdText = "select * from Audit_View where Status_Type = @condition and CapturedDate between @fDate and @eDate order by StaffID asc";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@condition", condition),
                    new SqlParameter("@fDate", fDate),
                    new SqlParameter("@eDate", eDate));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " slow record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Get slow records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/


        /***************************************************************************************************************************************************/
        /*************************************************************Search Functions**********************************************************************/
        /***************************************************************************************************************************************************/
        /// <summary>
        /// Searches for records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string cmdText = "select * from Audit_View where Name = @name";
                DataTable table = ProxyDB.execQuery(cmdText, new SqlParameter("@name", txt.Text));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + "record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Searches for active records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchActiveRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string condition = "A";
                string cmdText = "select * from Audit_View where Name = @name and Condition = @condition";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", txt.Text),
                    new SqlParameter("@condition", condition));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " active record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search active records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches for disabled records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchDisabledRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string condition = "X";
                string cmdText = "select * from Audit_View where Name = @name and Condition = @condition";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", txt.Text),
                    new SqlParameter("@condition", condition));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " disabled record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search disabled records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches for query records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchQueryRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string status = "Query";
                string cmdText = "select * from Audit_View where Name = @name and Status_Type = @status";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", txt.Text),
                    new SqlParameter("@status", status));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " query record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search query records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches for complied records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchCompliedRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string status = "Complied";
                string cmdText = "select * from Audit_View where Name = @name and Status_Type = @status";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", txt.Text),
                    new SqlParameter("@status", status));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " complied record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search complied records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches for slow records.
        /// </summary>
        /// <param name="txt">The text.</param>
        /// <param name="dgv">The DGV.</param>
        /// <param name="lb">The lb.</param>
        public void searchSlowRecords(TextBox txt, DataGridView dgv, Label lb)
        {
            try
            {
                string status = "Slow";
                string cmdText = "select * from Audit_View where Name = @name and Status_Type = @status";
                DataTable table = ProxyDB.execQuery(cmdText,
                    new SqlParameter("@name", txt.Text),
                    new SqlParameter("@status", status));
                dgv.DataSource = table;
                lb.Text = dgv.RowCount.ToString() + " slow record(s)!";
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Search slow records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/


        /***************************************************************************************************************************************************/
        /*************************************************************Update Functions**********************************************************************/
        /***************************************************************************************************************************************************/
      
        /// <summary>
        /// Updates record status.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void updateStatus(string id)
        {
            try
            {
                if (Settings.isQuery == true && Settings.isComplied == false && Settings.isSlow == false && Settings.isClear == false)
                {
                    string errorMessage = "Record already has a Status Type: Query!";
                    string status = "Query";
                    string cmdString = "select Status_Type from AuditTable where StaffID = @id";
                    DataTable _table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                    if (_table.Rows.Count > 0)
                    {
                        string stat = _table.Rows[0]["Status_Type"].ToString();
                        if (stat != status)
                        {
                            string cmdText = "update AuditTable set Status_Type = @status where StaffID = @id";
                            DataTable table = ProxyDB.execQuery(cmdText,
                                new SqlParameter("@id", id),
                                new SqlParameter("@status", status));
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }
                if (Settings.isQuery == false && Settings.isComplied == true && Settings.isSlow == false && Settings.isClear == false)
                {
                    string errorMessage = "Record already has a Status Type: Complied!";
                    string status = "Complied";
                    string cmdString = "select Status_Type from AuditTable where StaffID = @id";
                    DataTable _table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                    if (_table.Rows.Count > 0)
                    {
                        string stat = _table.Rows[0]["Status_Type"].ToString();
                        if (stat != status)
                        {
                            string cmdText = "update AuditTable set Status_Type = @status where StaffID = @id";
                            DataTable table = ProxyDB.execQuery(cmdText,
                                new SqlParameter("@id", id),
                                new SqlParameter("@status", status));
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }
                if (Settings.isQuery == false && Settings.isComplied == false && Settings.isSlow == true && Settings.isClear == false)
                {
                    string errorMessage = "Record already has a Status Type: Slow!";
                    string status = "Slow";
                    string cmdString = "select Status_Type from AuditTable where StaffID = @id";
                    DataTable _table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                    if (_table.Rows.Count > 0)
                    {
                        string stat = _table.Rows[0]["Status_Type"].ToString();
                        if (stat != status)
                        {
                            string cmdText = "update AuditTable set Status_Type = @status where StaffID = @id";
                            DataTable table = ProxyDB.execQuery(cmdText,
                                new SqlParameter("@id", id),
                                new SqlParameter("@status", status));
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }
                if (Settings.isQuery == false && Settings.isComplied == false && Settings.isSlow == false && Settings.isClear == true)
                {
                    string errorMessage = "Record does not have a Status Type";
                    string status = " ";
                    string cmdString = "select Status_Type from AuditTable where StaffID = @id";
                    DataTable _table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                    if (_table.Rows.Count > 0)
                    {
                        string stat = _table.Rows[0]["Status_Type"].ToString();
                        if (stat != status)
                        {
                            string cmdText = "update AuditTable set Status_Type = @status where StaffID = @id";
                            DataTable table = ProxyDB.execQuery(cmdText,
                                new SqlParameter("@id", id),
                                new SqlParameter("@status", status));
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Update status of records': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enables a record.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void enableRecord(string id)
        {
            try
            {
                string errorMessage = "Record is already Enabled!";
                string infoMessage = "Enabling complete!";
                string condition = "A";
                string cmdString = "select Condition from AuditTable where StaffID = @id";
                DataTable table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                if (table.Rows.Count > 0)
                {
                    string stat = table.Rows[0]["Condition"].ToString();
                    if (!stat.Contains(condition))
                    {
                        string cmdText = "update AuditTable set Condition = @condition where StaffID = @id";
                        DataTable _table = ProxyDB.execQuery(cmdText,
                            new SqlParameter("@condition", condition),
                            new SqlParameter("@id", id));
                        MessageBox.Show(infoMessage, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Enable record': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disables a record.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void disableRecord(string id)
        {
            try
            {
                string errorMessage = "Record is already Disabled!";
                string infoMessage = "Disabling complete!";
                string condition = "X";
                string cmdString = "select Condition from AuditTable where StaffID = @id";
                DataTable table = ProxyDB.execQuery(cmdString, new SqlParameter("@id", id));
                if (table.Rows.Count > 0)
                {
                    string stat = table.Rows[0]["Condition"].ToString();
                    if (!stat.Contains(condition))
                    {
                        string cmdText = "update AuditTable set Condition = @condition where StaffID = @id";
                        DataTable _table = ProxyDB.execQuery(cmdText,
                            new SqlParameter("@condition", condition),
                            new SqlParameter("@id", id));
                        MessageBox.Show(infoMessage, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Oops! Something went wrong!\n Contact System Developer";
                string errorContent = "";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        errorContent = reader.ReadToEnd();
                    }
                    catch (Exception exception) { }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    try
                    {
                        writer.WriteLine(errorContent);
                        writer.WriteLine(" ");
                        writer.WriteLine("Error Details for database function 'Disable record': ");
                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.Source);
                        writer.WriteLine("Occured at " + "\n" + "Time: " + DateTime.Now.ToString("hh:mm:ss:tt") + "\n" + "Date: " + DateTime.Now.ToShortDateString());
                    }
                    catch (Exception exception) { }
                }
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/
        /***************************************************************************************************************************************************/

       
        /// <summary>
        /// Times the specified label.
        /// </summary>
        /// <param name="lb">The lb.</param>
        public void Time(Label lb)
        {
            lb.Text = "Time: " + DateTime.Now.ToString("hh:mm:ss:tt");
        }

    }
}
