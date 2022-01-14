using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_MVVM.Model
{
    class StudentModel
    {
        #region Properties
        public ObservableCollection<Student> Students { get; private set; } = new ObservableCollection<Student>();
        
        #endregion

        #region Methods
        public StudentModel()
        {
            // create some demo students
            Students.Add(new Student { Name = "Mike", Score = 80, Comment = "test"});
            Students.Add(new Student { Name = "Alice", Score = 75, Comment = "test" });
        }

        public void Add(Student studentToAdd)
        {
            if(studentToAdd == null){return;}

            studentToAdd.date = DateTime.Now;
            studentToAdd.comment = $"This studet is added @ {studentToAdd.date}";
            Students.Add(studentToAdd);
        }

        public void Remove(Student studentToDelete)
        {
            if(studentToDelete != null)
            {
                Students.Remove(studentToDelete);
            }
        }
        #endregion
    }
}
