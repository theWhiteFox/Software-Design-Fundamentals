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

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;

            // initializes a new instance of this class
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // gets or sets the current file name filter string, which determines the choices that appear in the "Save as file type" or "Files of type" box in the dialog box.
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            // gets or sets the index of the filter currently selected in the file dialog box.
            saveFileDialog1.FilterIndex = 2;

            // gets or sets a value indicating whether the dialog box restores the current directory before closing.
            saveFileDialog1.RestoreDirectory = true;

            // update if the user clicks OK  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // code to write the stream goes here
                    myStream.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("Values.txt");
                file.WriteLine("Arya");
                file.WriteLine("Ned");
                file.WriteLine("Rob");
                file.WriteLine("Bran");

                file.Close();
                MessageBox.Show("Done");
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot write");
            }
        }
    }
}
