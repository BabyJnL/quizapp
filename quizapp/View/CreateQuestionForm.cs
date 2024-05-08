using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizapp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace quizapp.View
{
    partial class CreateQuestionForm : Form
    {
        private string _correctAnswer;
        public CreateQuestionForm()
        {
            InitializeComponent();
            LoadQuiz();
        }

        // Methods
        private void ToggleMutilpleChoice(bool toggle)
        {
            this.optionABtn.Enabled = toggle;
            this.optionBBtn.Enabled = toggle;
            this.optionCBtn.Enabled = toggle;

            this.optionAInput.Enabled = toggle;
            this.optionBInput.Enabled = toggle;
            this.optionCInput.Enabled = toggle;
        }

        private void LoadQuiz()
        {
            List<Quiz> quizzes = Quiz.GetAll();

            this.quizSelectionList.DataSource = quizzes;
            this.quizSelectionList.DisplayMember = "Title";

            this.quizSelectionList.SelectedItem = null;
        }

        private void ReloadQuiz()
        {
            this.quizSelectionList.DataSource = null;
            LoadQuiz();
        }

        private void SetAsCorrectAnswer(object sender, System.Windows.Forms.RadioButton radioButton, TextBox inputBox)
        {
            System.Windows.Forms.RadioButton radioBtn = sender as System.Windows.Forms.RadioButton;

            if (radioBtn.Checked) this._correctAnswer = inputBox.Text;
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
                Quiz selectedValue = (Quiz)quizSelectionList.SelectedValue;

                if (selectedValue.Type != "multiple_choice") ToggleMutilpleChoice(false);
                else ToggleMutilpleChoice(true);
            }
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            Quiz quiz = (Quiz)quizSelectionList.SelectedItem;

            if (this.quizSelectionList.SelectedItem != null && this.questionNameInput.Text != "")
            {
                if (quiz.Type == "essay")
                {
                    new Question(quiz.Id, this.questionNameInput.Text).Save();
                }
                else if (quiz.Type == "multiple_choice" && (this.optionABtn.Checked || this.optionBBtn.Checked || this.optionCBtn.Checked) && (this.optionAInput.Text != "" && this.optionBInput.Text != "" && this.optionCInput.Text != ""))
                {
                    List<string> choices = new List<string>()
                    {
                        this.optionAInput.Text,
                        this.optionBInput.Text,
                        this.optionCInput.Text
                    };

                    new MultipleChoiceQuestion(quiz.Id, this.questionNameInput.Text, choices, this._correctAnswer).Save();
                }
            }
            else Dialog.Error("Please fill the question data");
        }

        private void optionABtn_CheckedChanged(object sender, EventArgs e)
        {
            SetAsCorrectAnswer(sender, this.optionABtn, this.optionAInput);
        }

        private void optionBBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetAsCorrectAnswer(sender, this.optionBBtn, this.optionBInput);
        }

        private void optionCBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetAsCorrectAnswer(sender, this.optionCBtn, this.optionCInput);
        }

        private void quizListBtn_Click(object sender, EventArgs e)
        {
            QuizListForm quizListForm = new QuizListForm();
            this.Close();
            quizListForm.Show();
        }

        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            ManageUserForm manageUserForm = new ManageUserForm();
            this.Close();
            manageUserForm.Show();
        }
    }
}
