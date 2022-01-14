using System;
using System.Collections.Generic;
using System.IO;
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
using ATX_LINQ.Model;

namespace ATX_LINQ.View
{
    public partial class StockView : Window
    {
        public StockView()
        {
            InitializeComponent();
        }
        
        #region CSV Import

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.DefaultExt = ".csv";
            openFileDlg.Filter = "Text documents (.csv)|*.csv";
            openFileDlg.InitialDirectory = @"C:\Temp\";

            Nullable<bool> result = openFileDlg.ShowDialog();
            
            if (result == true)
            {
                InitializeComponent();
                ListViewStock.ItemsSource = ReadCSV(openFileDlg.FileName);
            }
            

        }
        #endregion

        #region Read CSV

        public IEnumerable<StockModel> ReadCSV(string fileName)
        {
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));

            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                return new StockModel(data[0], Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4]));
            });
        }
        #endregion

        #region Filter

        private void Date_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test1");
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test2");
        }
        private void High_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test3");
        }
        private void Low_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test4");
        }
        private void LastClose_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test5");
        }

        #endregion

    }
}
