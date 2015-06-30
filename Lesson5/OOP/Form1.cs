using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            string[] singers = new string[6];

            singers[0] = "Nina Simone (f)";
            singers[1] = "Killer Mike (m)";
            singers[2] = "El Producto (m)";
            singers[3] = "Lauren Mayberry (f)";
            singers[4] = "Gonjasufi (m)";
            singers[5] = "KiloWatts (m)";

            int singer_male = 0;
            int singer_female = 0;

            for (int i = 0; i < singers.Length; i++)
            {

                if (singers[i].Contains("(m)"))
                {
                    singer_male++;
                }

                if (singers[i].Contains("(f)"))
                {
                    singer_female++;
                }
            }

            listBox1.Items.Add("Number of male singers is " + singer_male.ToString());

            listBox1.Items.Add("Number of female singers is " + singer_female.ToString());

        }



        //public int AddTwoNumbers(int firstNumber, int secondNumber)
        //{
        //    return firstNumber + secondNumber;
        //}

        //// example of void no return method
        //public void displayMessage(string message)
        //{
        //    MessageBox.Show(message);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(myCar.ElapsedMilage.ToString());
        }
    }
}
