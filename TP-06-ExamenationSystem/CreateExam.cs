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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage home = new homePage();
            home.Show();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            createQuestions1.Show();
        }
    }
}
