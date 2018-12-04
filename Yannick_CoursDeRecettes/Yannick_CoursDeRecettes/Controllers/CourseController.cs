using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class CourseController 
    {

        ICourseView view;
        CourseRepository courseRepository;
        Course currentCourse = null;


        public Course CurrentCourse
        {
            get { return currentCourse; }
        }

        public CourseController(CourseForm view)
        {
            this.view = view;
            courseRepository = new CourseRepository();
        }

        internal string GetTypeOfCourse()
        {
            return currentCourse is TechnicalCourse ? "Cours technique" : 
                   currentCourse is AdvancedCourse ?  "Cours avancé" : "";
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
                currentCourse = courseRepository.SearchCourseByCourseNumber(courseNumber);
            }
        }
    }
}
