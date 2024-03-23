using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4OOP
{
    internal class Machine
    {
        public double water;
        public double coffee;
        public double milk;
        public double chocolate;
        public Machine()
        {
            water = 500;
            coffee = 500;
            milk = 500;
            chocolate = 500;
        }
        public bool MakeBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                this.water -= 300;
                this.coffee -= 20;
                return true;
            }
            return false;
        }
        public bool MakeMocca()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                this.water -= 300;
                this.coffee -= 20;
                this.chocolate -= 10;
                return true;
            }
            return false;
        }
        public bool MakeLatte()
        {
            if (water >= 200 && coffee >= 20 && milk >= 10)
            {
                this.water -= 200;
                this.coffee -= 20;
                this.milk -= 10;
                return true;
            }
            return false;
        }
        public bool MakeChocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                this.water -= 300d;
                this.chocolate -= 20;
                return true;
            }
            return false;
        }
        public void AddMaterial()
        {
            water += 500;
            coffee += 500;
            milk += 500;
            chocolate += 500;
        }
    }
}
