using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreFrront
{
   public static class FileHandler
    {
        public static void PrintFile (string text)
        {
            FileStream f = new FileStream(@".\..\..\GroceryStoreFrront", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine(text);
            s.Close();
            f.Close();
        }
    }
}
