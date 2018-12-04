using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    abstract class Course 
    {
        public CourseFeature feature;
        public string CourseName { get; set; } = "";
        public string RegistrationCost { get; set; } = "";
        public virtual string TechnicalName { get; set; } = "";
        public virtual string TechnicalDescription { get; set; } = "";
        public virtual string Requirements { get; set; } = "";

        public Course()
        {
            feature = new CourseFeature();
        }

        internal void LoadData()
        {

        }
    }
}
