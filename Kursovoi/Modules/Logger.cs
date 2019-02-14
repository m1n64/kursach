using Kursovoi.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovoi.Constants;
using System.IO;

namespace Kursovoi
{
    class Logger : Files
    {
        public static void SaveLog(string data)
        {
            if (!Directory.Exists($"{new Constants.Constants().APP_PATH}\\logs\\")) Directory.CreateDirectory($"{new Constants.Constants().APP_PATH}\\logs");
            OpenWriteFile($"{new Constants.Constants().APP_PATH}\\logs\\{DateTime.Now.ToShortDateString()}.log", data);
        }
    }
}
