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
        public string CourseName { get; set; } = "Sauce cours";
        public string RegistrationCost { get; set; } = "14$";
        public virtual string TechnicalName { get; set; }
        public virtual string TechnicalDescription { get; set; }
        public virtual string Requirements { get; set; }

        internal void LoadData()
        {
        }
    }
}
