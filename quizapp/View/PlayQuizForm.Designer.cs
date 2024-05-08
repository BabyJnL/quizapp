namespace quizapp.View
{
    partial class PlayQuizForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.essayBox = new System.Windows.Forms.RichTextBox();
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.optionCBtn = new System.Windows.Forms.RadioButton();
            this.optionBBtn = new System.Windows.Forms.RadioButton();
            this.optionABtn = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.questionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.MaximumSize = new System.Drawing.Size(900, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.essayBox);
            this.questionBox.Controls.Add(this.nextQuestionBtn);
            this.questionBox.Controls.Add(this.optionCBtn);
            this.questionBox.Controls.Add(this.optionBBtn);
            this.questionBox.Controls.Add(this.optionABtn);
            this.questionBox.Controls.Add(this.label1);
            this.questionBox.Location = new System.Drawing.Point(29, 61);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(1009, 464);
            this.questionBox.TabIndex = 1;
            this.questionBox.TabStop = false;
            // 
            // essayBox
            // 
            this.essayBox.Location = new System.Drawing.Point(58, 150);
            this.essayBox.Name = "essayBox";
            this.essayBox.Size = new System.Drawing.Size(896, 166);
            this.essayBox.TabIndex = 5;
            this.essayBox.Text = "";
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Location = new System.Drawing.Point(453, 379);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(141, 32);
            this.nextQuestionBtn.TabIndex = 4;
            this.nextQuestionBtn.Text = "Next >";
            this.nextQuestionBtn.UseVisualStyleBackColor = true;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // optionCBtn
            // 
            this.optionCBtn.AutoSize = true;
            this.optionCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.optionCBtn.Location = new System.Drawing.Point(58, 252);
            this.optionCBtn.Name = "optionCBtn";
            this.optionCBtn.Size = new System.Drawing.Size(14, 13);
            this.optionCBtn.TabIndex = 3;
            this.optionCBtn.TabStop = true;
            this.optionCBtn.UseVisualStyleBackColor = true;
            this.optionCBtn.CheckedChanged += new System.EventHandler(this.optionCBtn_CheckedChanged);
            // 
            // optionBBtn
            // 
            this.optionBBtn.AutoSize = true;
            this.optionBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.optionBBtn.Location = new System.Drawing.Point(58, 200);
            this.optionBBtn.Name = "optionBBtn";
            this.optionBBtn.Size = new System.Drawing.Size(14, 13);
            this.optionBBtn.TabIndex = 2;
            this.optionBBtn.TabStop = true;
            this.optionBBtn.UseVisualStyleBackColor = true;
            this.optionBBtn.CheckedChanged += new System.EventHandler(this.optionBBtn_CheckedChanged);
            // 
            // optionABtn
            // 
            this.optionABtn.AutoSize = true;
            this.optionABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionABtn.ForeColor = System.Drawing.SystemColors.Control;
            this.optionABtn.Location = new System.Drawing.Point(58, 149);
            this.optionABtn.Name = "optionABtn";
            this.optionABtn.Size = new System.Drawing.Size(14, 13);
            this.optionABtn.TabIndex = 1;
            this.optionABtn.TabStop = true;
            this.optionABtn.UseVisualStyleBackColor = true;
            this.optionABtn.CheckedChanged += new System.EventHandler(this.optionABtn_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(1024, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(47, 38);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // PlayQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.questionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayQuizForm";
            this.questionBox.ResumeLayout(false);
            this.questionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.Button nextQuestionBtn;
        private System.Windows.Forms.RadioButton optionCBtn;
        private System.Windows.Forms.RadioButton optionBBtn;
        private System.Windows.Forms.RadioButton optionABtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RichTextBox essayBox;
    }
}