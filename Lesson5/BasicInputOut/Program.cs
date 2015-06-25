using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // read write to a file. Input /output

//create two methods Write and Read

namespace BasicInputOut
{
    class Program
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

            //System.IO // display methods

            string Filename = @"mydoc.txt";

            WriteFile(Filename);

            ReadFile(Filename);

            Console.Read();
        }
    }
}