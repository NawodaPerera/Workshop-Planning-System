using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Planning_System
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Loading to Workshop Details Section

            DetailsForm DetailsPage = new DetailsForm();
            DetailsPage.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Quit from Application

            DialogResult Exit;
            Exit = MessageBox.Show("Confirm to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
