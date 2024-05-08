using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp.View
{
    public partial class PlayQuizForm : Form
    {
        private string questionType;
        private int questionIndex = 0;
        private List<object> questionLists = new List<object>();
        private string userAnswer;
        public PlayQuizForm(List<object> questions, string questionType)
        {
            this.questionType = questionType;

            InitializeComponent();

            if (questionType == "multiple_choice") this.essayBox.Visible = false;
            else
            {
                this.optionABtn.Visible = false;
                this.optionBBtn.Visible = false;
                this.optionCBtn.Visible = false;
            }

            questions.ForEach(question =>
            {
                questionLists.Add(question);
            });
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            try
            {
                if (this.questionType == "multiple_choice")
                {
                    dynamic question = this.questionLists[this.questionIndex];

                    this.label1.Text = question.Question;

                    this.optionABtn.Text = question.AnswerLists[0];
                    this.optionBBtn.Text = question.AnswerLists[1];
                    this.optionCBtn.Text = question.AnswerLists[2];

                    this.optionABtn.Checked = false;
                    this.optionBBtn.Checked = false;
                    this.optionCBtn.Checked = false;
                }
                else
                {
                    dynamic question = this.questionLists[this.questionIndex];

                    this.label1.Text = question.Question;
                }
            }
            catch (Exception e)
            {
                Dialog.Bug($"{e.Message}");
            }
        }

        private bool CheckAnswer()
        {
            dynamic questionObj = this.questionLists[this.questionIndex];

            if (this.userAnswer == questionObj.CorrectAnswer) return true;
            else return false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Show dialog confirmation popup
            DialogResult confirmation = Dialog.Confirm("Are you sure want to exit the application?");

            // Close application if yes
            if (confirmation == DialogResult.Yes) Application.Exit();
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {

            if (this.questionType == "multiple_choice")
            {
                if (this.optionABtn.Checked || this.optionBBtn.Checked || this.optionCBtn.Checked)
                {
                    bool isAnswerCorrect = CheckAnswer();

                    if (isAnswerCorrect)
                    {
                        Dialog.Info("Jawaban anda benar");
                        this.questionIndex++;

                        if (this.questionIndex != this.questionLists.Count()) LoadQuestion();
                        else
                        {
                            Dialog.Info("Quiz telah selesai");

                            QuizListForm quizListForm = new QuizListForm();
                            this.Close();
                            quizListForm.Show();
                        }
                    }
                    else Dialog.Info("Jawaban anda salah");
                }
                else Dialog.Error("Please select your answer");
            }
            else
            {
                if (this.essayBox.Text == "") Dialog.Error("Please fill the answer!");
                else
                {
                    this.questionIndex++;

                    if (this.questionIndex != this.questionLists.Count()) LoadQuestion();
                    else
                    {

                        Dialog.Info("Quiz telah selesai");

                        QuizListForm quizListForm = new QuizListForm();
                        this.Close();
                        quizListForm.Show();
                    }
                }
            }
        }

        private void optionABtn_CheckedChanged(object sender, EventArgs e)
        {
            this.userAnswer = this.optionABtn.Text;
        }

        private void optionBBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.userAnswer = this.optionBBtn.Text;
        }

        private void optionCBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.userAnswer = this.optionCBtn.Text;
        }
    }
}
