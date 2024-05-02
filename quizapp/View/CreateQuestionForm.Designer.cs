namespace quizapp.View
{
    partial class CreateQuestionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.quizDetailBox = new System.Windows.Forms.GroupBox();
            this.createQuizBtn = new System.Windows.Forms.Button();
            this.quizCategoryList = new System.Windows.Forms.ListBox();
            this.quizCategoryLabel = new System.Windows.Forms.Label();
            this.quizTypeList = new System.Windows.Forms.ListBox();
            this.quizTypeLabel = new System.Windows.Forms.Label();
            this.quizNameInput = new System.Windows.Forms.TextBox();
            this.quizTitleLabel = new System.Windows.Forms.Label();
            this.addQuestionBox = new System.Windows.Forms.GroupBox();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.optionCInput = new System.Windows.Forms.TextBox();
            this.optionBInput = new System.Windows.Forms.TextBox();
            this.optionAInput = new System.Windows.Forms.TextBox();
            this.optionCCheckBox = new System.Windows.Forms.CheckBox();
            this.optionBCheckBox = new System.Windows.Forms.CheckBox();
            this.optionACheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionNameInput = new System.Windows.Forms.RichTextBox();
            this.questionNameLabel = new System.Windows.Forms.Label();
            this.quizSelectionList = new System.Windows.Forms.ListBox();
            this.quizSelectionLabel = new System.Windows.Forms.Label();
            this.quizDetailBox.SuspendLayout();
            this.addQuestionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Quiz";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(354, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create Quiz";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(723, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 40);
            this.button3.TabIndex = 4;
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
            this.exitBtn.Location = new System.Drawing.Point(1025, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(47, 38);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // quizDetailBox
            // 
            this.quizDetailBox.Controls.Add(this.createQuizBtn);
            this.quizDetailBox.Controls.Add(this.quizCategoryList);
            this.quizDetailBox.Controls.Add(this.quizCategoryLabel);
            this.quizDetailBox.Controls.Add(this.quizTypeList);
            this.quizDetailBox.Controls.Add(this.quizTypeLabel);
            this.quizDetailBox.Controls.Add(this.quizNameInput);
            this.quizDetailBox.Controls.Add(this.quizTitleLabel);
            this.quizDetailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizDetailBox.Location = new System.Drawing.Point(34, 73);
            this.quizDetailBox.Name = "quizDetailBox";
            this.quizDetailBox.Size = new System.Drawing.Size(481, 410);
            this.quizDetailBox.TabIndex = 6;
            this.quizDetailBox.TabStop = false;
            this.quizDetailBox.Text = "Quiz Detail";
            // 
            // createQuizBtn
            // 
            this.createQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuizBtn.Location = new System.Drawing.Point(209, 361);
            this.createQuizBtn.Name = "createQuizBtn";
            this.createQuizBtn.Size = new System.Drawing.Size(103, 24);
            this.createQuizBtn.TabIndex = 6;
            this.createQuizBtn.Text = "Create";
            this.createQuizBtn.UseVisualStyleBackColor = true;
            this.createQuizBtn.Click += new System.EventHandler(this.createQuizBtn_Click);
            // 
            // quizCategoryList
            // 
            this.quizCategoryList.FormattingEnabled = true;
            this.quizCategoryList.ItemHeight = 20;
            this.quizCategoryList.Items.AddRange(new object[] {
            "C",
            "C#",
            "C++",
            "Javascript",
            "PHP",
            "Python"});
            this.quizCategoryList.Location = new System.Drawing.Point(135, 201);
            this.quizCategoryList.Name = "quizCategoryList";
            this.quizCategoryList.Size = new System.Drawing.Size(303, 104);
            this.quizCategoryList.Sorted = true;
            this.quizCategoryList.TabIndex = 5;
            // 
            // quizCategoryLabel
            // 
            this.quizCategoryLabel.AutoSize = true;
            this.quizCategoryLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.quizCategoryLabel.Location = new System.Drawing.Point(29, 247);
            this.quizCategoryLabel.Name = "quizCategoryLabel";
            this.quizCategoryLabel.Size = new System.Drawing.Size(77, 20);
            this.quizCategoryLabel.TabIndex = 4;
            this.quizCategoryLabel.Text = "Category:";
            // 
            // quizTypeList
            // 
            this.quizTypeList.FormattingEnabled = true;
            this.quizTypeList.ItemHeight = 20;
            this.quizTypeList.Items.AddRange(new object[] {
            "Essay",
            "Multiple Choice"});
            this.quizTypeList.Location = new System.Drawing.Point(135, 113);
            this.quizTypeList.Name = "quizTypeList";
            this.quizTypeList.Size = new System.Drawing.Size(303, 44);
            this.quizTypeList.Sorted = true;
            this.quizTypeList.TabIndex = 3;
            // 
            // quizTypeLabel
            // 
            this.quizTypeLabel.AutoSize = true;
            this.quizTypeLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.quizTypeLabel.Location = new System.Drawing.Point(29, 116);
            this.quizTypeLabel.Name = "quizTypeLabel";
            this.quizTypeLabel.Size = new System.Drawing.Size(47, 20);
            this.quizTypeLabel.TabIndex = 2;
            this.quizTypeLabel.Text = "Type:";
            // 
            // quizNameInput
            // 
            this.quizNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quizNameInput.Location = new System.Drawing.Point(135, 53);
            this.quizNameInput.Name = "quizNameInput";
            this.quizNameInput.Size = new System.Drawing.Size(303, 19);
            this.quizNameInput.TabIndex = 1;
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.quizTitleLabel.Location = new System.Drawing.Point(29, 52);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(42, 20);
            this.quizTitleLabel.TabIndex = 0;
            this.quizTitleLabel.Text = "Title:";
            // 
            // addQuestionBox
            // 
            this.addQuestionBox.Controls.Add(this.addQuestionBtn);
            this.addQuestionBox.Controls.Add(this.optionCInput);
            this.addQuestionBox.Controls.Add(this.optionBInput);
            this.addQuestionBox.Controls.Add(this.optionAInput);
            this.addQuestionBox.Controls.Add(this.optionCCheckBox);
            this.addQuestionBox.Controls.Add(this.optionBCheckBox);
            this.addQuestionBox.Controls.Add(this.optionACheckBox);
            this.addQuestionBox.Controls.Add(this.label1);
            this.addQuestionBox.Controls.Add(this.questionNameInput);
            this.addQuestionBox.Controls.Add(this.questionNameLabel);
            this.addQuestionBox.Controls.Add(this.quizSelectionList);
            this.addQuestionBox.Controls.Add(this.quizSelectionLabel);
            this.addQuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionBox.Location = new System.Drawing.Point(556, 73);
            this.addQuestionBox.Name = "addQuestionBox";
            this.addQuestionBox.Size = new System.Drawing.Size(481, 410);
            this.addQuestionBox.TabIndex = 7;
            this.addQuestionBox.TabStop = false;
            this.addQuestionBox.Text = "Add Question";
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionBtn.Location = new System.Drawing.Point(186, 361);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(103, 24);
            this.addQuestionBtn.TabIndex = 14;
            this.addQuestionBtn.Text = "Add";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // optionCInput
            // 
            this.optionCInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionCInput.Location = new System.Drawing.Point(176, 300);
            this.optionCInput.Name = "optionCInput";
            this.optionCInput.Size = new System.Drawing.Size(273, 26);
            this.optionCInput.TabIndex = 13;
            // 
            // optionBInput
            // 
            this.optionBInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionBInput.Location = new System.Drawing.Point(176, 262);
            this.optionBInput.Name = "optionBInput";
            this.optionBInput.Size = new System.Drawing.Size(273, 26);
            this.optionBInput.TabIndex = 12;
            // 
            // optionAInput
            // 
            this.optionAInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionAInput.Location = new System.Drawing.Point(176, 225);
            this.optionAInput.Name = "optionAInput";
            this.optionAInput.Size = new System.Drawing.Size(273, 26);
            this.optionAInput.TabIndex = 11;
            // 
            // optionCCheckBox
            // 
            this.optionCCheckBox.AutoSize = true;
            this.optionCCheckBox.Location = new System.Drawing.Point(146, 307);
            this.optionCCheckBox.Name = "optionCCheckBox";
            this.optionCCheckBox.Size = new System.Drawing.Size(15, 14);
            this.optionCCheckBox.TabIndex = 10;
            this.optionCCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionBCheckBox
            // 
            this.optionBCheckBox.AutoSize = true;
            this.optionBCheckBox.Location = new System.Drawing.Point(146, 271);
            this.optionBCheckBox.Name = "optionBCheckBox";
            this.optionBCheckBox.Size = new System.Drawing.Size(15, 14);
            this.optionBCheckBox.TabIndex = 9;
            this.optionBCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionACheckBox
            // 
            this.optionACheckBox.AutoSize = true;
            this.optionACheckBox.Location = new System.Drawing.Point(146, 232);
            this.optionACheckBox.Name = "optionACheckBox";
            this.optionACheckBox.Size = new System.Drawing.Size(15, 14);
            this.optionACheckBox.TabIndex = 8;
            this.optionACheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(29, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Answer:";
            // 
            // questionNameInput
            // 
            this.questionNameInput.Location = new System.Drawing.Point(146, 113);
            this.questionNameInput.Name = "questionNameInput";
            this.questionNameInput.Size = new System.Drawing.Size(303, 84);
            this.questionNameInput.TabIndex = 6;
            this.questionNameInput.Text = "";
            // 
            // questionNameLabel
            // 
            this.questionNameLabel.AutoSize = true;
            this.questionNameLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.questionNameLabel.Location = new System.Drawing.Point(29, 145);
            this.questionNameLabel.Name = "questionNameLabel";
            this.questionNameLabel.Size = new System.Drawing.Size(55, 20);
            this.questionNameLabel.TabIndex = 5;
            this.questionNameLabel.Text = "Name:";
            // 
            // quizSelectionList
            // 
            this.quizSelectionList.FormattingEnabled = true;
            this.quizSelectionList.ItemHeight = 20;
            this.quizSelectionList.Location = new System.Drawing.Point(146, 38);
            this.quizSelectionList.Name = "quizSelectionList";
            this.quizSelectionList.Size = new System.Drawing.Size(303, 44);
            this.quizSelectionList.Sorted = true;
            this.quizSelectionList.TabIndex = 4;
            // 
            // quizSelectionLabel
            // 
            this.quizSelectionLabel.AutoSize = true;
            this.quizSelectionLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.quizSelectionLabel.Location = new System.Drawing.Point(29, 52);
            this.quizSelectionLabel.Name = "quizSelectionLabel";
            this.quizSelectionLabel.Size = new System.Drawing.Size(94, 20);
            this.quizSelectionLabel.TabIndex = 1;
            this.quizSelectionLabel.Text = "Select Quiz:";
            // 
            // CreateQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.addQuestionBox);
            this.Controls.Add(this.quizDetailBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuestionForm";
            this.quizDetailBox.ResumeLayout(false);
            this.quizDetailBox.PerformLayout();
            this.addQuestionBox.ResumeLayout(false);
            this.addQuestionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox quizDetailBox;
        private System.Windows.Forms.GroupBox addQuestionBox;
        private System.Windows.Forms.TextBox quizNameInput;
        private System.Windows.Forms.Label quizTitleLabel;
        private System.Windows.Forms.Label quizTypeLabel;
        private System.Windows.Forms.ListBox quizTypeList;
        private System.Windows.Forms.Label quizCategoryLabel;
        private System.Windows.Forms.ListBox quizCategoryList;
        private System.Windows.Forms.Button createQuizBtn;
        private System.Windows.Forms.Label quizSelectionLabel;
        private System.Windows.Forms.ListBox quizSelectionList;
        private System.Windows.Forms.Label questionNameLabel;
        private System.Windows.Forms.RichTextBox questionNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox optionACheckBox;
        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.TextBox optionCInput;
        private System.Windows.Forms.TextBox optionBInput;
        private System.Windows.Forms.TextBox optionAInput;
        private System.Windows.Forms.CheckBox optionCCheckBox;
        private System.Windows.Forms.CheckBox optionBCheckBox;
    }
}