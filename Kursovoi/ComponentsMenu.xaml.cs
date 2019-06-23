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

            if (SelectComponent.Items.Count > 0)
                this.ComponentsOut(SelectComponent.Items[0].ToString());

            if (Regedit.GetValue("firststart").ToString() == "0")
            {
                MessageBox.Show("Тут вы можете посмотреть все языки программирования, которые используются в Adobe Dreamweaver.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
                if (Regedit.GetValue("tmp").ToString() == "3") Regedit.SetValue("firststart", "1");
                else
                {
                    Regedit.SetValue("tmp", (int.Parse(Regedit.GetValue("tmp").ToString()) + 1).ToString());
                }
            }


        }

        private void ComponentsOut(string serach)
        {
            SelectedComp.Content = "Выбранный компонент:";
            CompName.Content = serach;
            DescComponent.Document.Blocks.Clear();
            PropNames.Items.Clear();
            Dictionary<int, Dictionary<string, object>> info = cmp.SelectWhere("comp_name", serach);
            //PicComponent.Source = new BitmapImage(new Uri($"{new Constants.Constants().APP_PATH}\\pictures\\{info[0]["comp_pic"]}.jpg", UriKind.Relative));
            PicComponent.Source = new ImageSourceConverter().ConvertFromString($"{new Constants.Constants().APP_PATH}\\pictures\\{info[0]["comp_pic"]}.jpg") as ImageSource;
            MemoryStream stream = new MemoryStream(UTF8Encoding.Default.GetBytes(info[0]["comp_desc"].ToString()));
            DescComponent.Selection.Load(stream, DataFormats.Rtf);

            PropNames.Visibility = Visibility.Hidden;

            if (info[0]["comp_proporties"].ToString() != "")
            {
                PropNames.Visibility = Visibility.Visible;
                string[] props = info[0]["comp_proporties"].ToString().Split('|');
                foreach (string prop in props)
                {
                    PropNames.Items.Add(prop);
                }
            }
        }

        private void SelectComponent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectComponent.Items != null)
                this.ComponentsOut(SelectComponent.SelectedItem.ToString());
        }
    }
}