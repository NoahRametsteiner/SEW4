using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            this.cbxFonts.DataContext = this.sampleTexts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.lstList.Items.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach(ListBoxData data in this.getListBoxData())
            {
                this.lstList.Items.Add(data);
            }
        }

        private IList<ListBoxData> getListBoxData()
        {
            IList<ListBoxData> data = new List<ListBoxData>();

            for (int i = 0; i < 10; i++)
            {
                ListBoxData listBoxData = new ListBoxData();
                listBoxData.Name = "Name " + i;
                listBoxData.Id = i;
                data.Add(listBoxData);
            }

            return data;
        }

        private void fillTree_Click(object sender, RoutedEventArgs e)
        {
            this.tree.Items.Clear();

            TreeViewItem root = new TreeViewItem();
            root.Header = "Root";

            TreeViewItem item1 = new TreeViewItem();
            item1.Header = "Item 1";

            TreeViewItem item2 = new TreeViewItem();
            item2.Header = "Item 2";

            root.Items.Add(item1);
            root.Items.Add(item2);

            this.tree.Items.Add(root);
        }

        private void delTree_Click(object sender, RoutedEventArgs e)
        {
            this.tree.Items.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void fillFonts()
        {
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.FontFamily = fontFamily;
                textBlock.Text = fontFamily.ToString();
                this.cbxFonts.Items.Add(textBlock);
            }
        }

        private List<TextBlock> sampleTexts()
        {
            List<TextBlock> list = new List<TextBlock>();

            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.FontFamily = fontFamily;
                textBlock.Text = fontFamily.ToString();
                list.Add(textBlock);
            }

            return list;
        }
    }
}
