using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sluttest
{
    class Medlem
    {
        private int ålder;
        private int medlemsavgift;
        private string roll;
        private string medlemskapsnivå;

        public Medlem(int ålder, int medlemsavgift, string roll,string medlemskapsnivå)
        {
           Ålder = ålder;
           Medlemsavgift = medlemsavgift;
           Roll = roll;
           Medlemskapsnivå = medlemskapsnivå; 
        }

        public int Ålder
        {
            get 
            {
                return ålder;
            }

            set 
            {
                ålder = value;
            }
        }

        public int Medlemsavgift
        {
            get
            {
                return medlemsavgift;
            }

            set
            {
                medlemsavgift = value;
            }
        }

        public string Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }

        public string Medlemskapsnivå
        {
            get 
            {
                return medlemskapsnivå;
            }
            set 
            {
                medlemskapsnivå = value;
            }
        }
         



    }
}
