using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class CourseController : INotifyPropertyChanged
    {

        ICourseView view;
        CourseRepository courseRepository;
        Course currentCourse = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public string CourseName { get; set; } = "";
        public string RegistrationCost { get; set; } = "";
        public virtual string TechnicalName { get; set; } = "";
        public virtual string TechnicalDescription { get; set; } = "";
        public virtual string Requirements { get; set; } = "";
        public Course CurrentCourse
        {
            get { return currentCourse; }
        }

        public CourseController(ICourseView view)
        {
            this.view = view;
            courseRepository = new CourseRepository();
        }
        internal void LoadData()
        {
            //InitialiserLeCours();
        }

        public string RecipeName { get; set; }
        public string CookingTime { get; set; }
        public string PreparationTime { get; set; }

        internal void SearchCourse(string courseNumber)
        {
            if(string.IsNullOrEmpty(courseNumber))
            {
                view.ShowMessage("Vous devez entrer un numéro de cours.");
            }
            else
            {
                var courseInfo = courseRepository.SearchCourseByCourseNumber(courseNumber);
                CourseName = courseInfo.CourseName;
                RegistrationCost = courseInfo.RegistrationCost;
                TechnicalName = courseInfo.TechnicalName;
                TechnicalDescription = courseInfo.TechnicalDescription;
                Requirements = courseInfo.Requirements;
                UpdateProperties();
            }
        }

        private void UpdateProperties()
        {
            OnPropertyChanged(nameof(CourseName));
            OnPropertyChanged(nameof(RegistrationCost));
            OnPropertyChanged(nameof(TechnicalDescription));
            OnPropertyChanged(nameof(TechnicalName));
            OnPropertyChanged(nameof(Requirements));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
