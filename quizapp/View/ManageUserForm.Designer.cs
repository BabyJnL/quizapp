namespace quizapp.View
{
    partial class ManageUserForm
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
            this.quizListBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.userDataList = new System.Windows.Forms.DataGridView();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.registerUserBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // quizListBtn
            // 
            this.quizListBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quizListBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.quizListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizListBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizListBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quizListBtn.Location = new System.Drawing.Point(722, 527);
            this.quizListBtn.Name = "quizListBtn";
            this.quizListBtn.Size = new System.Drawing.Size(349, 40);
            this.quizListBtn.TabIndex = 7;
            this.quizListBtn.Text = "Quiz List";
            this.quizListBtn.UseVisualStyleBackColor = false;
            this.quizListBtn.Click += new System.EventHandler(this.quizListBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(353, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Quiz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addUserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserBtn.Location = new System.Drawing.Point(-1, 527);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(355, 40);
            this.addUserBtn.TabIndex = 5;
            this.addUserBtn.Text = "Manage User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            // 
            // userDataList
            // 
            this.userDataList.AllowUserToAddRows = false;
            this.userDataList.AllowUserToDeleteRows = false;
            this.userDataList.AllowUserToResizeColumns = false;
            this.userDataList.AllowUserToResizeRows = false;
            this.userDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.userDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userDataList.GridColor = System.Drawing.SystemColors.Control;
            this.userDataList.Location = new System.Drawing.Point(58, 33);
            this.userDataList.MultiSelect = false;
            this.userDataList.Name = "userDataList";
            this.userDataList.RowHeadersVisible = false;
            this.userDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataList.ShowEditingIcon = false;
            this.userDataList.Size = new System.Drawing.Size(819, 271);
            this.userDataList.TabIndex = 8;
            this.userDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataList_CellClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLabel.Location = new System.Drawing.Point(54, 355);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 24);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(173, 355);
            this.usernameInput.MaxLength = 64;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(263, 24);
            this.usernameInput.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(502, 355);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 24);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(614, 355);
            this.passwordInput.MaxLength = 128;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(263, 24);
            this.passwordInput.TabIndex = 12;
            // 
            // registerUserBtn
            // 
            this.registerUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserBtn.Location = new System.Drawing.Point(413, 424);
            this.registerUserBtn.Name = "registerUserBtn";
            this.registerUserBtn.Size = new System.Drawing.Size(123, 29);
            this.registerUserBtn.TabIndex = 13;
            this.registerUserBtn.Text = "Add";
            this.registerUserBtn.UseVisualStyleBackColor = true;
            this.registerUserBtn.Click += new System.EventHandler(this.registerUserBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(1024, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(47, 38);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(930, 177);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 30);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.registerUserBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userDataList);
            this.Controls.Add(this.quizListBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addUserBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.userDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quizListBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.DataGridView userDataList;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button registerUserBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}