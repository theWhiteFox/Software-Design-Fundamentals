using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //// 1. basic 'if' statement 
            //if (comboBox1.Text == "SteJ")
            //{
            //    MessageBox.Show("You picked SteJ");
            //    comboBox1.Text = ""; // clears comboBox if selected 
            //}

            //// 2. 'if' statement curly braces removed, one line of code to be executed
            //if (comboBox1.Text == "Steph")
            //    MessageBox.Show("You picked Steph"); // one line of code after ‘if’ 

            //// 3. nested 'if' statement
            //if (comboBox1.Text != "Ste") // if not equal to Ste false go to else 
            //{
            //    if (comboBox1.Text == "SteJ")
            //    {
            //        MessageBox.Show("You picked SteJ."); // SteJ is selected 
            //    }
            //    else
            //    {
            //        MessageBox.Show("I'm not sure who you picked."); // Stevo or Steph selected 
            //    } 
            //} // end if 
            //else
            //{
            //    MessageBox.Show("You picked Ste");
            //} // end else

            //// 'switch' statement
            //switch (listBox1.SelectedItem.ToString())
            //{
            //    case "Foobar":
            //        MessageBox.Show("You picked Foobar");
            //        break;

            //    case "Bazquirk":
            //        MessageBox.Show("You picked Bazquirk");
            //        break;

            //    default:
            //        MessageBox.Show("You picked something else");
            //        break;
            //}

            //// arrays
            //// 1. sized array, set the size
            //string[] myArray = new string[2];
            //myArray[0] = "SteJ";
            //myArray[1] = "Steph";
            //// myArray[2] = "Stevo"; // causes an out of bounds exception
            //MessageBox.Show(myArray[1]);

            // 2. intialized array [0] = Ste, [1] = SteJ, [2] = Stevo, [3] = Steph
            string[] myArray = {"Ste", "SteJ", "Stevo", "Steph"};
            // MessageBox.Show(myArray[1]); // test array

            //// create temp var with value of ncikname
            //foreach (var nickname in myArray)
            //{
            //    MessageBox.Show(nickname);
            //}

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            //    i++;
            //}
            //MessageBox.Show("the final value was: " + i.ToString());

            //// for and foreach loop
            //for (int i = 0; i < myArray.Length;)        
            //{
            //    // temp value nickname
            //    foreach (var nickname in myArray)
            //    {   
            //        MessageBox.Show(i++ + " " + nickname);
            //    }
            //}

            // combine for and if on array 
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == "Stevo")
                {
                    MessageBox.Show("Stevo Found");
                }
            }
            
        }
    }
}
