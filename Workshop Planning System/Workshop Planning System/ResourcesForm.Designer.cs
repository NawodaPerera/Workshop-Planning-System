namespace Workshop_Planning_System
{
    partial class ResourcesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourcesForm));
            RPDLabel = new Label();
            RPNextButton = new Button();
            RPPreviousButton = new Button();
            RPDataGridView = new DataGridView();
            RPDataID = new DataGridViewTextBoxColumn();
            RPDataName = new DataGridViewTextBoxColumn();
            RPDataDesignation = new DataGridViewTextBoxColumn();
            RPDataEQ = new DataGridViewTextBoxColumn();
            RPDataAddress = new DataGridViewTextBoxColumn();
            RPDataPayH = new DataGridViewTextBoxColumn();
            RPDataHours = new DataGridViewTextBoxColumn();
            RPDataType = new DataGridViewTextBoxColumn();
            RPNameTextBox = new TextBox();
            RPNameLabel = new Label();
            RPTypeLabel = new Label();
            RPTypeComboBox = new ComboBox();
            RPDesTextBox = new TextBox();
            RPDesLabel = new Label();
            RPEQTextBox = new TextBox();
            RPEQLabel = new Label();
            RPAddressTextBox = new TextBox();
            RPAddressLabel = new Label();
            RPPayHLabel = new Label();
            RPHoursLabel = new Label();
            RPPayHTextBox = new TextBox();
            RPAddButton = new Button();
            RPUpdateButton = new Button();
            RPDeleteButton = new Button();
            RPHoursTextBox = new TextBox();
            CloseButton = new Button();
            RPSelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RPDataGridView).BeginInit();
            SuspendLayout();
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
            RPDLabel.TabIndex = 11;
            RPDLabel.Text = "Resource Persons Details";
            RPDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RPNextButton
            // 
            RPNextButton.BackColor = Color.Black;
            RPNextButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPNextButton.ForeColor = Color.White;
            RPNextButton.Location = new Point(1172, 600);
            RPNextButton.Margin = new Padding(3, 2, 3, 2);
            RPNextButton.Name = "RPNextButton";
            RPNextButton.Size = new Size(200, 50);
            RPNextButton.TabIndex = 43;
            RPNextButton.Text = "NEXT";
            RPNextButton.UseVisualStyleBackColor = false;
            RPNextButton.Click += RPNextButton_Click;
            // 
            // RPPreviousButton
            // 
            RPPreviousButton.Anchor = AnchorStyles.None;
            RPPreviousButton.BackColor = Color.Black;
            RPPreviousButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPPreviousButton.ForeColor = Color.White;
            RPPreviousButton.Location = new Point(12, 600);
            RPPreviousButton.Margin = new Padding(3, 2, 3, 2);
            RPPreviousButton.Name = "RPPreviousButton";
            RPPreviousButton.Size = new Size(200, 50);
            RPPreviousButton.TabIndex = 44;
            RPPreviousButton.Text = "PREVIOUS";
            RPPreviousButton.UseVisualStyleBackColor = false;
            RPPreviousButton.Click += RPPreviousButton_Click;
            // 
            // RPDataGridView
            // 
            RPDataGridView.BackgroundColor = Color.White;
            RPDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RPDataGridView.Columns.AddRange(new DataGridViewColumn[] { RPDataID, RPDataName, RPDataDesignation, RPDataEQ, RPDataAddress, RPDataPayH, RPDataHours, RPDataType });
            RPDataGridView.GridColor = Color.Black;
            RPDataGridView.Location = new Point(12, 396);
            RPDataGridView.Margin = new Padding(3, 2, 3, 2);
            RPDataGridView.Name = "RPDataGridView";
            RPDataGridView.RowHeadersWidth = 51;
            RPDataGridView.RowTemplate.Height = 29;
            RPDataGridView.Size = new Size(1360, 200);
            RPDataGridView.TabIndex = 42;
            RPDataGridView.CellClick += RPDataGridView_CellClick;
            // 
            // RPDataID
            // 
            RPDataID.HeaderText = "RPID";
            RPDataID.MinimumWidth = 50;
            RPDataID.Name = "RPDataID";
            RPDataID.Width = 50;
            // 
            // RPDataName
            // 
            RPDataName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataName.HeaderText = "Name";
            RPDataName.MinimumWidth = 250;
            RPDataName.Name = "RPDataName";
            RPDataName.Width = 250;
            // 
            // RPDataDesignation
            // 
            RPDataDesignation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataDesignation.HeaderText = "Designation";
            RPDataDesignation.MinimumWidth = 200;
            RPDataDesignation.Name = "RPDataDesignation";
            RPDataDesignation.Width = 200;
            // 
            // RPDataEQ
            // 
            RPDataEQ.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataEQ.HeaderText = "Education Qualification";
            RPDataEQ.MinimumWidth = 150;
            RPDataEQ.Name = "RPDataEQ";
            RPDataEQ.Width = 150;
            // 
            // RPDataAddress
            // 
            RPDataAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPDataAddress.HeaderText = "Address";
            RPDataAddress.MinimumWidth = 150;
            RPDataAddress.Name = "RPDataAddress";
            // 
            // RPDataPayH
            // 
            RPDataPayH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataPayH.HeaderText = "Payment for Hour";
            RPDataPayH.MinimumWidth = 50;
            RPDataPayH.Name = "RPDataPayH";
            RPDataPayH.Width = 92;
            // 
            // RPDataHours
            // 
            RPDataHours.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataHours.HeaderText = "Number of Hours";
            RPDataHours.MinimumWidth = 50;
            RPDataHours.Name = "RPDataHours";
            RPDataHours.Width = 86;
            // 
            // RPDataType
            // 
            RPDataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RPDataType.HeaderText = "Resource Type";
            RPDataType.MinimumWidth = 125;
            RPDataType.Name = "RPDataType";
            RPDataType.Width = 125;
            // 
            // RPNameTextBox
            // 
            RPNameTextBox.Anchor = AnchorStyles.None;
            RPNameTextBox.BackColor = Color.White;
            RPNameTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPNameTextBox.ForeColor = Color.Black;
            RPNameTextBox.Location = new Point(327, 72);
            RPNameTextBox.Margin = new Padding(3, 2, 3, 2);
            RPNameTextBox.Multiline = true;
            RPNameTextBox.Name = "RPNameTextBox";
            RPNameTextBox.RightToLeft = RightToLeft.No;
            RPNameTextBox.Size = new Size(1045, 50);
            RPNameTextBox.TabIndex = 26;
            // 
            // RPNameLabel
            // 
            RPNameLabel.Anchor = AnchorStyles.None;
            RPNameLabel.BackColor = Color.Transparent;
            RPNameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPNameLabel.ForeColor = Color.White;
            RPNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPNameLabel.Location = new Point(12, 72);
            RPNameLabel.Name = "RPNameLabel";
            RPNameLabel.Size = new Size(309, 50);
            RPNameLabel.TabIndex = 25;
            RPNameLabel.Text = "Name:";
            RPNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPTypeLabel
            // 
            RPTypeLabel.Anchor = AnchorStyles.None;
            RPTypeLabel.BackColor = Color.Transparent;
            RPTypeLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPTypeLabel.ForeColor = Color.White;
            RPTypeLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPTypeLabel.Location = new Point(868, 180);
            RPTypeLabel.Name = "RPTypeLabel";
            RPTypeLabel.Size = new Size(286, 50);
            RPTypeLabel.TabIndex = 31;
            RPTypeLabel.Text = "Resource Type:";
            RPTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPTypeComboBox
            // 
            RPTypeComboBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPTypeComboBox.FormattingEnabled = true;
            RPTypeComboBox.Items.AddRange(new object[] { "Internal", "External", "Alternative" });
            RPTypeComboBox.Location = new Point(1160, 187);
            RPTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            RPTypeComboBox.Name = "RPTypeComboBox";
            RPTypeComboBox.Size = new Size(212, 39);
            RPTypeComboBox.TabIndex = 32;
            RPTypeComboBox.Text = "Select Type";
            // 
            // RPDesTextBox
            // 
            RPDesTextBox.Anchor = AnchorStyles.None;
            RPDesTextBox.BackColor = Color.White;
            RPDesTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPDesTextBox.ForeColor = Color.Black;
            RPDesTextBox.Location = new Point(327, 126);
            RPDesTextBox.Margin = new Padding(3, 2, 3, 2);
            RPDesTextBox.Multiline = true;
            RPDesTextBox.Name = "RPDesTextBox";
            RPDesTextBox.RightToLeft = RightToLeft.No;
            RPDesTextBox.Size = new Size(1045, 50);
            RPDesTextBox.TabIndex = 28;
            // 
            // RPDesLabel
            // 
            RPDesLabel.Anchor = AnchorStyles.None;
            RPDesLabel.BackColor = Color.Transparent;
            RPDesLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPDesLabel.ForeColor = Color.White;
            RPDesLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPDesLabel.Location = new Point(12, 126);
            RPDesLabel.Name = "RPDesLabel";
            RPDesLabel.Size = new Size(309, 50);
            RPDesLabel.TabIndex = 27;
            RPDesLabel.Text = "Designation:";
            RPDesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPEQTextBox
            // 
            RPEQTextBox.Anchor = AnchorStyles.None;
            RPEQTextBox.BackColor = Color.White;
            RPEQTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPEQTextBox.ForeColor = Color.Black;
            RPEQTextBox.Location = new Point(327, 180);
            RPEQTextBox.Margin = new Padding(3, 2, 3, 2);
            RPEQTextBox.Multiline = true;
            RPEQTextBox.Name = "RPEQTextBox";
            RPEQTextBox.RightToLeft = RightToLeft.No;
            RPEQTextBox.Size = new Size(421, 50);
            RPEQTextBox.TabIndex = 30;
            // 
            // RPEQLabel
            // 
            RPEQLabel.Anchor = AnchorStyles.None;
            RPEQLabel.BackColor = Color.Transparent;
            RPEQLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPEQLabel.ForeColor = Color.White;
            RPEQLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPEQLabel.Location = new Point(12, 180);
            RPEQLabel.Name = "RPEQLabel";
            RPEQLabel.Size = new Size(309, 50);
            RPEQLabel.TabIndex = 29;
            RPEQLabel.Text = "Education Qualification:";
            RPEQLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPAddressTextBox
            // 
            RPAddressTextBox.Anchor = AnchorStyles.None;
            RPAddressTextBox.BackColor = Color.White;
            RPAddressTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPAddressTextBox.ForeColor = Color.Black;
            RPAddressTextBox.Location = new Point(327, 234);
            RPAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            RPAddressTextBox.Multiline = true;
            RPAddressTextBox.Name = "RPAddressTextBox";
            RPAddressTextBox.RightToLeft = RightToLeft.No;
            RPAddressTextBox.Size = new Size(1045, 50);
            RPAddressTextBox.TabIndex = 34;
            // 
            // RPAddressLabel
            // 
            RPAddressLabel.Anchor = AnchorStyles.None;
            RPAddressLabel.BackColor = Color.Transparent;
            RPAddressLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPAddressLabel.ForeColor = Color.White;
            RPAddressLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPAddressLabel.Location = new Point(12, 234);
            RPAddressLabel.Name = "RPAddressLabel";
            RPAddressLabel.Size = new Size(309, 50);
            RPAddressLabel.TabIndex = 33;
            RPAddressLabel.Text = "Address:";
            RPAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPPayHLabel
            // 
            RPPayHLabel.Anchor = AnchorStyles.None;
            RPPayHLabel.BackColor = Color.Transparent;
            RPPayHLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPPayHLabel.ForeColor = Color.White;
            RPPayHLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPPayHLabel.Location = new Point(12, 288);
            RPPayHLabel.Name = "RPPayHLabel";
            RPPayHLabel.Size = new Size(309, 50);
            RPPayHLabel.TabIndex = 35;
            RPPayHLabel.Text = "Payment for Hour:";
            RPPayHLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPHoursLabel
            // 
            RPHoursLabel.Anchor = AnchorStyles.None;
            RPHoursLabel.BackColor = Color.Transparent;
            RPHoursLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPHoursLabel.ForeColor = Color.White;
            RPHoursLabel.ImageAlign = ContentAlignment.MiddleLeft;
            RPHoursLabel.Location = new Point(868, 290);
            RPHoursLabel.Name = "RPHoursLabel";
            RPHoursLabel.Size = new Size(286, 50);
            RPHoursLabel.TabIndex = 37;
            RPHoursLabel.Text = "Number of Hours:";
            RPHoursLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RPPayHTextBox
            // 
            RPPayHTextBox.Anchor = AnchorStyles.None;
            RPPayHTextBox.BackColor = Color.White;
            RPPayHTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPPayHTextBox.ForeColor = Color.Black;
            RPPayHTextBox.Location = new Point(327, 288);
            RPPayHTextBox.Margin = new Padding(3, 2, 3, 2);
            RPPayHTextBox.Multiline = true;
            RPPayHTextBox.Name = "RPPayHTextBox";
            RPPayHTextBox.RightToLeft = RightToLeft.No;
            RPPayHTextBox.Size = new Size(212, 50);
            RPPayHTextBox.TabIndex = 36;
            // 
            // RPAddButton
            // 
            RPAddButton.BackColor = Color.White;
            RPAddButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPAddButton.ForeColor = Color.Black;
            RPAddButton.Location = new Point(327, 342);
            RPAddButton.Margin = new Padding(3, 2, 3, 2);
            RPAddButton.Name = "RPAddButton";
            RPAddButton.Size = new Size(150, 50);
            RPAddButton.TabIndex = 39;
            RPAddButton.Text = "ADD";
            RPAddButton.UseVisualStyleBackColor = false;
            RPAddButton.Click += RPAddButton_Click;
            // 
            // RPUpdateButton
            // 
            RPUpdateButton.BackColor = Color.White;
            RPUpdateButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPUpdateButton.ForeColor = Color.Black;
            RPUpdateButton.Location = new Point(483, 342);
            RPUpdateButton.Margin = new Padding(3, 2, 3, 2);
            RPUpdateButton.Name = "RPUpdateButton";
            RPUpdateButton.Size = new Size(150, 50);
            RPUpdateButton.TabIndex = 40;
            RPUpdateButton.Text = "UPDATE";
            RPUpdateButton.UseVisualStyleBackColor = false;
            RPUpdateButton.Click += RPUpdateButton_Click;
            // 
            // RPDeleteButton
            // 
            RPDeleteButton.BackColor = Color.White;
            RPDeleteButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPDeleteButton.ForeColor = Color.Black;
            RPDeleteButton.Location = new Point(639, 342);
            RPDeleteButton.Margin = new Padding(3, 2, 3, 2);
            RPDeleteButton.Name = "RPDeleteButton";
            RPDeleteButton.Size = new Size(150, 50);
            RPDeleteButton.TabIndex = 41;
            RPDeleteButton.Text = "DELETE";
            RPDeleteButton.UseVisualStyleBackColor = false;
            RPDeleteButton.Click += RPDeleteButton_Click;
            // 
            // RPHoursTextBox
            // 
            RPHoursTextBox.Anchor = AnchorStyles.None;
            RPHoursTextBox.BackColor = Color.White;
            RPHoursTextBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RPHoursTextBox.ForeColor = Color.Black;
            RPHoursTextBox.Location = new Point(1160, 288);
            RPHoursTextBox.Margin = new Padding(3, 2, 3, 2);
            RPHoursTextBox.Multiline = true;
            RPHoursTextBox.Name = "RPHoursTextBox";
            RPHoursTextBox.RightToLeft = RightToLeft.No;
            RPHoursTextBox.Size = new Size(212, 50);
            RPHoursTextBox.TabIndex = 38;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.White;
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(1322, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 50);
            CloseButton.TabIndex = 45;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // RPSelectButton
            // 
            RPSelectButton.BackColor = Color.White;
            RPSelectButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RPSelectButton.ForeColor = Color.Black;
            RPSelectButton.Location = new Point(1222, 342);
            RPSelectButton.Margin = new Padding(3, 2, 3, 2);
            RPSelectButton.Name = "RPSelectButton";
            RPSelectButton.Size = new Size(150, 50);
            RPSelectButton.TabIndex = 46;
            RPSelectButton.Text = "SELECT";
            RPSelectButton.UseVisualStyleBackColor = false;
            RPSelectButton.Click += RPSelectButton_Click;
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ICT_Project_Background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 661);
            Controls.Add(RPSelectButton);
            Controls.Add(CloseButton);
            Controls.Add(RPHoursTextBox);
            Controls.Add(RPDeleteButton);
            Controls.Add(RPUpdateButton);
            Controls.Add(RPAddButton);
            Controls.Add(RPPayHTextBox);
            Controls.Add(RPHoursLabel);
            Controls.Add(RPPayHLabel);
            Controls.Add(RPAddressTextBox);
            Controls.Add(RPAddressLabel);
            Controls.Add(RPEQTextBox);
            Controls.Add(RPEQLabel);
            Controls.Add(RPDesTextBox);
            Controls.Add(RPDesLabel);
            Controls.Add(RPTypeLabel);
            Controls.Add(RPNameTextBox);
            Controls.Add(RPNameLabel);
            Controls.Add(RPDataGridView);
            Controls.Add(RPPreviousButton);
            Controls.Add(RPNextButton);
            Controls.Add(RPDLabel);
            Controls.Add(RPTypeComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResourcesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "=";
            Load += ResourcesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RPDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RPDLabel;
        private Button RPNextButton;
        private Button RPPreviousButton;
        private DataGridView RPDataGridView;
        private TextBox RPNameTextBox;
        private Label RPNameLabel;
        private Label RPTypeLabel;
        private ComboBox RPTypeComboBox;
        private TextBox RPDesTextBox;
        private Label RPDesLabel;
        private TextBox RPEQTextBox;
        private Label RPEQLabel;
        private TextBox RPAddressTextBox;
        private Label RPAddressLabel;
        private Label RPPayHLabel;
        private Label RPHoursLabel;
        private TextBox RPPayHTextBox;
        private Button RPAddButton;
        private Button RPUpdateButton;
        private Button RPDeleteButton;
        private TextBox RPHoursTextBox;
        private Button CloseButton;
        private Button RPSelectButton;
        private DataGridViewTextBoxColumn RPDataID;
        private DataGridViewTextBoxColumn RPDataName;
        private DataGridViewTextBoxColumn RPDataDesignation;
        private DataGridViewTextBoxColumn RPDataEQ;
        private DataGridViewTextBoxColumn RPDataAddress;
        private DataGridViewTextBoxColumn RPDataPayH;
        private DataGridViewTextBoxColumn RPDataHours;
        private DataGridViewTextBoxColumn RPDataType;
    }
}