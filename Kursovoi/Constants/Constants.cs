using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kursovoi.Constants
{
    class Constants
    {    
        public readonly string APP_PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
