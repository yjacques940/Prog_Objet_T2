using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yannick_CoursDeRecettes.Classes;
using Yannick_CoursDeRecettes.Interfaces;
using Yannick_CoursDeRecettes.Repository;

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
        public string CourseName { get; set; }
        //courseType
        public string RegistrationCost { get; set; }
        public string Duration { get; set; }
        public string DifficultyLevel { get; set; }
        public string Comments { get; set; }

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
            }
        }
    }
}
