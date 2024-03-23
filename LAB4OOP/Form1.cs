using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Machine machine = new Machine();
        private void Material_Click(object sender, EventArgs e)
        {
            machine.AddMaterial();
        }

        private void BlackCoffee_Click(object sender, EventArgs e)
        {
            bool canmake = machine.MakeBlackCoffee();
            if (canmake)
            {
                MessageBox.Show("กาแฟดำ 1 แก้ว");
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void Mocha_Click(object sender, EventArgs e)
        {
            bool canmake = machine.MakeMocca();
            if (canmake)
            {
                MessageBox.Show("มอคค่า 1 แก้ว");
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            bool canmake = machine.MakeLatte();
            if (canmake)
            {
                MessageBox.Show("ลาเต้ 1 แก้ว");
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void Chocolate_Click(object sender, EventArgs e)
        {
            bool canmake = machine.MakeChocolate();
            if (canmake)
            {
                MessageBox.Show("ช็อคโกแล็ต 1 แก้ว");
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }
    }
}
