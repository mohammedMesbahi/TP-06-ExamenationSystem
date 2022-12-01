
namespace TP_06_ExamenationSystem
{
    partial class CreateExam
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
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.ExamDate = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.textBoxExamTitle = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfQuestions = new System.Windows.Forms.TextBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panelCreatQuestions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBoxProposition4 = new System.Windows.Forms.TextBox();
            this.textBoxProposition3 = new System.Windows.Forms.TextBox();
            this.textBoxProposition2 = new System.Windows.Forms.TextBox();
            this.textBoxProposition1 = new System.Windows.Forms.TextBox();
            this.lblProposition4 = new System.Windows.Forms.Label();
            this.lblProposition3 = new System.Windows.Forms.Label();
            this.lblProposition2 = new System.Windows.Forms.Label();
            this.lblProposition1 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfPropositions = new System.Windows.Forms.Label();
            this.textBoxNumberOfPropositions = new System.Windows.Forms.TextBox();
            this.ListTypeOfQuetions = new System.Windows.Forms.ComboBox();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.panelCreatQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Location = new System.Drawing.Point(134, 71);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(82, 20);
            this.lblExamTitle.TabIndex = 0;
            this.lblExamTitle.Text = "Exam Title";
            // 
            // ExamDate
            // 
            this.ExamDate.AutoSize = true;
            this.ExamDate.Location = new System.Drawing.Point(134, 106);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(88, 20);
            this.ExamDate.TabIndex = 1;
            this.ExamDate.Text = "Exam Date";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(134, 149);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(138, 20);
            this.Duration.TabIndex = 2;
            this.Duration.Text = "Duration (HH:MM)";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(134, 196);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(159, 20);
            this.lblNumberOfQuestion.TabIndex = 3;
            this.lblNumberOfQuestion.Text = "Number of Questions";
            // 
            // textBoxExamTitle
            // 
            this.textBoxExamTitle.Location = new System.Drawing.Point(323, 71);
            this.textBoxExamTitle.Name = "textBoxExamTitle";
            this.textBoxExamTitle.Size = new System.Drawing.Size(300, 26);
            this.textBoxExamTitle.TabIndex = 5;
            // 
            // textBoxNumberOfQuestions
            // 
            this.textBoxNumberOfQuestions.Location = new System.Drawing.Point(323, 196);
            this.textBoxNumberOfQuestions.Name = "textBoxNumberOfQuestions";
            this.textBoxNumberOfQuestions.Size = new System.Drawing.Size(300, 26);
            this.textBoxNumberOfQuestions.TabIndex = 8;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Location = new System.Drawing.Point(323, 106);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(300, 26);
            this.dtpExamDate.TabIndex = 12;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(323, 149);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(300, 26);
            this.textBoxDuration.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 61);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(490, 247);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(135, 61);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // panelCreatQuestions
            // 
            this.panelCreatQuestions.Controls.Add(this.btnNext);
            this.panelCreatQuestions.Controls.Add(this.textBoxProposition4);
            this.panelCreatQuestions.Controls.Add(this.textBoxProposition3);
            this.panelCreatQuestions.Controls.Add(this.textBoxProposition2);
            this.panelCreatQuestions.Controls.Add(this.textBoxProposition1);
            this.panelCreatQuestions.Controls.Add(this.lblProposition4);
            this.panelCreatQuestions.Controls.Add(this.lblProposition3);
            this.panelCreatQuestions.Controls.Add(this.lblProposition2);
            this.panelCreatQuestions.Controls.Add(this.lblProposition1);
            this.panelCreatQuestions.Controls.Add(this.textBoxNote);
            this.panelCreatQuestions.Controls.Add(this.label2);
            this.panelCreatQuestions.Controls.Add(this.textBoxQuestionText);
            this.panelCreatQuestions.Controls.Add(this.label3);
            this.panelCreatQuestions.Controls.Add(this.lblNumberOfPropositions);
            this.panelCreatQuestions.Controls.Add(this.textBoxNumberOfPropositions);
            this.panelCreatQuestions.Controls.Add(this.ListTypeOfQuetions);
            this.panelCreatQuestions.Controls.Add(this.lblQuestionType);
            this.panelCreatQuestions.Controls.Add(this.lblQuestionNumber);
            this.panelCreatQuestions.Controls.Add(this.label1);
            this.panelCreatQuestions.Location = new System.Drawing.Point(0, 0);
            this.panelCreatQuestions.Name = "panelCreatQuestions";
            this.panelCreatQuestions.Size = new System.Drawing.Size(858, 609);
            this.panelCreatQuestions.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Number";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(221, 28);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(18, 20);
            this.lblQuestionNumber.TabIndex = 1;
            this.lblQuestionNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(59, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 47);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBoxProposition4
            // 
            this.textBoxProposition4.Location = new System.Drawing.Point(409, 503);
            this.textBoxProposition4.Name = "textBoxProposition4";
            this.textBoxProposition4.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition4.TabIndex = 36;
            // 
            // textBoxProposition3
            // 
            this.textBoxProposition3.Location = new System.Drawing.Point(409, 453);
            this.textBoxProposition3.Name = "textBoxProposition3";
            this.textBoxProposition3.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition3.TabIndex = 35;
            // 
            // textBoxProposition2
            // 
            this.textBoxProposition2.Location = new System.Drawing.Point(409, 395);
            this.textBoxProposition2.Name = "textBoxProposition2";
            this.textBoxProposition2.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition2.TabIndex = 34;
            // 
            // textBoxProposition1
            // 
            this.textBoxProposition1.Location = new System.Drawing.Point(409, 341);
            this.textBoxProposition1.Name = "textBoxProposition1";
            this.textBoxProposition1.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition1.TabIndex = 33;
            // 
            // lblProposition4
            // 
            this.lblProposition4.AutoSize = true;
            this.lblProposition4.Location = new System.Drawing.Point(255, 506);
            this.lblProposition4.Name = "lblProposition4";
            this.lblProposition4.Size = new System.Drawing.Size(97, 20);
            this.lblProposition4.TabIndex = 32;
            this.lblProposition4.Text = "Proposition4";
            // 
            // lblProposition3
            // 
            this.lblProposition3.AutoSize = true;
            this.lblProposition3.Location = new System.Drawing.Point(255, 456);
            this.lblProposition3.Name = "lblProposition3";
            this.lblProposition3.Size = new System.Drawing.Size(97, 20);
            this.lblProposition3.TabIndex = 31;
            this.lblProposition3.Text = "Proposition3";
            // 
            // lblProposition2
            // 
            this.lblProposition2.AutoSize = true;
            this.lblProposition2.Location = new System.Drawing.Point(255, 401);
            this.lblProposition2.Name = "lblProposition2";
            this.lblProposition2.Size = new System.Drawing.Size(97, 20);
            this.lblProposition2.TabIndex = 30;
            this.lblProposition2.Text = "Proposition2";
            // 
            // lblProposition1
            // 
            this.lblProposition1.AutoSize = true;
            this.lblProposition1.Location = new System.Drawing.Point(255, 348);
            this.lblProposition1.Name = "lblProposition1";
            this.lblProposition1.Size = new System.Drawing.Size(97, 20);
            this.lblProposition1.TabIndex = 29;
            this.lblProposition1.Text = "Proposition1";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(259, 265);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(394, 26);
            this.textBoxNote.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "NOTE";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Location = new System.Drawing.Point(259, 198);
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(394, 26);
            this.textBoxQuestionText.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Question Text";
            // 
            // lblNumberOfPropositions
            // 
            this.lblNumberOfPropositions.AutoSize = true;
            this.lblNumberOfPropositions.Location = new System.Drawing.Point(62, 137);
            this.lblNumberOfPropositions.Name = "lblNumberOfPropositions";
            this.lblNumberOfPropositions.Size = new System.Drawing.Size(177, 20);
            this.lblNumberOfPropositions.TabIndex = 24;
            this.lblNumberOfPropositions.Text = "Number Of Propositions";
            // 
            // textBoxNumberOfPropositions
            // 
            this.textBoxNumberOfPropositions.Location = new System.Drawing.Point(259, 137);
            this.textBoxNumberOfPropositions.Name = "textBoxNumberOfPropositions";
            this.textBoxNumberOfPropositions.Size = new System.Drawing.Size(394, 26);
            this.textBoxNumberOfPropositions.TabIndex = 23;
            // 
            // ListTypeOfQuetions
            // 
            this.ListTypeOfQuetions.FormattingEnabled = true;
            this.ListTypeOfQuetions.Items.AddRange(new object[] {
            "QCM",
            "Qestion Dichotomique",
            "Qestion Overt"});
            this.ListTypeOfQuetions.Location = new System.Drawing.Point(259, 71);
            this.ListTypeOfQuetions.Name = "ListTypeOfQuetions";
            this.ListTypeOfQuetions.Size = new System.Drawing.Size(394, 28);
            this.ListTypeOfQuetions.TabIndex = 22;
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(62, 71);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(111, 20);
            this.lblQuestionType.TabIndex = 21;
            this.lblQuestionType.Text = "Question Type";
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 609);
            this.Controls.Add(this.panelCreatQuestions);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.textBoxNumberOfQuestions);
            this.Controls.Add(this.textBoxExamTitle);
            this.Controls.Add(this.lblNumberOfQuestion);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.ExamDate);
            this.Controls.Add(this.lblExamTitle);
            this.Name = "CreateExam";
            this.Text = "CreateExam";
            this.Load += new System.EventHandler(this.CreateExam_Load);
            this.panelCreatQuestions.ResumeLayout(false);
            this.panelCreatQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblExamTitle;
        public System.Windows.Forms.Label ExamDate;
        public System.Windows.Forms.Label Duration;
        public System.Windows.Forms.Label lblNumberOfQuestion;
        public System.Windows.Forms.TextBox textBoxExamTitle;
        public System.Windows.Forms.TextBox textBoxNumberOfQuestions;
        public System.Windows.Forms.DateTimePicker dtpExamDate;
        public System.Windows.Forms.TextBox textBoxDuration;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel panelCreatQuestions;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBoxProposition4;
        private System.Windows.Forms.TextBox textBoxProposition3;
        private System.Windows.Forms.TextBox textBoxProposition2;
        private System.Windows.Forms.TextBox textBoxProposition1;
        private System.Windows.Forms.Label lblProposition4;
        private System.Windows.Forms.Label lblProposition3;
        private System.Windows.Forms.Label lblProposition2;
        private System.Windows.Forms.Label lblProposition1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfPropositions;
        private System.Windows.Forms.TextBox textBoxNumberOfPropositions;
        private System.Windows.Forms.ComboBox ListTypeOfQuetions;
        private System.Windows.Forms.Label lblQuestionType;
    }
}