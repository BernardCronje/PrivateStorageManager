using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PrivateStorageManager.CommonManager
{
    public static class AppManager
    {
        public static MainWindow MainWindow { get; set; }
        public static bool IsMainWindowInFocus { get; set; }




        public static void SetUserControl(UserControl newUsercontrol)
        {
            MainWindow.ucPlaceHolder.Content = newUsercontrol;

            if (newUsercontrol.GetType() == typeof(UserControls.ucMenu))
                MainWindow.btnReturnToMenu.Visibility = System.Windows.Visibility.Hidden;
            else
                MainWindow.btnReturnToMenu.Visibility = System.Windows.Visibility.Visible;
        }

    }
}
