using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.ViewModels
{
    public class GridPageViewModel: Screen
    {
        private string txt = string.Empty;
        public string TxtName
        {
            get { return txt; }
            set
            {
                txt = value;
                NotifyOfPropertyChange(() => TxtName);
            }
        }
        public BindingList<string> lstNames { get; set; }
        private readonly IDialogCoordinator _dialogCoordinator;
        public GridPageViewModel()
        {
            lstNames = new BindingList<string>();
            _dialogCoordinator = DialogCoordinator.Instance;
        }
        public void Show()
        {
            if (string.IsNullOrWhiteSpace(TxtName) ||lstNames.Contains(TxtName))
            {
                ShowMsg("内容存在或为空，请重新输入！");
                TxtName = string.Empty;
            }
            else
            {
                lstNames.Add(TxtName);
                TxtName = null;
            }
        }

        public async void ShowMsg(string msg = "未知错误！")
        {
            MetroDialogSettings dialogSettings = new MetroDialogSettings
            {
                AffirmativeButtonText = "确定",
                NegativeButtonText = "取消",
                DialogTitleFontSize = 24,
            };
            var result = await _dialogCoordinator.ShowMessageAsync(this, "提示:", msg, MessageDialogStyle.Affirmative, dialogSettings);
        }
    }
}
