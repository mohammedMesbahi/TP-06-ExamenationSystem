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

        private void textBoxNumberOfPropositions_TextChanged(object sender, EventArgs e)
        {
            int counter = int.Parse(textBoxNumberOfPropositions.Text);
            switch(counter)
            {
                case 1: 

            }
        }

        private void CreateQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}
