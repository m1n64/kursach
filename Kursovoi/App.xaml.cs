using Kursovoi.Modules;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            new MainWindow().Show();
            if (Regedit.GetValue("firststart") == null) Regedit.SetValue("firststart", "0");
            if (Regedit.GetValue("tmp") == null) Regedit.SetValue("tmp", "0");
        }
    }
}
