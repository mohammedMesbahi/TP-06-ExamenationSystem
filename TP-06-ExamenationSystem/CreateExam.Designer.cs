
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
            this.createQuestions1 = new TP_06_ExamenationSystem.CreateQuestions();
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
            // createQuestions1
            // 
            this.createQuestions1.Location = new System.Drawing.Point(-2, -4);
            this.createQuestions1.Name = "createQuestions1";
            this.createQuestions1.Size = new System.Drawing.Size(801, 455);
            this.createQuestions1.TabIndex = 16;
            this.createQuestions1.Visible = false;
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createQuestions1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label ExamDate;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.TextBox textBoxExamTitle;
        private System.Windows.Forms.TextBox textBoxNumberOfQuestions;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
        private CreateQuestions createQuestions1;
    }
}