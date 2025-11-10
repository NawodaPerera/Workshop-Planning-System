using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.PortableExecutable;

namespace Workshop_Planning_System
{
    public partial class ResourcesForm : Form
    {
        // Linking Database to Application

        OleDbConnection ConnectionData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\ResourceDatabase.accdb""");
        
        OleDbConnection ConnectionFinalData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\WorkshopDatabase.accdb""");

        public ResourcesForm()
        {
            InitializeComponent();
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {
            RPDataViewer();
        }

        void RPDataViewer()
        {
            // Created this function for the loading database data to the data grid view.

            try
            {
                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "SELECT RPID, RPName, RPDesignation, RPEQ, RPAddress, RPHourpay, RPHours, RPType FROM RPDetails";
                
                OleDbDataReader reader = CommandData.ExecuteReader();

                RPDataGridView.Rows.Clear();

                while (reader.Read())
                {
                    int rowIndex = RPDataGridView.Rows.Add();

                    RPDataGridView.Rows[rowIndex].Cells["RPDataID"].Value = reader["RPID"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataName"].Value = reader["RPName"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataDesignation"].Value = reader["RPDesignation"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataEQ"].Value = reader["RPEQ"].ToString(); 
                    RPDataGridView.Rows[rowIndex].Cells["RPDataAddress"].Value = reader["RPAddress"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataPayH"].Value = reader["RPHourpay"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataHours"].Value = reader["RPHours"].ToString();
                    RPDataGridView.Rows[rowIndex].Cells["RPDataType"].Value = reader["RPType"].ToString();
                }

                ConnectionData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void RPPreviousButton_Click(object sender, EventArgs e)
        {
            // Loading to Workshop Details Section

            DetailsForm DetailsPage = new DetailsForm();
            DetailsPage.Show();
            this.Hide();
        }

        private void RPNextButton_Click(object sender, EventArgs e)
        {
            // Loading to Support Staff Section

            SupportForm SupportPage = new SupportForm();
            SupportPage.Show();
            this.Hide();
        }

        private void RPAddButton_Click(object sender, EventArgs e)
        {
            // Using this to the saveing entered data to the database. 

            try
            {
                // Save Data to ResourceDatabase Database - RPDetails Table

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "INSERT INTO RPDetails(RPName, RPDesignation, RPEQ, RPAddress, RPHourpay, RPHours, RPType) " +
                                            "values('" + RPNameTextBox.Text + "', '" + RPDesTextBox.Text + "', '" + RPEQTextBox.Text + "'," +
                                            " '" + RPAddressTextBox.Text + "', '" + RPPayHTextBox.Text + "', '" + RPHoursTextBox.Text + "'," +
                                            " '" + RPTypeComboBox.SelectedItem + "')";

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                MessageBox.Show("New Record Saved.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        int IndexRow;

        private void RPDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Using this to the showing data grid view data to the text boxes.

            IndexRow = e.RowIndex;
            DataGridViewRow SelectedRow = RPDataGridView.Rows[IndexRow];

            RPNameTextBox.Text = SelectedRow.Cells[1].Value.ToString();
            RPDesTextBox.Text = SelectedRow.Cells[2].Value.ToString();
            RPEQTextBox.Text = SelectedRow.Cells[3].Value.ToString();
            RPAddressTextBox.Text = SelectedRow.Cells[4].Value.ToString();
            RPPayHTextBox.Text = SelectedRow.Cells[5].Value.ToString();
            RPHoursTextBox.Text = SelectedRow.Cells[6].Value.ToString();
            RPTypeComboBox.Text = SelectedRow.Cells[7].Value.ToString();
        }

        private void RPUpdateButton_Click(object sender, EventArgs e)
        {
            // Using this to the updateing database data.

            try
            {
                // Update Data for ResourceDatabase Database - RPDetails Table

                IndexRow = RPDataGridView.CurrentCell.RowIndex;
                int IDToUpdate = Convert.ToInt32(RPDataGridView.Rows[IndexRow].Cells["RPDataID"].Value);

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "UPDATE RPDetails SET RPName=?, RPDesignation=?, RPEQ=?, RPAddress=?, RPHourpay=?, RPHours=?, RPType=? WHERE RPID=?";

                CommandData.Parameters.AddWithValue("@RPName", RPNameTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPDesignation", RPDesTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPEQ", RPEQTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPAddress", RPAddressTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPHourpay", RPPayHTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPHours", RPHoursTextBox.Text);
                CommandData.Parameters.AddWithValue("@RPType", RPTypeComboBox.SelectedItem);
                CommandData.Parameters.AddWithValue("@RPID", IDToUpdate);

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                MessageBox.Show("Record Updated.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RPDeleteButton_Click(object sender, EventArgs e)
        {
            // Using this to the deleteing database data.

            try
            {
                // Delete Data from ResourceDatabase Database - RPDetails Table

                IndexRow = RPDataGridView.CurrentCell.RowIndex;
                int IDToDelete = Convert.ToInt32(RPDataGridView.Rows[IndexRow].Cells["RPDataID"].Value);

                ConnectionData.Open();

                OleDbCommand CommandData = new OleDbCommand();
                CommandData.Connection = ConnectionData;
                CommandData.CommandType = CommandType.Text;

                CommandData.CommandText = "DELETE FROM RPDetails WHERE RPID=?";

                CommandData.Parameters.AddWithValue("@RPID", IDToDelete);

                CommandData.ExecuteNonQuery();

                ConnectionData.Close();

                MessageBox.Show("Record Deleted.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RPDataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RPSelectButton_Click(object sender, EventArgs e)
        {
            // Using this to the saveing data to the output generate database.

            try
            {
                // Save Data to WorkshopDatabase Database - RPDetails Table

                ConnectionFinalData.Open();

                OleDbCommand CommandFinalData = new OleDbCommand();
                CommandFinalData.Connection = ConnectionFinalData;
                CommandFinalData.CommandType = CommandType.Text;

                CommandFinalData.CommandText = "INSERT INTO RPDetails(RPName, RPDesignation, RPEQ, RPAddress, RPHourpay, RPHours, RPType) " +
                                            "values('" + RPNameTextBox.Text + "', '" + RPDesTextBox.Text + "', '" + RPEQTextBox.Text + "'," +
                                            " '" + RPAddressTextBox.Text + "', '" + RPPayHTextBox.Text + "', '" + RPHoursTextBox.Text + "'," +
                                            " '" + RPTypeComboBox.SelectedItem + "')";

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
