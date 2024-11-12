namespace ProgrammingCourseworkGUI
{
    partial class ArcadeForm
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
            arcadeLabel = new Label();
            answerTextBox = new TextBox();
            confirmButton = new Button();
            promptLabel = new Label();
            SuspendLayout();
            // 
            // arcadeLabel
            // 
            arcadeLabel.AutoSize = true;
            arcadeLabel.BackColor = SystemColors.InactiveCaption;
            arcadeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            arcadeLabel.Location = new Point(120, 44);
            arcadeLabel.Name = "arcadeLabel";
            arcadeLabel.Size = new Size(70, 32);
            arcadeLabel.TabIndex = 1;
            arcadeLabel.Text = "        ";
            arcadeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            answerTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            answerTextBox.Location = new Point(321, 317);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(125, 32);
            answerTextBox.TabIndex = 2;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(321, 362);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(128, 52);
            confirmButton.TabIndex = 4;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.BackColor = SystemColors.InactiveCaption;
            promptLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            promptLabel.Location = new Point(267, 237);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(70, 32);
            promptLabel.TabIndex = 5;
            promptLabel.Text = "        ";
            promptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArcadeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(promptLabel);
            Controls.Add(confirmButton);
            Controls.Add(answerTextBox);
            Controls.Add(arcadeLabel);
            Name = "ArcadeForm";
            Text = "Arcade Machine";
            FormClosing += arcadeForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label arcadeLabel;
        private TextBox answerTextBox;
        private Button confirmButton;
        private Label promptLabel;
    }
}