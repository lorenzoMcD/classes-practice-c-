using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDaniel_PA3
{
    class Warrior : Hero
    {
        // fields

        private int strengthpoints;

        // properties

        public int Strengthpoints
        {
            get
            {
                return strengthpoints;
            }

            set
            {
                if(value >= 0)
                {
                    strengthpoints = value;
                }
            }




        }





















        public override void AnnounceSelf()
        {

            if (Title == "Warrior")

            { Console.WriteLine("I am a {0} with {1} Strength Points! ", Title, Strengthpoints); }

            else
            {

                Console.WriteLine("This {0} has {1} Strength! ", Title, Strengthpoints);

            }
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
