using Course.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Commands
{
    public class ShowView : BaseCommand
    {
        IView view;
        public ShowView(IView view)
        {
            this.view = view;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            view.ShowView();
        }
    }
}
