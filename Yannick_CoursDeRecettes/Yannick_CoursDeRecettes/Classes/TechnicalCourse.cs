using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes.Classes
{
    class TechnicalCourse:Course
    {
         string technicalName { get; set; }
         string technicalDescription { get; set; }

        public override string TechnicalName => technicalName;
        public override string TechnicalDescription => technicalDescription;

        public TechnicalCourse():base()
        {
            technicalName = "";
            technicalDescription = "";
        }
    }
}
