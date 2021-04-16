using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustreinui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic Logic = new Logic();
            string test = "";
            foreach (var t in Logic.Operation().Wagons)
            {
                test += "inhoud: " + t.Animals.Count + "(" + t.plaats + ")\n";
                foreach (var i in t.Animals)
                {
                    test += i.grote + " is carnivore: " + i.carnivore + "\n";
                }
            }
            MessageBox.Show(test);
        }


    }
}
