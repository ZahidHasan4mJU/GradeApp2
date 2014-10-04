using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Grade aGrade;
        private void marksShowButton_Click(object sender, EventArgs e)
        {
            aGrade = new Grade(Convert.ToDouble(marksPhysicaTextBox.Text), Convert.ToDouble(marksChemistryTextBox.Text),
                               Convert.ToDouble(marksMathTextBox.Text));
            marksAverageTextBox.Text = aGrade.getAverage().ToString();
            marksGradeLetterTextBox.Text = aGrade.getCheck();

        }
    }
}
