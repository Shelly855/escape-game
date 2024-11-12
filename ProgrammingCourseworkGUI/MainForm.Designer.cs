namespace ProgrammingCourseworkGUI
{
    partial class mainForm
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
            choiceLabel = new Label();
            subOptionLabel = new Label();
            healthLabel = new Label();
            energyLabel = new Label();
            inventoryLabel = new Label();
            choiceComboBox = new ComboBox();
            tutorialButton = new Button();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = SystemColors.InactiveCaption;
            mainLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.Location = new Point(300, 97);
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
            inventoryListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 28;
            inventoryListBox.Location = new Point(1305, 131);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(396, 228);
            inventoryListBox.TabIndex = 7;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = SystemColors.Info;
            choiceLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            choiceLabel.Location = new Point(54, 68);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(128, 30);
            choiceLabel.TabIndex = 13;
            choiceLabel.Text = "Your Choice";
            // 
            // subOptionLabel
            // 
            subOptionLabel.AutoSize = true;
            subOptionLabel.BackColor = SystemColors.InactiveCaption;
            subOptionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            subOptionLabel.Location = new Point(300, 497);
            subOptionLabel.Name = "subOptionLabel";
            subOptionLabel.Size = new Size(77, 32);
            subOptionLabel.TabIndex = 14;
            subOptionLabel.Text = "         ";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.BackColor = Color.LightCoral;
            healthLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            healthLabel.Location = new Point(1482, 521);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(67, 30);
            healthLabel.TabIndex = 18;
            healthLabel.Text = "         ";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.BackColor = Color.Gold;
            energyLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            energyLabel.Location = new Point(1482, 599);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(67, 30);
            energyLabel.TabIndex = 19;
            energyLabel.Text = "         ";
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.BackColor = Color.LightGreen;
            inventoryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(1380, 52);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(210, 41);
            inventoryLabel.TabIndex = 21;
            inventoryLabel.Text = "Your Inventory";
            // 
            // choiceComboBox
            // 
            choiceComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            choiceComboBox.FormattingEnabled = true;
            choiceComboBox.Location = new Point(28, 131);
            choiceComboBox.Name = "choiceComboBox";
            choiceComboBox.Size = new Size(186, 36);
            choiceComboBox.TabIndex = 22;
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tutorialButton.Location = new Point(1424, 680);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(193, 55);
            tutorialButton.TabIndex = 23;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 780);
            Controls.Add(tutorialButton);
            Controls.Add(choiceComboBox);
            Controls.Add(inventoryLabel);
            Controls.Add(energyLabel);
            Controls.Add(healthLabel);
            Controls.Add(subOptionLabel);
            Controls.Add(choiceLabel);
            Controls.Add(inventoryListBox);
            Controls.Add(locationLabel);
            Controls.Add(mainLabel);
            Name = "mainForm";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainLabel;
        private Label locationLabel;
        private ListBox inventoryListBox;
        private Label choiceLabel;
        private Label subOptionLabel;
        private Label healthLabel;
        private Label energyLabel;
        private Label inventoryLabel;
        private ComboBox choiceComboBox;
        private Button tutorialButton;
    }
}