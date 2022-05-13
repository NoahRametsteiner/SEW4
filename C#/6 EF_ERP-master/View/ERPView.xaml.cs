using _4_06_EF_ERP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _4_06_EF_ERP.View
{
    public partial class ERPView : Window
    {
        public ERPView()
        {
            InitializeComponent();
        }

        public void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = (ERPViewModel)DataContext;
            viewModel.SelectedPositionsSum = (int) viewModel.SelectedPositions.Select(x => x.Price).Sum();
        }
    }
}
