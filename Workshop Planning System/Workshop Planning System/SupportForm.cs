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
using System.Xml.Linq;

namespace Workshop_Planning_System
{
    public partial class SupportForm : Form
    {
        // Linking Database to Application

        OleDbConnection ConnectionData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\ResourceDatabase.accdb""");

        OleDbConnection ConnectionFinalData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\WorkshopDatabase.accdb""");

        public SupportForm()
        {
            InitializeComponent();
        }

        private void SupportForm_Load(object sender, EventArgs e)
        {
            SPDataViewer();
        }

        void SPDataViewer()
        {
            // Created this function for the loading database data to the data grid view.

            try
            {
                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "SELECT SPID, SPName, SPDesignation, SPDepartment, SPDaypay, SPDays FROM SPDetails";

                OleDbDataReader reader = CommandData.ExecuteReader();

                SPDataGridView.Rows.Clear();

                while (reader.Read())
                {
                    int rowIndex = SPDataGridView.Rows.Add();

                    SPDataGridView.Rows[rowIndex].Cells["SPDataID"].Value = reader["SPID"].ToString();
                    SPDataGridView.Rows[rowIndex].Cells["SPDataName"].Value = reader["SPName"].ToString();
                    SPDataGridView.Rows[rowIndex].Cells["SPDataDesignation"].Value = reader["SPDesignation"].ToString();
                    SPDataGridView.Rows[rowIndex].Cells["SPDataDep"].Value = reader["SPDepartment"].ToString();
                    SPDataGridView.Rows[rowIndex].Cells["SPDataPayD"].Value = reader["SPDaypay"].ToString();
                    SPDataGridView.Rows[rowIndex].Cells["SPDataDays"].Value = reader["SPDays"].ToString();
                }

                ConnectionData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void RPNextButton_Click(object sender, EventArgs e)
        {
            // Loading to Other Details Section

            OtherForm OtherPage = new OtherForm();
            OtherPage.Show();
            this.Hide();
        }

        private void RPPreviousButton_Click(object sender, EventArgs e)
        {
            // Loading to Resource Persons Section

            ResourcesForm ResourcesPage = new ResourcesForm();
            ResourcesPage.Show();
            this.Hide();
        }

        private void SPAddButton_Click(object sender, EventArgs e)
        {
            // Using this to the saveing entered data to the database. 

            try
            {
                // Save Data to ResourceDatabase Database - SPDetails Table

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "INSERT INTO SPDetails(SPName, SPDesignation, SPDepartment, SPDaypay, SPDays) " +
                                            "values('" + SPNameTextBox.Text + "', '" + SPDesTextBox.Text + "', '" + SPDepTextBox.Text + "'," +
                                            " '" + SPDaysTextBox.Text + "', '" + SPDaysTextBox.Text + "')";

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                MessageBox.Show("New Record Saved.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        int IndexRow;

        private void SPDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Using this to the showing data grid view data to the text boxes.

            IndexRow = e.RowIndex;
            DataGridViewRow SelectedRow = SPDataGridView.Rows[IndexRow];

            SPNameTextBox.Text = SelectedRow.Cells[1].Value.ToString();
            SPDesTextBox.Text = SelectedRow.Cells[2].Value.ToString();
            SPDepTextBox.Text = SelectedRow.Cells[3].Value.ToString();
            SPPayDTextBox.Text = SelectedRow.Cells[4].Value.ToString();
            SPDaysTextBox.Text = SelectedRow.Cells[5].Value.ToString();
        }

        private void SPUpdateButton_Click(object sender, EventArgs e)
        {
            // Using this to the updateing database data.

            try
            {
                // Update Data for ResourceDatabase Database - SPDetails Table

                IndexRow = SPDataGridView.CurrentCell.RowIndex;
                int IDToUpdate = Convert.ToInt32(SPDataGridView.Rows[IndexRow].Cells["SPDataID"].Value);

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "UPDATE SPDetails SET SPName=?, SPDesignation=?, SPDepartment=?, SPDaypay=?, SPDays=? WHERE SPID=?";
                
                CommandData.Parameters.AddWithValue("@SPName", SPNameTextBox.Text);
                CommandData.Parameters.AddWithValue("@SPDesignation", SPDesTextBox.Text);
                CommandData.Parameters.AddWithValue("@SPDepartment", SPDepTextBox.Text);
                CommandData.Parameters.AddWithValue("@SPDaypay", SPPayDTextBox.Text);
                CommandData.Parameters.AddWithValue("@SPDays", SPDaysTextBox.Text);
                CommandData.Parameters.AddWithValue("@SPID", IDToUpdate);

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                MessageBox.Show("Record Updated.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SPDeleteButton_Click(object sender, EventArgs e)
        {
            // Using this to the deleteing database data.

            try
            {
                // Delete Data from ResourceDatabase Database - SPDetails Table

                IndexRow = SPDataGridView.CurrentCell.RowIndex;
                int IDToDelete = Convert.ToInt32(SPDataGridView.Rows[IndexRow].Cells["SPDataID"].Value);

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "DELETE FROM SPDetails WHERE SPID=?";

                CommandData.Parameters.AddWithValue("@SPID", IDToDelete);

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();
               
                MessageBox.Show("Record Deleted.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SPSelectButton_Click(object sender, EventArgs e)
        {
            // Using this to the saveing data to the output generate database.

            try
            {
                // Save Data to WorkshopDatabase Database - SPDetails Table

                ConnectionFinalData.Open();

                OleDbCommand CommandFinalData = new OleDbCommand();
                CommandFinalData.Connection = ConnectionFinalData;
                CommandFinalData.CommandType = CommandType.Text;

                CommandFinalData.CommandText = "INSERT INTO SPDetails(SPName, SPDesignation, SPDepartment, SPDaypay, SPDays) " +
                                            "values('" + SPNameTextBox.Text + "', '" + SPDesTextBox.Text + "', '" + SPDepTextBox.Text + "'," +
                                            " '" + SPDaysTextBox.Text + "', '" + SPDaysTextBox.Text + "')";

                CommandFinalData.ExecuteNonQuery();

                ConnectionFinalData.Close();

                MessageBox.Show("Record Selected.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
