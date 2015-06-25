using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // read write to a file. Input /output

// create two methods Write and Read

namespace BasicInputOut
{
    class Program
    {
        // static we can only create one instance of it
        static void WriteFile(string Filename)
        {
            // a stream a river or a flow
            FileStream fs = new FileStream(Filename, FileMode.Create, FileAccess.Write);

            if (fs.CanWrite) {

                // smallest size in C#
                byte[] buffer = Encoding.ASCII.GetBytes("Hello World");
                fs.Write(buffer, 0, buffer.Length);
            }

            fs.Flush();
            fs.Close();
        }

        static void ReadFile(string Filename)
        {

            // a stream a river or a flow
            FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);

            if (fs.CanRead)
            {
                                
                byte[] buffer = new byte[fs.Length]; // a buffer big enough to hold all of the file

                int bytesread = fs.Read(buffer, 0, buffer.Length);

                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesread));

            }           

            fs.Close();
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