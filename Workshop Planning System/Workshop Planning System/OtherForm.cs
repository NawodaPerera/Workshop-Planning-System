using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop_Planning_System
{
    public partial class OtherForm : Form
    {
        // Linking Database to Application

        OleDbConnection ConnectionData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\ResourceDatabase.accdb""");
        
        OleDbConnection ConnectionFinalData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\WorkshopDatabase.accdb""");

        public OtherForm()
        {
            InitializeComponent();
        }

        private void RPPreviousButton_Click(object sender, EventArgs e)
        {
            // Loading to Support Staff Section

            SupportForm SupportPage = new SupportForm();
            SupportPage.Show();
            this.Hide();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // Generate the Output format. This section still developing.

            // Loading to Output Section

            OutputForm OutputForm = new OutputForm();
            OutputForm.Show();
            this.Hide();

            try
            {
                // Save Data to ResourceDatabase Database - OEDetails Table
                
                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "INSERT INTO OEDetails(OEMeals, OERefreshments, OEMaterials, OEAccommodation, OEHall, " +
                                            " OEMiscellaneous, OEInstitute, OEPostal, CreateDate) " +
                                            "values('" + OEMealsTextBox.Text + "', '" + OERefreshTextBox.Text + "', '" + OEMatTextBox.Text + "'," +
                                            " '" + OEAccomTextBox.Text + "', '" + OEHallTextBox.Text + "', '" + OEMiscelTextBox.Text + "', " +
                                            "'" + OEInsTextBox.Text + "', '" + OEPostTextBox.Text + "', '" + CDateTimePicker.Value.Date + "')";

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                // Save Data to WorkshopDatabase Database - OEDetails Table
                
                ConnectionFinalData.Open();

                OleDbCommand CommandFinalData = new OleDbCommand();
                CommandFinalData.Connection = ConnectionFinalData;
                CommandFinalData.CommandType = CommandType.Text;

                CommandFinalData.CommandText = "INSERT INTO OEDetails(OEMeals, OERefreshments, OEMaterials, OEAccommodation, OEHall, " +
                                                " OEMiscellaneous, OEInstitute, OEPostal, CreateDate) " +
                                                "values('" + OEMealsTextBox.Text + "', '" + OERefreshTextBox.Text + "', '" + OEMatTextBox.Text + "'," +
                                                " '" + OEAccomTextBox.Text + "', '" + OEHallTextBox.Text + "', '" + OEMiscelTextBox.Text + "'," +
                                                " '" + OEInsTextBox.Text + "', '" + OEPostTextBox.Text + "', '" + CDateTimePicker.Value.Date + "')";

                CommandFinalData.ExecuteNonQuery();

                ConnectionFinalData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
