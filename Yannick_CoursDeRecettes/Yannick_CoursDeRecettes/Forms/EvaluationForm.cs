using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yannick_CoursDeRecettes
{
    public partial class EvaluationForm : Form
    {
        string courseNumber;
        public EvaluationForm(string courseNumber)
        {
            this.courseNumber = courseNumber;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            var evaluationController = new EvaluationController
            {
                Difficulty = difficultyNumericUpDown.Value,
                Utility = utilityNumericUpDown.Value,
                Appreciation = appreciationNumericUpDown.Value,
                CourseNumber = courseNumber
            };
            evaluationController.SaveEvaluationInDatabase();
        }
    }
}
