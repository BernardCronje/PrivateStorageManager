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
using MahApps.Metro.Controls;
using PrivateStorageManager.UserControls;
using PrivateStorageManager.CommonManager;

namespace PrivateStorageManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            AppManager.MainWindow = this;

            if (AppManager.MainWindow.ucPlaceHolder.Content == null)
                AppManager.SetUserControl(new ucMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppManager.SetUserControl(new ucMenu());
            this.btnReturnToMenu.Visibility = Visibility.Hidden;
        }
    }
}
