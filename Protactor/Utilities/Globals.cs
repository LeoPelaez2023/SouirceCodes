using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protractor.Utilities
{
    internal class Globals
    {
        public static string strGetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\con.xml";
        public static String stringConn = "";

    }
}
