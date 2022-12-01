
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.ListTypeOfQuetions.Size = new System.Drawing.Size(206, 28);
            this.ListTypeOfQuetions.TabIndex = 1;
            // 
            // textBoxNumberOfPropositions
            // 
            this.textBoxNumberOfPropositions.Location = new System.Drawing.Point(248, 112);
            this.textBoxNumberOfPropositions.Name = "textBoxNumberOfPropositions";
            this.textBoxNumberOfPropositions.Size = new System.Drawing.Size(206, 26);
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
            this.textBoxQuestionText.Size = new System.Drawing.Size(206, 26);
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
            this.textBoxNote.Size = new System.Drawing.Size(206, 26);
            this.textBoxNote.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // CreateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
