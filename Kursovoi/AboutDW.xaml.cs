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

            //try
            //{


            //    MemoryStream ms = new MemoryStream(UTF8Encoding.Default.GetBytes(rtf));
            //    About.Selection.Load(ms, DataFormats.Rtf);

            //}
            //catch (IOException ex)
            //{
            //    Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] aboutDW ${ex.Message} ${ex.Source} ");
            //}
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
