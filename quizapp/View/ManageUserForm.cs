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
    public partial class ManageUserForm : Form
    {
        private int _selectedUserId = -1;
        public ManageUserForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            List<User> users = User.GetAll();

            this.userDataList.DataSource = users;
            this.userDataList.ClearSelection();
        }

        private void ReloadUserData()
        {
            this.userDataList.DataSource = null;
            LoadUserData();
        }

        private void registerUserBtn_Click(object sender, EventArgs e)
        {
            if (this.usernameInput.Text != "" && this.passwordInput.Text != "")
            {
                new User(this.usernameInput.Text, this.passwordInput.Text).Save();
                ReloadUserData();
            }
            else Dialog.Error("Please fill username and password!");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Show dialog confirmation popup
            DialogResult confirmation = Dialog.Confirm("Are you sure want to exit the application?");

            // Close application if yes
            if (confirmation == DialogResult.Yes) Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateQuestionForm createQuizForm = new CreateQuestionForm();
            this.Close();
            createQuizForm.Show();
        }

        private void quizListBtn_Click(object sender, EventArgs e)
        {
            QuizListForm quizListForm = new QuizListForm();
            this.Close();
            quizListForm.Show();
        }

        private void userDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIdx = this.userDataList.CurrentCell.RowIndex;
            this._selectedUserId = (int)this.userDataList.Rows[rowIdx].Cells[0].Value;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this._selectedUserId != -1)
            {
                User.Remove(this._selectedUserId);
                ReloadUserData();
            }
            else Dialog.Error("Please select the user to remove from table");
        }
    }
}
