using PrivateStorageManager.CommonManager;
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

namespace PrivateStorageManager.UserControls
{

    /// <summary>
    /// Interaction logic for ucMenu.xaml
    /// </summary>
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        private enum RouteMenuButtonEnum
        {
            AddNewStorageUnit,
            EditStorageUnit,
            RemoveStorageUnit,
            AddNewClient,
            EditClient,
            RemoveClient,
            Emailing,
            Payment,
            Reporting
        }

        private void RouteMenuButtonClick(object sender, RoutedEventArgs e)
        {
            RouteMenuButtonEnum routeMenuButtonEnum = 
                (RouteMenuButtonEnum)Enum.Parse(typeof(RouteMenuButtonEnum), (string)((Button)sender).CommandParameter);

            switch (routeMenuButtonEnum)
            {
                case RouteMenuButtonEnum.AddNewClient:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.AddNewStorageUnit:
                    {
                        AppManager.MainWindow.SetUserControl(new ucAddNewStorageUnit());
                        break;
                    }
                case RouteMenuButtonEnum.EditClient:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.EditStorageUnit:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.Emailing:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.Payment:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.RemoveClient:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.RemoveStorageUnit:
                    {
                        break;
                    }
                case RouteMenuButtonEnum.Reporting:
                    {
                        break;
                    }
            }
        }
    }
}
