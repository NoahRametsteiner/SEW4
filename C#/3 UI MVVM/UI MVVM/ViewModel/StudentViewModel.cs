using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI_MVVM.Model;
namespace UI_MVVM.ViewModel
{
    class StudentViewModel
    {
        public StudentModel Model { get; set; } = new StudentModel();
        Student StudentProperty { get; set; }

        public StudentViewModel()
        {
            ExitCommand = new RelayCommand(
              e => {
                  System.Environment.Exit(0);
            },
              c => true   // damit können alle gebundenen Buttons/Menüs deaktiviert werden
            );

            AddCommand = new RelayCommand(
              e => {
              
              },
              c => true   // damit können alle gebundenen Buttons/Menüs deaktiviert werden
            );

            RemoveCommand = new RelayCommand(
              e => { 
              
              },
              c => true   // damit können alle gebundenen Buttons/Menüs deaktiviert werden
            );
        }

        public ICommand ExitCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }

    }
}
