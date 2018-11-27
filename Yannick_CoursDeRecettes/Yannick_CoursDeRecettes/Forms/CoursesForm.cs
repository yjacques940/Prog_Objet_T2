using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yannick_CoursDeRecettes.Classes;
using Yannick_CoursDeRecettes.Interfaces;

namespace Yannick_CoursDeRecettes
{
    public partial class CourseForm : Form,ICourseView
    {
        public CourseForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var course = new CourseController(this);
            course.LoadData();
        }

        private void addEvaluationButton_Click(object sender, EventArgs e)
        {
            var form = new EvaluationForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            var course = new CourseController(this);
            course.SearchCourse(courseNumberTextbox.Text);
        }
        
        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(this, message, "Erreur");
        }
    }
}
