using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.IO;
using System.Diagnostics;
using Kursovoi.Modules;

namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для AboutDW.xaml
    /// </summary>
    public partial class AboutDW : Window
    {
        public AboutDW()
        {
            InitializeComponent();
            Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] aboutDW Startup");

            if (Regedit.GetValue("firststart").ToString() == "0")
            {
                MessageBox.Show("Здесь содержиться информация о самой программе Adobe Dreamweaver.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
                if (Regedit.GetValue("tmp").ToString() == "3") Regedit.SetValue("firststart", "1");
                else
                {
                    Regedit.SetValue("tmp", (int.Parse(Regedit.GetValue("tmp").ToString()) + 1).ToString());
                }
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader($"{new Constants.Constants().APP_PATH}\\data\\about.bin");

            string rtf = await sr.ReadToEndAsync();

            spinnerSetup.Spin = false;
            spinnerSetup.Visibility = Visibility.Collapsed;

            MemoryStream ms = new MemoryStream(UTF8Encoding.Default.GetBytes(rtf));
            About.Selection.Load(ms, DataFormats.Rtf);
        }

    }
}
