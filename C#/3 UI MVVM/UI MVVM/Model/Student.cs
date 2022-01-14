using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UI_MVVM.Model
{
    class Student : INotifyPropertyChanged
    {
        public String name = string.Empty;
        public String Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int score;
        public int Score
        {
            get => score;
            set
            {
                score = value;
                RaisePropertyChanged();
            }
        }

        public string comment = string.Empty;
        public String Comment
        {
            get => comment;
            set
            {
                
                    comment = value;
                    RaisePropertyChanged();
                
            }
        }

        public DateTime date;


        public override int GetHashCode()
        {
            unchecked
            {
                return Name.GetHashCode() * 3 + Score.GetHashCode() * 7;
            }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
                return false;

            if (Name != student.Name)
                return false;
            if (Score != student.Score)
                return false;
            // weitere Properties vergleichen

            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
