using Course.Entities;
using Course.Others;
using Course.ViewModel;
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

namespace Course.Views
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Window, IView
    {
        GroupsVM groupsVM = new GroupsVM();
        public ListView()
        {
            InitializeComponent();
            groupsVM.Groups = new List<Group>()
            {
                new Group(1,"1814",DateTime.Now),
                new Group(1,"1815",DateTime.Now),
                new Group(1,"1816",DateTime.Now),
                new Group(1,"1817",DateTime.Now)
            };
            DataContext = groupsVM;
        }

        public void ShowView()
        {
            Show();
        }
    }
}
