using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;


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


        static public void Read(ListBox listBox)
        {
            //Open AD
            StreamReader streamWriter = new StreamReader(filename, true);

            listBox.Items.Clear();
            string? readLine = streamWriter.ReadLine();

            while (readLine!=null) { 
                listBox.Items.Add(readLine);
                readLine = streamWriter.ReadLine();
            }

            //Close AD
            streamWriter.Close();

            streamWriter.Dispose();

            listBox.TopIndex = listBox.Items.Count - 1;
        }
    }
}
