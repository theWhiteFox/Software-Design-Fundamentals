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
            //Vehicle Car;
            //Car = new Vehicle();

            Vehicle myCar = new Vehicle(); // new keyword, break point /debug here
            myCar.Make = "DeLorean";
            myCar.Model = "Time Machine";
            myCar.ElapsedMilage = 9999969;

            MessageBox.Show(myCar.Make); // break point /debug here
        }
    }
}
