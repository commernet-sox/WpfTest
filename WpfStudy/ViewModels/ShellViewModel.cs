using Caliburn.Micro;
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

namespace WpfStudy.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {
            ShowHello = "Hello CM MVVM";
        }
        private string showHello;
        public string ShowHello 
        {
            get { return showHello; }
            set {
                showHello = value;
                NotifyOfPropertyChange(()=>ShowHello);
            }
        }
    }
}
