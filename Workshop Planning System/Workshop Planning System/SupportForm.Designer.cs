namespace Workshop_Planning_System
{
    partial class SupportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            SPDaysTextBox = new TextBox();
            SPDeleteButton = new Button();
            SPUpdateButton = new Button();
            SPAddButton = new Button();
            SPPayDTextBox = new TextBox();
            SPHoursLabel = new Label();
            SPPayHLabel = new Label();
            SPDepTextBox = new TextBox();
            SPEQLabel = new Label();
            SPDesTextBox = new TextBox();
            SPDesLabel = new Label();
            SPNameTextBox = new TextBox();
            SPNameLabel = new Label();
            SPDataGridView = new DataGridView();
            SPDataID = new DataGridViewTextBoxColumn();
            SPDataName = new DataGridViewTextBoxColumn();
            SPDataDesignation = new DataGridViewTextBoxColumn();
            SPDataDep = new DataGridViewTextBoxColumn();
            SPDataPayD = new DataGridViewTextBoxColumn();
            SPDataDays = new DataGridViewTextBoxColumn();
            SPPreviousButton = new Button();
            SPNextButton = new Button();
            RPDLabel = new Label();
            CloseButton = new Button();
            SPSelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SPDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SPDaysTextBox
            // 
            SPDaysTextBox.Anchor = AnchorStyles.None;
            SPDaysTextBox.BackColor = Color.White;
            SPDaysTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPDaysTextBox.ForeColor = Color.Black;
            SPDaysTextBox.Location = new Point(1132, 255);
            SPDaysTextBox.Margin = new Padding(3, 2, 3, 2);
            SPDaysTextBox.Multiline = true;
            SPDaysTextBox.Name = "SPDaysTextBox";
            SPDaysTextBox.RightToLeft = RightToLeft.No;
            SPDaysTextBox.Size = new Size(240, 50);
            SPDaysTextBox.TabIndex = 59;
            // 
            // SPDeleteButton
            // 
            SPDeleteButton.BackColor = Color.White;
            SPDeleteButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPDeleteButton.ForeColor = Color.Black;
            SPDeleteButton.Location = new Point(602, 328);
            SPDeleteButton.Margin = new Padding(3, 2, 3, 2);
            SPDeleteButton.Name = "SPDeleteButton";
            SPDeleteButton.Size = new Size(150, 50);
            SPDeleteButton.TabIndex = 62;
            SPDeleteButton.Text = "DELETE";
            SPDeleteButton.UseVisualStyleBackColor = false;
            SPDeleteButton.Click += SPDeleteButton_Click;
            // 
            // SPUpdateButton
            // 
            SPUpdateButton.BackColor = Color.White;
            SPUpdateButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPUpdateButton.ForeColor = Color.Black;
            SPUpdateButton.Location = new Point(446, 328);
            SPUpdateButton.Margin = new Padding(3, 2, 3, 2);
            SPUpdateButton.Name = "SPUpdateButton";
            SPUpdateButton.Size = new Size(150, 50);
            SPUpdateButton.TabIndex = 61;
            SPUpdateButton.Text = "UPDATE";
            SPUpdateButton.UseVisualStyleBackColor = false;
            SPUpdateButton.Click += SPUpdateButton_Click;
            // 
            // SPAddButton
            // 
            SPAddButton.BackColor = Color.White;
            SPAddButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPAddButton.ForeColor = Color.Black;
            SPAddButton.Location = new Point(290, 328);
            SPAddButton.Margin = new Padding(3, 2, 3, 2);
            SPAddButton.Name = "SPAddButton";
            SPAddButton.Size = new Size(150, 50);
            SPAddButton.TabIndex = 60;
            SPAddButton.Text = "ADD";
            SPAddButton.UseVisualStyleBackColor = false;
            SPAddButton.Click += SPAddButton_Click;
            // 
            // SPPayDTextBox
            // 
            SPPayDTextBox.Anchor = AnchorStyles.None;
            SPPayDTextBox.BackColor = Color.White;
            SPPayDTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPPayDTextBox.ForeColor = Color.Black;
            SPPayDTextBox.Location = new Point(290, 255);
            SPPayDTextBox.Margin = new Padding(3, 2, 3, 2);
            SPPayDTextBox.Multiline = true;
            SPPayDTextBox.Name = "SPPayDTextBox";
            SPPayDTextBox.RightToLeft = RightToLeft.No;
            SPPayDTextBox.Size = new Size(240, 50);
            SPPayDTextBox.TabIndex = 57;
            // 
            // SPHoursLabel
            // 
            SPHoursLabel.Anchor = AnchorStyles.None;
            SPHoursLabel.BackColor = Color.Transparent;
            SPHoursLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPHoursLabel.ForeColor = Color.White;
            SPHoursLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SPHoursLabel.Location = new Point(876, 255);
            SPHoursLabel.Name = "SPHoursLabel";
            SPHoursLabel.Size = new Size(250, 50);
            SPHoursLabel.TabIndex = 58;
            SPHoursLabel.Text = "Number of Days:";
            SPHoursLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SPPayHLabel
            // 
            SPPayHLabel.Anchor = AnchorStyles.None;
            SPPayHLabel.BackColor = Color.Transparent;
            SPPayHLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPPayHLabel.ForeColor = Color.White;
            SPPayHLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SPPayHLabel.Location = new Point(12, 259);
            SPPayHLabel.Name = "SPPayHLabel";
            SPPayHLabel.Size = new Size(272, 50);
            SPPayHLabel.TabIndex = 56;
            SPPayHLabel.Text = "Payment for Day:";
            SPPayHLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SPDepTextBox
            // 
            SPDepTextBox.Anchor = AnchorStyles.None;
            SPDepTextBox.BackColor = Color.White;
            SPDepTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPDepTextBox.ForeColor = Color.Black;
            SPDepTextBox.Location = new Point(290, 201);
            SPDepTextBox.Margin = new Padding(3, 2, 3, 2);
            SPDepTextBox.Multiline = true;
            SPDepTextBox.Name = "SPDepTextBox";
            SPDepTextBox.RightToLeft = RightToLeft.No;
            SPDepTextBox.Size = new Size(1082, 50);
            SPDepTextBox.TabIndex = 51;
            // 
            // SPEQLabel
            // 
            SPEQLabel.Anchor = AnchorStyles.None;
            SPEQLabel.BackColor = Color.Transparent;
            SPEQLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPEQLabel.ForeColor = Color.White;
            SPEQLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SPEQLabel.Location = new Point(12, 201);
            SPEQLabel.Name = "SPEQLabel";
            SPEQLabel.Size = new Size(272, 50);
            SPEQLabel.TabIndex = 50;
            SPEQLabel.Text = "Department/Unit:";
            SPEQLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SPDesTextBox
            // 
            SPDesTextBox.Anchor = AnchorStyles.None;
            SPDesTextBox.BackColor = Color.White;
            SPDesTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPDesTextBox.ForeColor = Color.Black;
            SPDesTextBox.Location = new Point(290, 147);
            SPDesTextBox.Margin = new Padding(3, 2, 3, 2);
            SPDesTextBox.Multiline = true;
            SPDesTextBox.Name = "SPDesTextBox";
            SPDesTextBox.RightToLeft = RightToLeft.No;
            SPDesTextBox.Size = new Size(1082, 50);
            SPDesTextBox.TabIndex = 49;
            // 
            // SPDesLabel
            // 
            SPDesLabel.Anchor = AnchorStyles.None;
            SPDesLabel.BackColor = Color.Transparent;
            SPDesLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPDesLabel.ForeColor = Color.White;
            SPDesLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SPDesLabel.Location = new Point(12, 147);
            SPDesLabel.Name = "SPDesLabel";
            SPDesLabel.Size = new Size(272, 50);
            SPDesLabel.TabIndex = 48;
            SPDesLabel.Text = "Designation:";
            SPDesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SPNameTextBox
            // 
            SPNameTextBox.Anchor = AnchorStyles.None;
            SPNameTextBox.BackColor = Color.White;
            SPNameTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPNameTextBox.ForeColor = Color.Black;
            SPNameTextBox.Location = new Point(290, 93);
            SPNameTextBox.Margin = new Padding(3, 2, 3, 2);
            SPNameTextBox.Multiline = true;
            SPNameTextBox.Name = "SPNameTextBox";
            SPNameTextBox.RightToLeft = RightToLeft.No;
            SPNameTextBox.Size = new Size(1082, 50);
            SPNameTextBox.TabIndex = 47;
            // 
            // SPNameLabel
            // 
            SPNameLabel.Anchor = AnchorStyles.None;
            SPNameLabel.BackColor = Color.Transparent;
            SPNameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SPNameLabel.ForeColor = Color.White;
            SPNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SPNameLabel.Location = new Point(12, 93);
            SPNameLabel.Name = "SPNameLabel";
            SPNameLabel.Size = new Size(272, 50);
            SPNameLabel.TabIndex = 46;
            SPNameLabel.Text = "Name:";
            SPNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SPDataGridView
            // 
            SPDataGridView.BackgroundColor = Color.White;
            SPDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SPDataGridView.Columns.AddRange(new DataGridViewColumn[] { SPDataID, SPDataName, SPDataDesignation, SPDataDep, SPDataPayD, SPDataDays });
            SPDataGridView.GridColor = Color.Black;
            SPDataGridView.Location = new Point(12, 382);
            SPDataGridView.Margin = new Padding(3, 2, 3, 2);
            SPDataGridView.Name = "SPDataGridView";
            SPDataGridView.RowHeadersWidth = 51;
            SPDataGridView.RowTemplate.Height = 29;
            SPDataGridView.Size = new Size(1360, 214);
            SPDataGridView.TabIndex = 63;
            SPDataGridView.CellClick += SPDataGridView_CellClick;
            // 
            // SPDataID
            // 
            SPDataID.HeaderText = "SPID";
            SPDataID.MinimumWidth = 50;
            SPDataID.Name = "SPDataID";
            SPDataID.Width = 50;
            // 
            // SPDataName
            // 
            SPDataName.HeaderText = "Name";
            SPDataName.MinimumWidth = 300;
            SPDataName.Name = "SPDataName";
            SPDataName.Width = 300;
            // 
            // SPDataDesignation
            // 
            SPDataDesignation.HeaderText = "Designation";
            SPDataDesignation.MinimumWidth = 200;
            SPDataDesignation.Name = "SPDataDesignation";
            SPDataDesignation.Width = 300;
            // 
            // SPDataDep
            // 
            SPDataDep.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SPDataDep.HeaderText = "Department/Unit";
            SPDataDep.MinimumWidth = 300;
            SPDataDep.Name = "SPDataDep";
            // 
            // SPDataPayD
            // 
            SPDataPayD.HeaderText = "Payment for Day";
            SPDataPayD.MinimumWidth = 100;
            SPDataPayD.Name = "SPDataPayD";
            SPDataPayD.Width = 125;
            // 
            // SPDataDays
            // 
            SPDataDays.HeaderText = "Number of Days";
            SPDataDays.MinimumWidth = 100;
            SPDataDays.Name = "SPDataDays";
            SPDataDays.Width = 125;
            // 
            // SPPreviousButton
            // 
            SPPreviousButton.BackColor = Color.Black;
            SPPreviousButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPPreviousButton.ForeColor = Color.White;
            SPPreviousButton.Location = new Point(12, 600);
            SPPreviousButton.Margin = new Padding(3, 2, 3, 2);
            SPPreviousButton.Name = "SPPreviousButton";
            SPPreviousButton.Size = new Size(200, 50);
            SPPreviousButton.TabIndex = 65;
            SPPreviousButton.Text = "PREVIOUS";
            SPPreviousButton.UseVisualStyleBackColor = false;
            SPPreviousButton.Click += RPPreviousButton_Click;
            // 
            // SPNextButton
            // 
            SPNextButton.BackColor = Color.Black;
            SPNextButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPNextButton.ForeColor = Color.White;
            SPNextButton.Location = new Point(1172, 600);
            SPNextButton.Margin = new Padding(3, 2, 3, 2);
            SPNextButton.Name = "SPNextButton";
            SPNextButton.Size = new Size(200, 50);
            SPNextButton.TabIndex = 64;
            SPNextButton.Text = "NEXT";
            SPNextButton.UseVisualStyleBackColor = false;
            SPNextButton.Click += RPNextButton_Click;
            // 
            // RPDLabel
            // 
            RPDLabel.BackColor = Color.Transparent;
            RPDLabel.Dock = DockStyle.Top;
            RPDLabel.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            RPDLabel.ForeColor = Color.White;
            RPDLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPDLabel.Location = new Point(0, 0);
            RPDLabel.Name = "RPDLabel";
            RPDLabel.Size = new Size(1384, 60);
            RPDLabel.TabIndex = 45;
            RPDLabel.Text = "Support Staff Details";
            RPDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.White;
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(1322, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 50);
            CloseButton.TabIndex = 66;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // SPSelectButton
            // 
            SPSelectButton.BackColor = Color.White;
            SPSelectButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SPSelectButton.ForeColor = Color.Black;
            SPSelectButton.Location = new Point(1222, 328);
            SPSelectButton.Margin = new Padding(3, 2, 3, 2);
            SPSelectButton.Name = "SPSelectButton";
            SPSelectButton.Size = new Size(150, 50);
            SPSelectButton.TabIndex = 67;
            SPSelectButton.Text = "SELECT";
            SPSelectButton.UseVisualStyleBackColor = false;
            SPSelectButton.Click += SPSelectButton_Click;
            // 
            // SupportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ICT_Project_Background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 661);
            Controls.Add(SPSelectButton);
            Controls.Add(CloseButton);
            Controls.Add(SPDaysTextBox);
            Controls.Add(SPDeleteButton);
            Controls.Add(SPUpdateButton);
            Controls.Add(SPAddButton);
            Controls.Add(SPPayDTextBox);
            Controls.Add(SPHoursLabel);
            Controls.Add(SPPayHLabel);
            Controls.Add(SPDepTextBox);
            Controls.Add(SPEQLabel);
            Controls.Add(SPDesTextBox);
            Controls.Add(SPDesLabel);
            Controls.Add(SPNameTextBox);
            Controls.Add(SPNameLabel);
            Controls.Add(SPDataGridView);
            Controls.Add(SPPreviousButton);
            Controls.Add(SPNextButton);
            Controls.Add(RPDLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SupportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workshop Planning System";
            Load += SupportForm_Load;
            ((System.ComponentModel.ISupportInitialize)SPDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SPDaysTextBox;
        private Button SPDeleteButton;
        private Button SPUpdateButton;
        private Button SPAddButton;
        private TextBox SPPayDTextBox;
        private Label SPHoursLabel;
        private Label SPPayHLabel;
        private TextBox SPDepTextBox;
        private Label SPEQLabel;
        private TextBox SPDesTextBox;
        private Label SPDesLabel;
        private TextBox SPNameTextBox;
        private Label SPNameLabel;
        private DataGridView SPDataGridView;
        private Button SPPreviousButton;
        private Button SPNextButton;
        private Label RPDLabel;
        private Button CloseButton;
        private Button SPSelectButton;
        private DataGridViewTextBoxColumn SPDataID;
        private DataGridViewTextBoxColumn SPDataName;
        private DataGridViewTextBoxColumn SPDataDesignation;
        private DataGridViewTextBoxColumn SPDataDep;
        private DataGridViewTextBoxColumn SPDataPayD;
        private DataGridViewTextBoxColumn SPDataDays;
    }
}