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

        Vehicle myCar = new Vehicle();
        
        private void button2_Click(object sender, EventArgs e)
        {

            string[] game = { "Arya", "Tyrion", "Yara", "Daenerys", "Ramsay", "Joffrey" };

            for (int i = 0; i < game.Length; i++)
            {
                MessageBox.Show(game[i].ToString());
            }

            foreach (var person in game)
            {
                MessageBox.Show(person);
            }

            // Vehicle myCar = new Vehicle(); // new keyword, break point /debug here
            //myCar.Make = "DeLorean";
            //myCar.Model = "Time Machine";
            //myCar.ElapsedMilage = 9999969;

            //if(myCar.Make == "DeLorean")
            //{
            //    string myModel;
            //    myModel = myCar.Model;
            //}

            //MessageBox.Show(myModel);

            //string result;
            //result = myCar.Drive(30);
            //MessageBox.Show(result);

            //MessageBox.Show(myCar.Make); // break point 

            //int result = AddTwoNumbers(3, 5); // returns a value
            //// MessageBox.Show(result.ToString());
            //displayMessage(result.ToString()); // does not return a value
            //displayMessage(AddTwoNumbers(3, 9).ToString());

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
            MessageBox.Show(myCar.ElapsedMilage.ToString());
        }
    }
}
