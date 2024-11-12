namespace ProgrammingCourseworkGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLabel = new Label();
            locationLabel = new Label();
            inventoryListBox = new ListBox();
            subOptionLabel = new Label();
            healthLabel = new Label();
            energyLabel = new Label();
            inventoryLabel = new Label();
            choiceComboBox = new ComboBox();
            tutorialButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            choiceLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.Anchor = AnchorStyles.Left;
            mainLabel.AutoSize = true;
            mainLabel.BackColor = SystemColors.InactiveCaption;
            mainLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.Location = new Point(335, 69);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(70, 32);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "        ";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(12, 9);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(69, 20);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // inventoryListBox
            // 
            inventoryListBox.Anchor = AnchorStyles.None;
            inventoryListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 28;
            inventoryListBox.Location = new Point(1170, 184);
            inventoryListBox.Name = "inventoryListBox";
            tableLayoutPanel1.SetRowSpan(inventoryListBox, 2);
            inventoryListBox.Size = new Size(382, 312);
            inventoryListBox.TabIndex = 7;
            // 
            // subOptionLabel
            // 
            subOptionLabel.Anchor = AnchorStyles.Left;
            subOptionLabel.AutoSize = true;
            subOptionLabel.BackColor = SystemColors.InactiveCaption;
            subOptionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            subOptionLabel.Location = new Point(335, 409);
            subOptionLabel.Name = "subOptionLabel";
            subOptionLabel.Size = new Size(77, 32);
            subOptionLabel.TabIndex = 14;
            subOptionLabel.Text = "         ";
            // 
            // healthLabel
            // 
            healthLabel.Anchor = AnchorStyles.None;
            healthLabel.AutoSize = true;
            healthLabel.BackColor = Color.LightCoral;
            healthLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            healthLabel.Location = new Point(207, 0);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(67, 30);
            healthLabel.TabIndex = 18;
            healthLabel.Text = "         ";
            // 
            // energyLabel
            // 
            energyLabel.Anchor = AnchorStyles.None;
            energyLabel.AutoSize = true;
            energyLabel.BackColor = Color.Gold;
            energyLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            energyLabel.Location = new Point(207, 53);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(67, 30);
            energyLabel.TabIndex = 19;
            energyLabel.Text = "         ";
            // 
            // inventoryLabel
            // 
            inventoryLabel.Anchor = AnchorStyles.None;
            inventoryLabel.AutoSize = true;
            inventoryLabel.BackColor = Color.LightGreen;
            inventoryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(1256, 64);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(210, 41);
            inventoryLabel.TabIndex = 21;
            inventoryLabel.Text = "Your Inventory";
            // 
            // choiceComboBox
            // 
            choiceComboBox.Anchor = AnchorStyles.Top;
            choiceComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            choiceComboBox.FormattingEnabled = true;
            choiceComboBox.Location = new Point(73, 173);
            choiceComboBox.Name = "choiceComboBox";
            choiceComboBox.Size = new Size(186, 36);
            choiceComboBox.TabIndex = 22;
            // 
            // tutorialButton
            // 
            tutorialButton.Anchor = AnchorStyles.None;
            tutorialButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tutorialButton.Location = new Point(181, 114);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(193, 55);
            tutorialButton.TabIndex = 23;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3313541F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3330841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 3);
            tableLayoutPanel1.Controls.Add(inventoryListBox, 2, 1);
            tableLayoutPanel1.Controls.Add(inventoryLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(mainLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(subOptionLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(choiceComboBox, 0, 1);
            tableLayoutPanel1.Controls.Add(choiceLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(44, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1634, 682);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(energyLabel);
            panel1.Controls.Add(tutorialButton);
            panel1.Controls.Add(healthLabel);
            panel1.Location = new Point(1092, 513);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 166);
            panel1.TabIndex = 25;
            // 
            // choiceLabel
            // 
            choiceLabel.Anchor = AnchorStyles.None;
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = SystemColors.Info;
            choiceLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            choiceLabel.Location = new Point(82, 65);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(167, 40);
            choiceLabel.TabIndex = 13;
            choiceLabel.Text = "Your Choice";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 780);
            Controls.Add(locationLabel);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Main";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainLabel;
        private Label locationLabel;
        private ListBox inventoryListBox;
        private Label subOptionLabel;
        private Label healthLabel;
        private Label energyLabel;
        private Label inventoryLabel;
        private ComboBox choiceComboBox;
        private Button tutorialButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label choiceLabel;
    }
}