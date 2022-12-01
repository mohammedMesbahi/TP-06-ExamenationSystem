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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btnCrealeExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateExam createExamPage = new CreateExam();
            createExamPage.Show();
        }
    }
}
