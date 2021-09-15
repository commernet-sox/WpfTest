using Caliburn.Micro;
using System;
using System.Collections.ObjectModel;
using MahApps.Metro.IconPacks;
using WpfStudy.Mvvm;
using WpfStudy.Views;
using MahApps.Metro.Controls.Dialogs;

namespace WpfStudy.ViewModels
{
    public class MainWindowViewModel : Screen
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();
        private static readonly ObservableCollection<MenuItem> AppOptionsMenu = new ObservableCollection<MenuItem>();
        private readonly IDialogCoordinator _dialogCoordinator;
        public ObservableCollection<MenuItem> Menu => AppMenu;

        public ObservableCollection<MenuItem> OptionsMenu => AppOptionsMenu;

        public MainWindowViewModel()
        {
            _dialogCoordinator = DialogCoordinator.Instance;
            // Build the menus
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.BugSolid },
                Label = "Bugs",
                NavigationType = typeof(BugsPage),
                NavigationDestination = new Uri("Views/BugsPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.UserSolid },
                Label = "User",
                NavigationType = typeof(UserPage),
                NavigationDestination = new Uri("Views/UserPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.CoffeeSolid },
                Label = "Break",
                NavigationType = typeof(BreakPage),
                NavigationDestination = new Uri("Views/BreakPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.FontAwesomeBrands },
                Label = "Awesome",
                NavigationType = typeof(AwesomePage),
                NavigationDestination = new Uri("Views/AwesomePage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.ThLargeSolid },
                Label = "Grid",
                NavigationType = typeof(GridPageView),
                NavigationDestination = new Uri("Views/GridPageView.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.LayerGroupSolid },
                Label = "StackPanel",
                NavigationType = typeof(StackPanelPage),
                NavigationDestination = new Uri("Views/StackPanelPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.DrawPolygonSolid },
                Label = "Canvas",
                NavigationType = typeof(CanvasPage),
                NavigationDestination = new Uri("Views/CanvasPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.DockerBrands },
                Label = "DockPanel",
                NavigationType = typeof(DockPanel),
                NavigationDestination = new Uri("Views/DockPanel.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconBootstrapIcons() { Kind =PackIconBootstrapIconsKind.Window},
                Label = "WrapPanel",
                NavigationType = typeof(WrapPanelPage),
                NavigationDestination = new Uri("Views/WrapPanelPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconBootstrapIcons() { Kind = PackIconBootstrapIconsKind.Table },
                Label = "TablePage",
                NavigationType = typeof(TablePageView),
                NavigationDestination = new Uri("Views/TablePageView.xaml", UriKind.RelativeOrAbsolute)
            });
            //底部信息
            this.OptionsMenu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.CogsSolid },
                Label = "Settings",
                NavigationType = typeof(SettingsPage),
                NavigationDestination = new Uri("Views/SettingsPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.OptionsMenu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.InfoCircleSolid },
                Label = "About",
                NavigationType = typeof(AboutPage),
                NavigationDestination = new Uri("Views/AboutPage.xaml", UriKind.RelativeOrAbsolute)
            });
        }

        public void MsgShow()
        {
            ShowMsg("弹窗测试");
        }

        public async void ShowMsg(string msg = "未知错误！")
        {
            MetroDialogSettings dialogSettings = new MetroDialogSettings
            {
                AffirmativeButtonText = "确定",
                NegativeButtonText="取消",
                DialogTitleFontSize=24,
            };
            var result = await _dialogCoordinator.ShowMessageAsync(this,"提示:",msg,MessageDialogStyle.Affirmative,dialogSettings);
        }
    }
}
