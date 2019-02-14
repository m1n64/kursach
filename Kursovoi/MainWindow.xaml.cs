using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //SqlConnection con;
        public MainWindow()
        {
            InitializeComponent();
            
            Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] MainWindow Startup");

            //ComponentsInfo components = new ComponentsInfo();
            //Dictionary<int, Dictionary<string, object>>  dct = components.Select();
            //MessageBox.Show(dct[0]["comp_name"].ToString());
        }

        private void ButtonSpr_Click(object sender, RoutedEventArgs e)
        {
            new ComponentsMenu().Show();
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            new AboutDW().Show();
        }

        private void ButtonProg_Click(object sender, RoutedEventArgs e)
        {
            new aboutProgLang().Show();
        }
    }
}