namespace quizapp.View
{
    partial class QuizListForm
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
            this.manageUserBtn = new System.Windows.Forms.Button();
            this.createQuizBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.quizListTable = new System.Windows.Forms.DataGridView();
            this.deleteQuizBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quizListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // manageUserBtn
            // 
            this.manageUserBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.manageUserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.manageUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUserBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageUserBtn.Location = new System.Drawing.Point(-1, 528);
            this.manageUserBtn.Name = "manageUserBtn";
            this.manageUserBtn.Size = new System.Drawing.Size(355, 40);
            this.manageUserBtn.TabIndex = 8;
            this.manageUserBtn.Text = "Manage User";
            this.manageUserBtn.UseVisualStyleBackColor = false;
            this.manageUserBtn.Click += new System.EventHandler(this.manageUserBtn_Click);
            // 
            // createQuizBtn
            // 
            this.createQuizBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createQuizBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.createQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createQuizBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuizBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.createQuizBtn.Location = new System.Drawing.Point(353, 528);
            this.createQuizBtn.Name = "createQuizBtn";
            this.createQuizBtn.Size = new System.Drawing.Size(375, 40);
            this.createQuizBtn.TabIndex = 9;
            this.createQuizBtn.Text = "Create Quiz";
            this.createQuizBtn.UseVisualStyleBackColor = false;
            this.createQuizBtn.Click += new System.EventHandler(this.createQuizBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(722, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Quiz List";
            this.button3.UseVisualStyleBackColor = false;
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
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // quizListTable
            // 
            this.quizListTable.AllowUserToAddRows = false;
            this.quizListTable.AllowUserToDeleteRows = false;
            this.quizListTable.AllowUserToResizeColumns = false;
            this.quizListTable.AllowUserToResizeRows = false;
            this.quizListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.quizListTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.quizListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizListTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.quizListTable.Location = new System.Drawing.Point(55, 92);
            this.quizListTable.MultiSelect = false;
            this.quizListTable.Name = "quizListTable";
            this.quizListTable.RowHeadersVisible = false;
            this.quizListTable.RowHeadersWidth = 51;
            this.quizListTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.quizListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.quizListTable.ShowEditingIcon = false;
            this.quizListTable.Size = new System.Drawing.Size(838, 361);
            this.quizListTable.TabIndex = 12;
            this.quizListTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.quizListTable_CellMouseClick);
            // 
            // deleteQuizBtn
            // 
            this.deleteQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuizBtn.Location = new System.Drawing.Point(935, 300);
            this.deleteQuizBtn.Name = "deleteQuizBtn";
            this.deleteQuizBtn.Size = new System.Drawing.Size(93, 30);
            this.deleteQuizBtn.TabIndex = 13;
            this.deleteQuizBtn.Text = "Delete";
            this.deleteQuizBtn.UseVisualStyleBackColor = true;
            this.deleteQuizBtn.Click += new System.EventHandler(this.deleteQuizBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(935, 241);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(93, 30);
            this.playBtn.TabIndex = 14;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // QuizListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.deleteQuizBtn);
            this.Controls.Add(this.quizListTable);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createQuizBtn);
            this.Controls.Add(this.manageUserBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizListForm";
            this.Load += new System.EventHandler(this.QuizListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageUserBtn;
        private System.Windows.Forms.Button createQuizBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView quizListTable;
        private System.Windows.Forms.Button deleteQuizBtn;
        private System.Windows.Forms.Button playBtn;
    }
}