﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizapp.Model;

namespace quizapp.View
{
    partial class CreateQuestionForm : Form
    {
        public CreateQuestionForm()
        {
            InitializeComponent();
            LoadQuiz();
        }

        // Methods
        private void toggleMutilpleChoice(bool toggle)
        {
            this.optionACheckBox.Visible = toggle;
            this.optionBCheckBox.Visible = toggle;
            this.optionCCheckBox.Visible = toggle;

            this.optionAInput.Visible = toggle;
            this.optionBInput.Visible = toggle;
            this.optionCInput.Visible = toggle;
        }

        private void LoadQuiz()
        {
            List<Quiz> quizzes = Quiz.GetAll();
            this.quizSelectionList.DataSource = quizzes;
            this.quizSelectionList.DisplayMember = "Title";
            this.quizSelectionList.ValueMember = "Type";
        }

        private void ReloadQuiz()
        {
            this.quizSelectionList.DataSource = null;
            LoadQuiz();
        }

        // Event
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Show dialog confirmation popup
            DialogResult confirmation = Dialog.Confirm("Are you sure want to exit the application?");

            // Close application if yes
            if (confirmation == DialogResult.Yes) Application.Exit();
        }

        private void createQuizBtn_Click(object sender, EventArgs e)
        {
            if (this.quizNameInput.Text == "" || this.quizTypeList.SelectedIndex == -1 || this.quizCategoryList.SelectedIndex == -1)
                Dialog.Error("Please fill the form!");
            else new Quiz(this.quizNameInput.Text, this.quizTypeList.SelectedItem.ToString(), this.quizCategoryList.SelectedItem.ToString()).Save();

            // Reload quiz data
            ReloadQuiz();
        }

        private void quizSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quizSelectionList.SelectedItem != null)
            {
                object selectedValue = quizSelectionList.SelectedValue;
                Console.WriteLine("Selected Value: " + selectedValue.ToString());
            }
        }
    }
}
