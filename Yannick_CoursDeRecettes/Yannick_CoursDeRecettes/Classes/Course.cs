using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yannick_CoursDeRecettes.Classes
{
    abstract class Course : INotifyPropertyChanged
    {
        public string CourseName { get; set; } = "Sauce cours";
        public string RegistrationCost { get; set; } = "14$";

        public event PropertyChangedEventHandler PropertyChanged;

        internal void LoadData()
        {
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            OnPropertyChanged(nameof(CourseName));
            OnPropertyChanged(nameof(RegistrationCost));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
