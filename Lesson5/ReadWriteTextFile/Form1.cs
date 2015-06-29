using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ReadWriteTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            try
            {
                // read in nonexistent file
                using (StreamReader reader = new StreamReader("Values.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                        counter++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // write error
                MessageBox.Show("File not found");
            } 
           
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            // get the value of the selected item
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(name);           
        }
    }
}
