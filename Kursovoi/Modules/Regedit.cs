using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoi.Modules
{
    class Regedit
    {
        private static RegistryKey User = Registry.CurrentUser;
        private static RegistryKey Soft = User.OpenSubKey("Software", true);

        private static RegistryKey key = Soft.CreateSubKey("HelpADW", true);

        public static object GetValue(string name)
        {
            return key.GetValue(name);
        }

        public static void SetValue(string name, string value)
        {
            key.SetValue(name, value);
        }

        public static void DeleteValue(string name)
        {
            key.DeleteValue(name);
        }
    }
}
