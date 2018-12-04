using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class CourseFeature
    {
        public string Duration { get; set; }
        public string DifficultyLevel { get; set; }
        public string Comments { get; set; }

        public CourseFeature()
        {
            Duration = "";
            DifficultyLevel = "";
            Comments = "";
        }
    }
}
