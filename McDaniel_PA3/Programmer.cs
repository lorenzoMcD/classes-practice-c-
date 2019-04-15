using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDaniel_PA3
{
    class Programmer : Hero
    {
        private int charm;


        public int Charm

        {
            get
            {
                return charm;
            }
            set
            {
                if(value >=0)
                {
                    charm = value;
                }
            }


        }





        public override void AnnounceSelf()
        {
            if (Title == "Programmer")
            { Console.WriteLine("I am a {0} with {1} Charm! ", Title, Charm); }

            else
            { Console.WriteLine("This {0} has {1} Charm! ", Title, Charm); }

        }

        public override int GetHealth()
        {
            return HealthPoints;
        }

        public override bool IsAlive()
        {
            if (HealthPoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }









    }
}
