using Course.Commands;
using Course.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Course.ViewModel
{
    public class GroupsVM : INotifyPropertyChanged
    {
        List<Entities.Group> groups;
        public event PropertyChangedEventHandler PropertyChanged;
        public ShowView showView;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        public List<Entities.Group> Groups {
            get
            {
                return groups;
            }
            set
            {
                groups = value;
                OnPropertyChanged(new PropertyChangedEventArgs( nameof(Groups)));
            }
        }
    }
}
