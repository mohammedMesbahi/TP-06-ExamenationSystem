
namespace TP_06_ExamenationSystem
{
    partial class CreateQuestions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.ListTypeOfQuetions = new System.Windows.Forms.ComboBox();
            this.textBoxNumberOfPropositions = new System.Windows.Forms.TextBox();
            this.lblNumberOfPropositions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.lblProposition1 = new System.Windows.Forms.Label();
            this.lblProposition2 = new System.Windows.Forms.Label();
            this.lblProposition3 = new System.Windows.Forms.Label();
            this.lblProposition4 = new System.Windows.Forms.Label();
            this.textBoxProposition1 = new System.Windows.Forms.TextBox();
            this.textBoxProposition2 = new System.Windows.Forms.TextBox();
            this.textBoxProposition3 = new System.Windows.Forms.TextBox();
            this.textBoxProposition4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(51, 46);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(111, 20);
            this.lblQuestionType.TabIndex = 0;
            this.lblQuestionType.Text = "Question Type";
            // 
            // ListTypeOfQuetions
            // 
            this.ListTypeOfQuetions.FormattingEnabled = true;
            this.ListTypeOfQuetions.Items.AddRange(new object[] {
            "QCM",
            "Qestion Dichotomique",
            "Qestion Overt"});
            this.ListTypeOfQuetions.Location = new System.Drawing.Point(248, 46);
            this.ListTypeOfQuetions.Name = "ListTypeOfQuetions";
            this.ListTypeOfQuetions.Size = new System.Drawing.Size(394, 28);
            this.ListTypeOfQuetions.TabIndex = 1;
            // 
            // textBoxNumberOfPropositions
            // 
            this.textBoxNumberOfPropositions.Location = new System.Drawing.Point(248, 112);
            this.textBoxNumberOfPropositions.Name = "textBoxNumberOfPropositions";
            this.textBoxNumberOfPropositions.Size = new System.Drawing.Size(394, 26);
            this.textBoxNumberOfPropositions.TabIndex = 2;
            this.textBoxNumberOfPropositions.TextChanged += new System.EventHandler(this.textBoxNumberOfPropositions_TextChanged);
            // 
            // lblNumberOfPropositions
            // 
            this.lblNumberOfPropositions.AutoSize = true;
            this.lblNumberOfPropositions.Location = new System.Drawing.Point(51, 112);
            this.lblNumberOfPropositions.Name = "lblNumberOfPropositions";
            this.lblNumberOfPropositions.Size = new System.Drawing.Size(177, 20);
            this.lblNumberOfPropositions.TabIndex = 3;
            this.lblNumberOfPropositions.Text = "Number Of Propositions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Question Text";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Location = new System.Drawing.Point(248, 173);
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(394, 26);
            this.textBoxQuestionText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOTE";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(248, 240);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(394, 26);
            this.textBoxNote.TabIndex = 7;
            // 
            // lblProposition1
            // 
            this.lblProposition1.AutoSize = true;
            this.lblProposition1.Location = new System.Drawing.Point(244, 323);
            this.lblProposition1.Name = "lblProposition1";
            this.lblProposition1.Size = new System.Drawing.Size(97, 20);
            this.lblProposition1.TabIndex = 8;
            this.lblProposition1.Text = "Proposition1";
            // 
            // lblProposition2
            // 
            this.lblProposition2.AutoSize = true;
            this.lblProposition2.Location = new System.Drawing.Point(244, 376);
            this.lblProposition2.Name = "lblProposition2";
            this.lblProposition2.Size = new System.Drawing.Size(97, 20);
            this.lblProposition2.TabIndex = 9;
            this.lblProposition2.Text = "Proposition2";
            // 
            // lblProposition3
            // 
            this.lblProposition3.AutoSize = true;
            this.lblProposition3.Location = new System.Drawing.Point(244, 431);
            this.lblProposition3.Name = "lblProposition3";
            this.lblProposition3.Size = new System.Drawing.Size(97, 20);
            this.lblProposition3.TabIndex = 10;
            this.lblProposition3.Text = "Proposition3";
            // 
            // lblProposition4
            // 
            this.lblProposition4.AutoSize = true;
            this.lblProposition4.Location = new System.Drawing.Point(244, 481);
            this.lblProposition4.Name = "lblProposition4";
            this.lblProposition4.Size = new System.Drawing.Size(97, 20);
            this.lblProposition4.TabIndex = 11;
            this.lblProposition4.Text = "Proposition4";
            // 
            // textBoxProposition1
            // 
            this.textBoxProposition1.Location = new System.Drawing.Point(398, 316);
            this.textBoxProposition1.Name = "textBoxProposition1";
            this.textBoxProposition1.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition1.TabIndex = 12;
            // 
            // textBoxProposition2
            // 
            this.textBoxProposition2.Location = new System.Drawing.Point(398, 370);
            this.textBoxProposition2.Name = "textBoxProposition2";
            this.textBoxProposition2.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition2.TabIndex = 13;
            // 
            // textBoxProposition3
            // 
            this.textBoxProposition3.Location = new System.Drawing.Point(398, 428);
            this.textBoxProposition3.Name = "textBoxProposition3";
            this.textBoxProposition3.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition3.TabIndex = 14;
            // 
            // textBoxProposition4
            // 
            this.textBoxProposition4.Location = new System.Drawing.Point(398, 478);
            this.textBoxProposition4.Name = "textBoxProposition4";
            this.textBoxProposition4.Size = new System.Drawing.Size(244, 26);
            this.textBoxProposition4.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Question N°";
            // 
            // lblCurrentNumber
            // 
            this.lblCurrentNumber.AutoSize = true;
            this.lblCurrentNumber.Location = new System.Drawing.Point(106, 12);
            this.lblCurrentNumber.Name = "lblCurrentNumber";
            this.lblCurrentNumber.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentNumber.TabIndex = 18;
            this.lblCurrentNumber.Text = "1";
            // 
            // CreateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxProposition4);
            this.Controls.Add(this.textBoxProposition3);
            this.Controls.Add(this.textBoxProposition2);
            this.Controls.Add(this.textBoxProposition1);
            this.Controls.Add(this.lblProposition4);
            this.Controls.Add(this.lblProposition3);
            this.Controls.Add(this.lblProposition2);
            this.Controls.Add(this.lblProposition1);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuestionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumberOfPropositions);
            this.Controls.Add(this.textBoxNumberOfPropositions);
            this.Controls.Add(this.ListTypeOfQuetions);
            this.Controls.Add(this.lblQuestionType);
            this.Name = "CreateQuestions";
            this.Size = new System.Drawing.Size(788, 540);
            this.Load += new System.EventHandler(this.CreateQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.ComboBox ListTypeOfQuetions;
        private System.Windows.Forms.TextBox textBoxNumberOfPropositions;
        private System.Windows.Forms.Label lblNumberOfPropositions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label lblProposition1;
        private System.Windows.Forms.Label lblProposition2;
        private System.Windows.Forms.Label lblProposition3;
        private System.Windows.Forms.Label lblProposition4;
        private System.Windows.Forms.TextBox textBoxProposition1;
        private System.Windows.Forms.TextBox textBoxProposition2;
        private System.Windows.Forms.TextBox textBoxProposition3;
        private System.Windows.Forms.TextBox textBoxProposition4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentNumber;
    }
}
