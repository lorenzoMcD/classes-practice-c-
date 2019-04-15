using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDaniel_PA3
{
    class Mage : Hero
    {
        // fields

        private int magicpoints;

        // properties
        public int Magicpoints
        { 
            get
            {
                return magicpoints;
            }

            set
            {
                if(value >= 0)
                {
                    magicpoints = value;
                }

            }


        }




        public override void AnnounceSelf()
        {
            if (Title == "Mage")
            { Console.WriteLine("I am a {0} with {1} Magic Points! ", Title, Magicpoints); }

            else
            { Console.WriteLine("This {0} has {1} Magic! ", Title, Magicpoints); }

            }

        public override int GetHealth()
        {
            return HealthPoints;
        }

        public override bool IsAlive()
        {
            if(HealthPoints > 0)
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





  

