using System;

namespace McDaniel_PA3
{
    abstract class Hero
    {
        // fields
        private int healthPoints;  // protect >= 0

        // properties
        public string Title { get; set; }   // auto-property for Title

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    healthPoints = value;
                }
            }
        }

        // IsAlive() should return true if healthPoints is 
        // greater than 0.  
        public abstract bool IsAlive();

        // GetHealth() should return the current healthPoints
        // value.
        public abstract int GetHealth();

        // TODO:  Add a method named AnnounceSelf() that outputs to
        // the Console the Hero's Title and Health Points.  Make sure 
        // this method can be overridden in derived classes.

        public virtual void AnnounceSelf()
        {
            Console.WriteLine("My name is {0} and i have {1} health points", Title, HealthPoints);
        }

        
        
        

    }
}
