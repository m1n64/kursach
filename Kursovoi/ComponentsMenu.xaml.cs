using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using Kursovoi.Modules;

namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для ComponentsMenu.xaml
    /// </summary>
    public partial class ComponentsMenu : Window
    {
        private ComponentsInfo cmp;
        public ComponentsMenu()
        {
            InitializeComponent();
            Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] ComponentsMenu Startup");
            cmp = new ComponentsInfo();
            Dictionary<int, Dictionary<string, object>> components = cmp.Select();
            foreach(var comp in components)
                SelectComponent.Items.Add(comp.Value["comp_name"]);

            PropNames.Visibility = Visibility.Hidden;
            
        }

        private void SelectComponent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedComp.Content = "Выбранный компонент:";
            CompName.Content = SelectComponent.SelectedItem.ToString();
            DescComponent.Document.Blocks.Clear();
            PropNames.Items.Clear();
            Dictionary<int, Dictionary<string, object>> info = cmp.SelectWhere("comp_name", SelectComponent.SelectedItem.ToString());
            //PicComponent.Source = new BitmapImage(new Uri($"{new Constants.Constants().APP_PATH}\\pictures\\{info[0]["comp_pic"]}.jpg", UriKind.Relative));
            PicComponent.Source = new ImageSourceConverter().ConvertFromString($"{new Constants.Constants().APP_PATH}\\pictures\\{info[0]["comp_pic"]}.jpg") as ImageSource;
            MemoryStream stream = new MemoryStream(UTF8Encoding.Default.GetBytes(info[0]["comp_desc"].ToString()));
            DescComponent.Selection.Load(stream, DataFormats.Rtf);

            PropNames.Visibility = Visibility.Hidden;

            if (info[0]["comp_proporties"] != null)
            {
                PropNames.Visibility = Visibility.Visible;
                string[] props = info[0]["comp_proporties"].ToString().Split('|');
                foreach (string prop in props)
                {
                    PropNames.Items.Add(prop);
                }
            }
        }
    }
}