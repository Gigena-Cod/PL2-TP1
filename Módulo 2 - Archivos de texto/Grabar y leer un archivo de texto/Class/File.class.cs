using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Grabar_y_leer_un_archivo_de_texto.Class
{
    internal class FileClass
    {
        public const string filename = "Filename.txt";

        
        static public void Record(string text)
        {
            //Open AD
            StreamWriter streamWriter = new StreamWriter(filename, true);

            //Record AD
            streamWriter.WriteLine(text);

            //Close AD
            streamWriter.Close();

            streamWriter.Dispose();
        }
    }
}
