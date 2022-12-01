using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_06_ExamenationSystem
{
    public partial class CreateExam : Form
    {
        
        public CreateExam()
        {
            InitializeComponent();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new homePage();
        }

        public void btnContinue_Click(object sender, EventArgs e)
        {
            panelCreatQuestions.Show();
        }

        public void CreateExam_Load(object sender, EventArgs e)
        {
            panelCreatQuestions.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int counter = int.Parse(lblQuestionNumber.Text) +1;
            lblQuestionNumber.Text = counter.ToString();
            // here i will insert in the dataBase
            hidePropositions();
            clearPropositions();

        }
        public void hidePropositions()
        {
            lblProposition1.Hide();
            lblProposition2.Hide();
            lblProposition3.Hide();
            lblProposition4.Hide();
            textBoxProposition1.Hide();
            textBoxProposition2.Hide();
            textBoxProposition3.Hide();
            textBoxProposition4.Hide();
        }
        public void clearPropositions()
        {
            textBoxProposition1.Text = "";
            textBoxProposition2.Text = "";
            textBoxProposition3.Text = "";
            textBoxProposition4.Text = "";
        }
    }
}
