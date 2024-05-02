using quizapp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Show dialog confirmation popup
            DialogResult confirmation = Dialog.Confirm("Are you sure want to exit the application?");
            //DialogResult confirmation = MessageBox.Show(, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Close application if yes
            if (confirmation == DialogResult.Yes) Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (this.usernameInput.Text == "" || this.passwordInput.Text == "") Dialog.Error("Please fill username and your password");
            else
            {
                bool authenticated = User.Auth(this.usernameInput.Text, this.passwordInput.Text);

                if (authenticated)
                {
                    Dialog.Info("You've logged in");
                    CreateQuestionForm questionForm = new CreateQuestionForm();
                    this.Hide();
                    questionForm.Show();
                }
                else Dialog.Error("Invalid credential");
            }
        }
    }
}
