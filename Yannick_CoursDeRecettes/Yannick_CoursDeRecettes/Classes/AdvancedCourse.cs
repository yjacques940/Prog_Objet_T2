using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes.Classes
{
    class AdvancedCourse : Course
    {
        string requirements { get; set; }

        public override string Requirements => requirements;

        public AdvancedCourse():base()
        {

        }
    }
}
