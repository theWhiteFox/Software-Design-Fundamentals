using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // input & output

namespace CourseBooking
{
    static class Program
    {
        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Hello World");
        }

        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //System.IO // display methods

            string Filename = @"mydoc.txt";

            WriteFile(Filename);

            ReadFile(Filename);

            Console.Read();

        }
    }
}
