using Course.Commands;
using Course.Others;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Course.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TabPanels : Window, IView
    {
        public TabPanels()
        {
            InitializeComponent();
            timeG.Text = DateTime.Now.ToString();
            timeS.Text = DateTime.Now.ToString();
        }

        public void ShowView()
        {
            Show();
        }
    }
}
