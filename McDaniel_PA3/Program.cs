using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDaniel_PA3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list to hold objects 

            List<Hero> list = new List<Hero>();
           
            // create heroes 

            Warrior s = new Warrior();
            Warrior h = new Warrior();
            Mage a = new Mage();
            Mage m = new Mage();
            Programmer p = new Programmer();

            // set the title and attributes to its respective class
            p.Title = "Lorenzo";
            s.Title = "Warrior";
            h.Title = "Spartan";
            a.Title = "Harry Potter";
            m.Title = "Mage";
            s.Strengthpoints = 25;
            h.Strengthpoints = 100;
            a.Magicpoints = 150;
            m.Magicpoints = 65;
            p.Charm = 1000;
            // add the heroes to the list
            list.Add(p);
            list.Add(s);
            list.Add(a);
            list.Add(m);
            list.Add(h);

            // loop through list and call announce method 
            // to announce each hero and their attribute

            foreach (Hero obj in list)
            {
                obj.AnnounceSelf();
            }

            Console.ReadKey();

        }
    }
}
