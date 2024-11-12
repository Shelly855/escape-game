namespace ProgrammingCourseworkGUI
{
    partial class TutorialForm
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
            numberLabel = new Label();
            tutorialLabel = new Label();
            nextButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            numberLabel.Location = new Point(12, 9);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(48, 57);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "1";
            // 
            // tutorialLabel
            // 
            tutorialLabel.AutoSize = true;
            tutorialLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tutorialLabel.Location = new Point(12, 118);
            tutorialLabel.Name = "tutorialLabel";
            tutorialLabel.Size = new Size(99, 35);
            tutorialLabel.TabIndex = 1;
            tutorialLabel.Text = "Tutorial";
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(684, 25);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 41);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(575, 25);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 41);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // TutorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Controls.Add(tutorialLabel);
            Controls.Add(numberLabel);
            Name = "TutorialForm";
            Text = "Tutorial";
            FormClosing += tutorialForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private Label tutorialLabel;
        private Button nextButton;
        private Button backButton;
    }
}