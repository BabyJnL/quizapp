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

namespace quizapp.View
{
    public partial class QuizListForm : Form
    {
        public QuizListForm()
        {
            InitializeComponent();
        }

        private void QuizListForm_Load(object sender, EventArgs e)
        {
            List<Quiz> quizLists = Quiz.GetAll();
            this.quizListTable.DataSource = quizLists;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Show dialog confirmation popup
            DialogResult confirmation = Dialog.Confirm("Are you sure want to exit the application?");

            // Close application if yes
            if (confirmation == DialogResult.Yes) Application.Exit();
        }

        private void createQuizBtn_Click(object sender, EventArgs e)
        {
            CreateQuestionForm createQuizForm = new CreateQuestionForm();
            this.Close();
            createQuizForm.Show();
        }
    }
}
