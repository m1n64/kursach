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
        }
    }
}
