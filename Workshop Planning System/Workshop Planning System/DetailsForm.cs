using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Workshop_Planning_System
{
    public partial class DetailsForm : Form
    {
        // Linking Database to Application

        OleDbConnection ConnectionData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\ResourceDatabase.accdb""");
        
        OleDbConnection ConnectionFinalData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\WorkshopDatabase.accdb""");

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            // Loading to Resource Persons Section

            try
            {
                // Save Data to ResourceDatabase Database - WSDetails Table

                ConnectionData.Open();
                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "INSERT INTO WSDetails(WSDepartment, WSProjectName, WSProjectCode, WSAAPCode, WSActivityList, " +
                                            " WSSubjectLeader, WSSubject, WSGrade, WSStartDate, WSFinishDate, WSVenue, WSOutcome) " +
                                            "values('" + DeptTextBox.Text + "', '" + ProjectTextBox.Text + "', '" + PCTextBox.Text + "'," +
                                            " '" + AAPCTextBox.Text + "', '" + ActivityTextBox.Text + "', '" + LeaderTextBox.Text + "'," +
                                            " '" + SubTextBox.Text + "', '" + GradeTextBox.Text + "', '" + SDateTimePicker.Value.Date + "'," +
                                            " '" + FDateTimePicker.Value.Date + "', '" + VenueTextBox.Text + "', '" + OutputTextBox.Text + "')";

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                // Save Data to WorkshopDatabase Database - WSDetails Table

                ConnectionFinalData.Open();

                OleDbCommand CommandFinalData = new OleDbCommand();
                CommandFinalData.Connection = ConnectionFinalData;
                CommandFinalData.CommandType = CommandType.Text;

                CommandFinalData.CommandText = "INSERT INTO WSDetails(WSDepartment, WSProjectName, WSProjectCode, WSAAPCode, WSActivityList, " +
                                                " WSSubjectLeader, WSSubject, WSGrade, WSStartDate, WSFinishDate, WSVenue, WSOutcome) " +
                                            "values('" + DeptTextBox.Text + "', '" + ProjectTextBox.Text + "', '" + PCTextBox.Text + "'," +
                                            " '" + AAPCTextBox.Text + "', '" + ActivityTextBox.Text + "', '" + LeaderTextBox.Text + "'," +
                                            " '" + SubTextBox.Text + "', '" + GradeTextBox.Text + "', '" + SDateTimePicker.Value.Date + "'," +
                                            " '" + FDateTimePicker.Value.Date + "', '" + VenueTextBox.Text + "', '" + OutputTextBox.Text + "')";

                CommandFinalData.ExecuteNonQuery();

                ConnectionFinalData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            ResourcesForm ResourcesPage = new ResourcesForm();
            ResourcesPage.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Quit from Application

            DialogResult Exit;
            Exit = MessageBox.Show("Confirm to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Exit == DialogResult.Yes)
            {
                ConnectionFinalData.Open();

                // Delete data from database. Because "WorkshopDatabase" using to the generate output.

                // Delete from WorkshopDatabase Database - WSDetails Table
                OleDbCommand commandWSDetails = new OleDbCommand("DELETE FROM WSDetails", ConnectionFinalData);
                commandWSDetails.ExecuteNonQuery();

                // Delete from WorkshopDatabase - RPDetails Table
                OleDbCommand commandRPDetails = new OleDbCommand("DELETE FROM RPDetails", ConnectionFinalData);
                commandRPDetails.ExecuteNonQuery();

                // Delete from WorkshopDatabase - SPDetails Table
                OleDbCommand commandSPDetails = new OleDbCommand("DELETE FROM SPDetails", ConnectionFinalData);
                commandSPDetails.ExecuteNonQuery();

                // Delete from WorkshopDatabase - OEDetails Table
                OleDbCommand commandOEDetails = new OleDbCommand("DELETE FROM OEDetails", ConnectionFinalData);
                commandOEDetails.ExecuteNonQuery();

                ConnectionFinalData.Close();

                Application.Exit();
            }
        }
    }
}
