using Kursovoi.Modules;
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

namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для aboutProgLang.xaml
    /// </summary>
    public partial class aboutProgLang : Window
    {
        private ComponentsInfo cmp;
        public aboutProgLang()
        {
            InitializeComponent();
            Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] aboutProgLang Startup");
            cmp = new ComponentsInfo();
            Dictionary<int, Dictionary<string, object>> components = cmp.Select("Language");
            foreach (var comp in components)
                SelectLang.Items.Add(comp.Value["lang_name"]);

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

        //люблю тебя <3

        private void SelectLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CompName.Content = SelectComponent.SelectedItem.ToString();
            SelectedLang.Content = string.Format("Выбранный язык: {0}", SelectLang.SelectedItem.ToString());
            CodeListing.Document.Blocks.Clear();
            Dictionary<int, Dictionary<string, object>> info = cmp.SelectWhere("lang_name", SelectLang.SelectedItem.ToString(), "Language");
            MemoryStream stream = new MemoryStream(UTF8Encoding.Default.GetBytes(info[0]["lang_listing"].ToString()));
            CodeListing.Selection.Load(stream, DataFormats.Rtf);
            
            LangDesc.Document = new FlowDocument(new Paragraph(new Run(info[0]["lang_desc"].ToString())));
        }
    }
}
