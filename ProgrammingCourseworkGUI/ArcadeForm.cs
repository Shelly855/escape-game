using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingCourseworkGUI
{
    public partial class arcadeForm : Form
    {

        private mainForm mainForm;
        private string userAnswer;
        private bool puzzleSolved;

        public arcadeForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            puzzleSolved = false;

            arcadeLabel.Text = "Cat or Dog?\n" +
                               "Please enter the initials of your choice in the textbox\n" +
                               "and press confirm.\n" +
                               "e.g. c for Cat";
            promptLabel.Text = "";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            userAnswer = answerTextBox.Text.ToLower().Trim();

            if (userAnswer == "c" || userAnswer == "cat")
            {
                promptLabel.Text = "Your answer is correct!";
                MessageBox.Show("Your answer is correct!");

                puzzleSolved = true;
                this.Hide();
                mainForm.SolvedArcadePuzzle();
            }
            else
            {
                promptLabel.Text = "Your answer is incorrect!";
            }
        }

        private void arcadeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!puzzleSolved)
            {
                e.Cancel = true;
                MessageBox.Show("Hint: The arcade machine seems to like cats.");
            }
        }
    }
}

//puzzle from https://game8.co/games/Honkai-Star-Rail/archives/409802