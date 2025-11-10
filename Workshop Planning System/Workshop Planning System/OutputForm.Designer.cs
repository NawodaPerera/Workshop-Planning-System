namespace Workshop_Planning_System
{
    partial class OutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputForm));
            CloseButton = new Button();
            OutputFlowLayoutPanel = new FlowLayoutPanel();
            OutPanel01 = new Panel();
            OutPanel02 = new Panel();
            OutPanel03 = new Panel();
            OutPanel04 = new Panel();
            OutPanel05 = new Panel();
            OutPanel06 = new Panel();
            OutPanel07 = new Panel();
            OutPanel08 = new Panel();
            OutputSaveFileDialog = new SaveFileDialog();
            OutputPrintPreviewDialog = new PrintPreviewDialog();
            OutputPrintDocument = new System.Drawing.Printing.PrintDocument();
            PrintButton = new Button();
            SaveButton = new Button();
            OutputFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.White;
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(603, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 50);
            CloseButton.TabIndex = 68;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // OutputFlowLayoutPanel
            // 
            OutputFlowLayoutPanel.AutoScroll = true;
            OutputFlowLayoutPanel.BackColor = SystemColors.Control;
            OutputFlowLayoutPanel.Controls.Add(OutPanel01);
            OutputFlowLayoutPanel.Controls.Add(OutPanel02);
            OutputFlowLayoutPanel.Controls.Add(OutPanel03);
            OutputFlowLayoutPanel.Controls.Add(OutPanel04);
            OutputFlowLayoutPanel.Controls.Add(OutPanel05);
            OutputFlowLayoutPanel.Controls.Add(OutPanel06);
            OutputFlowLayoutPanel.Controls.Add(OutPanel07);
            OutputFlowLayoutPanel.Controls.Add(OutPanel08);
            OutputFlowLayoutPanel.Location = new Point(32, 68);
            OutputFlowLayoutPanel.Name = "OutputFlowLayoutPanel";
            OutputFlowLayoutPanel.Size = new Size(621, 890);
            OutputFlowLayoutPanel.TabIndex = 69;
            // 
            // OutPanel01
            // 
            OutPanel01.Location = new Point(3, 3);
            OutPanel01.Name = "OutPanel01";
            OutPanel01.Size = new Size(595, 842);
            OutPanel01.TabIndex = 0;
            // 
            // OutPanel02
            // 
            OutPanel02.Location = new Point(3, 851);
            OutPanel02.Name = "OutPanel02";
            OutPanel02.Size = new Size(595, 842);
            OutPanel02.TabIndex = 1;
            // 
            // OutPanel03
            // 
            OutPanel03.Location = new Point(3, 1699);
            OutPanel03.Name = "OutPanel03";
            OutPanel03.Size = new Size(595, 842);
            OutPanel03.TabIndex = 2;
            // 
            // OutPanel04
            // 
            OutPanel04.Location = new Point(3, 2547);
            OutPanel04.Name = "OutPanel04";
            OutPanel04.Size = new Size(595, 842);
            OutPanel04.TabIndex = 3;
            // 
            // OutPanel05
            // 
            OutPanel05.Location = new Point(3, 3395);
            OutPanel05.Name = "OutPanel05";
            OutPanel05.Size = new Size(595, 842);
            OutPanel05.TabIndex = 5;
            // 
            // OutPanel06
            // 
            OutPanel06.Location = new Point(3, 4243);
            OutPanel06.Name = "OutPanel06";
            OutPanel06.Size = new Size(595, 842);
            OutPanel06.TabIndex = 7;
            // 
            // OutPanel07
            // 
            OutPanel07.Location = new Point(3, 5091);
            OutPanel07.Name = "OutPanel07";
            OutPanel07.Size = new Size(595, 842);
            OutPanel07.TabIndex = 6;
            // 
            // OutPanel08
            // 
            OutPanel08.Location = new Point(3, 5939);
            OutPanel08.Name = "OutPanel08";
            OutPanel08.Size = new Size(595, 842);
            OutPanel08.TabIndex = 4;
            // 
            // OutputPrintPreviewDialog
            // 
            OutputPrintPreviewDialog.AutoScrollMargin = new Size(0, 0);
            OutputPrintPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            OutputPrintPreviewDialog.ClientSize = new Size(400, 300);
            OutputPrintPreviewDialog.Document = OutputPrintDocument;
            OutputPrintPreviewDialog.Enabled = true;
            OutputPrintPreviewDialog.Icon = (Icon)resources.GetObject("OutputPrintPreviewDialog.Icon");
            OutputPrintPreviewDialog.Name = "OutputPrintPreviewDialog";
            OutputPrintPreviewDialog.Visible = false;
            // 
            // OutputPrintDocument
            // 
            OutputPrintDocument.PrintPage += OutputPrintDocument_PrintPage;
            // 
            // PrintButton
            // 
            PrintButton.BackColor = Color.White;
            PrintButton.BackgroundImage = Properties.Resources.Print_Button;
            PrintButton.BackgroundImageLayout = ImageLayout.Stretch;
            PrintButton.Location = new Point(88, 12);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(50, 50);
            PrintButton.TabIndex = 70;
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.White;
            SaveButton.BackgroundImage = Properties.Resources.Save_Button;
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.Location = new Point(32, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(50, 50);
            SaveButton.TabIndex = 71;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // OutputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ICT_Project_Background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 961);
            Controls.Add(SaveButton);
            Controls.Add(PrintButton);
            Controls.Add(CloseButton);
            Controls.Add(OutputFlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OutputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workshop Planning System";
            OutputFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button CloseButton;
        private FlowLayoutPanel OutputFlowLayoutPanel;
        private Panel OutPanel01;
        private Panel OutPanel02;
        private Panel OutPanel03;
        private Panel OutPanel04;
        private Panel OutPanel05;
        private Panel OutPanel06;
        private Panel OutPanel07;
        private Panel OutPanel08;
        private SaveFileDialog OutputSaveFileDialog;
        private PrintPreviewDialog OutputPrintPreviewDialog;
        private Button PrintButton;
        private Button SaveButton;
        private System.Drawing.Printing.PrintDocument OutputPrintDocument;
    }
}