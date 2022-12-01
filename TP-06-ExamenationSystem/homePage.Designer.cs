
namespace TP_06_ExamenationSystem
{
    partial class homePage
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
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.btnPassExam = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(193, 89);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(193, 112);
            this.btnCreateExam.TabIndex = 0;
            this.btnCreateExam.Text = "Creat Exam";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCrealeExam_Click);
            // 
            // btnPassExam
            // 
            this.btnPassExam.Location = new System.Drawing.Point(396, 89);
            this.btnPassExam.Name = "btnPassExam";
            this.btnPassExam.Size = new System.Drawing.Size(193, 112);
            this.btnPassExam.TabIndex = 1;
            this.btnPassExam.Text = "Pass Exam";
            this.btnPassExam.UseVisualStyleBackColor = true;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(193, 219);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(193, 112);
            this.btnShowResults.TabIndex = 2;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(396, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 112);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.btnPassExam);
            this.Controls.Add(this.btnCreateExam);
            this.Name = "homePage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Button btnPassExam;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Button button4;
    }
}

