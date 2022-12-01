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
    public partial class CreateQuestions : UserControl
    {
        public CreateQuestions()
        {
            InitializeComponent();
        }

        public void textBoxNumberOfPropositions_TextChanged(object sender, EventArgs e)
        {
            int counter;
            if (textBoxNumberOfPropositions.Text !="")
            {
                counter = int.Parse(textBoxNumberOfPropositions.Text);
                switch(counter)
                {
                    case 1:
                        lblProposition1.Show();
                        lblProposition2.Hide();
                        lblProposition3.Hide();
                        lblProposition4.Hide();

                        textBoxProposition1.Show();
                        textBoxProposition2.Hide();
                        textBoxProposition3.Hide();
                        textBoxProposition4.Hide();
                        break;
                    case 2:
                        lblProposition1.Show();
                        lblProposition2.Show();
                        lblProposition3.Hide();
                        lblProposition4.Hide();

                        textBoxProposition1.Show();
                        textBoxProposition2.Show();
                        textBoxProposition3.Hide();
                        textBoxProposition4.Hide();
                        break;
                    case 3:
                        lblProposition1.Show();
                        lblProposition2.Show();
                        lblProposition3.Show();
                        lblProposition4.Hide();

                        textBoxProposition1.Show();
                        textBoxProposition2.Show();
                        textBoxProposition3.Show();
                        textBoxProposition4.Hide();
                        break;
                    case 4:
                        lblProposition1.Show();
                        lblProposition2.Show();
                        lblProposition3.Show();
                        lblProposition4.Show();

                        textBoxProposition1.Show();
                        textBoxProposition2.Show();
                        textBoxProposition3.Show();
                        textBoxProposition4.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        public void CreateQuestions_Load(object sender, EventArgs e)
        {
            hidePropositions();
        }

        public void btnNext_Click(object sender, EventArgs e)
        {
            
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

        private void textBoxProposition4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProposition3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProposition2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProposition1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProposition4_Click(object sender, EventArgs e)
        {

        }

        private void lblProposition3_Click(object sender, EventArgs e)
        {

        }

        private void lblProposition2_Click(object sender, EventArgs e)
        {

        }

        private void lblProposition1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuestionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumberOfPropositions_Click(object sender, EventArgs e)
        {

        }

        private void ListTypeOfQuetions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblQuestionType_Click(object sender, EventArgs e)
        {

        }
    }
}
