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
        private int quizId = -1;
        public QuizListForm()
        {
            InitializeComponent();
        }

        // Methods
        private void LoadQuizzes()
        {
            List<Quiz> quizLists = Quiz.GetAll();
            this.quizListTable.DataSource = quizLists;

            this.quizListTable.ClearSelection();
        }
        private void ReloadQuizzes()
        {
            this.quizListTable.DataSource = null;
            LoadQuizzes();
        }

        private void QuizListForm_Load(object sender, EventArgs e)
        {
            LoadQuizzes();
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

        private void quizListTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView table = (DataGridView)sender;
            int idx = table.SelectedRows[0].Index;
            this.quizId = (int)this.quizListTable.Rows[idx].Cells[0].Value;

            Console.WriteLine(this.quizId);
        }

        private void deleteQuizBtn_Click(object sender, EventArgs e)
        {
            if (this.quizId != -1)
            {
                DialogResult confirmation = Dialog.Confirm($"Are you sure want to delete Quiz id {this.quizId}?");
                if (confirmation == DialogResult.Yes)
                {
                    Quiz.Delete(this.quizId);
                    ReloadQuizzes();
                }
            }
            else Dialog.Error("You need to select the quiz from the lists");
        }
    }
}
