using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
using WpfStudy.ViewModels;

namespace WpfStudy.Views
{
    /// <summary>
    /// GridPage.xaml 的交互逻辑
    /// </summary>
    public partial class GridPageView : Page
    {
        private IDialogCoordinator dialogCoordinator;
        public GridPageView()
        {
            InitializeComponent();
            dialogCoordinator = DialogCoordinator.Instance;
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {

                MessageBox.Show("内容存在或为空，请重新输入！");
            }
            else
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Text = "";
            }
        }
    }
}
