using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LawnTree.Properties;

namespace LawnTree.Clases
{
    class conexion_string
    {
        public static string string_conexion()
        {
            return Settings.Default.LawnTreeBDConnectionString;
        }
    }
}
