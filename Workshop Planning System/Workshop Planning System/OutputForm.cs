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

namespace Workshop_Planning_System
{
    public partial class OutputForm : Form
    {
        // Linking Database to Application

        OleDbConnection ConnectionData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\ResourceDatabase.accdb""");

        OleDbConnection ConnectionFinalData = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\My Documents\UOM-BIT\Level  01 - Semester 02\ICT Project - ITE 1942\ICT Project\Database\WorkshopDatabase.accdb""");

        public OutputForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save Output Page

            SaveFileDialog OutSave = OutputSaveFileDialog;
            OutSave.ShowDialog();
        }

        Bitmap bitmap;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print Output Page

            bitmap = new Bitmap(OutputFlowLayoutPanel.Width, OutputFlowLayoutPanel.Height);
            OutputFlowLayoutPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, OutputFlowLayoutPanel.Width, OutputFlowLayoutPanel.Height));

            OutputPrintPreviewDialog.PrintPreviewControl.Zoom = 1;
            OutputPrintPreviewDialog.ShowDialog();
        }
        private void OutputPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
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
