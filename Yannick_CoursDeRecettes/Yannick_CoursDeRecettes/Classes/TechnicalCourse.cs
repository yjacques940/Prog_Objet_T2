using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes
{
    class TechnicalCourse:Course
    {

        public override string TechnicalName { get; set; }
        public override string TechnicalDescription { get; set; }

        public TechnicalCourse():base()
        {
        }
    }
}
