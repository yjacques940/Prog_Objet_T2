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
    public partial class CourseForm : Form, ICourseView
    {
        CourseController course;
        public CourseForm()
        {
            InitializeComponent();
            LoadData();
            ClearAllLabels();
        }

        private void ClearAllLabels()
        {
            courseNameLabel.Text = "";
            courseTypeLabel.Text = "";
            registrationCostLabel.Text = "";
            difficultyLevelLabel.Text = "";
            commentsListBox.Items.Clear();
            durationLabel.Text = "";
            prerequisitesLabel.Text = "";
            technicalNameLabel.Text = "";
            descriptionListBox.Items.Clear();
        }

        private void ShowCourse()
        {
            ClearAllLabels();
            courseNameLabel.Text = course.CurrentCourse.CourseName;
            courseTypeLabel.Text = course.GetTypeOfCourse();
            registrationCostLabel.Text = course.CurrentCourse.RegistrationCost;
            difficultyLevelLabel.Text = course.CurrentCourse.feature.DifficultyLevel;
            commentsListBox.Items.Add(course.CurrentCourse.feature.Comments);
            durationLabel.Text = course.CurrentCourse.feature.Duration;
            prerequisitesLabel.Text = course.CurrentCourse.Requirements;
            technicalNameLabel.Text = course.CurrentCourse.TechnicalName;
            descriptionListBox.Items.Add(course.CurrentCourse.TechnicalDescription);
        }

        private void LoadData()
        {
            course = new CourseController(this);
        }

        private void addEvaluationButton_Click(object sender, EventArgs e)
        {
            var form = new EvaluationForm(courseNumberTextbox.Text);
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            course.SearchCourse(courseNumberTextbox.Text);
            ShowCourse();
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
