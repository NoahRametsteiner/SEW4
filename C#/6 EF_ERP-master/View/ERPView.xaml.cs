using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MyERP.ViewModel;

namespace MyERP.View
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
