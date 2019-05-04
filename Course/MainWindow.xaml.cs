using Course.Views;
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

namespace Course
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void T1_Click(object sender, RoutedEventArgs e)
        {
            (new TabPanels()).ShowView();
        }

        private void T2_Click(object sender, RoutedEventArgs e)
        {
            (new Views.ListView()).ShowView();
        }

        private void T3_Click(object sender, RoutedEventArgs e)
        {
            (new Contract()).ShowView();
        }
    }
}
