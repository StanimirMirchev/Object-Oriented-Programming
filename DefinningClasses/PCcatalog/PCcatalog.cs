using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            string name = "Lenovo";

            Component motherboard = new Component("motherboard", "several details",200);
            Component mouse = new Component("mouse","several details",10);
            Component keyboard = new Component("keyboard", "several details",100);
            List<Component> components = new List<Component>{motherboard,mouse,keyboard};
       
            Computer computerOne = new Computer(name, components);

            string name2 = "IBM";

            Component motherboard2 = new Component("motherboard2", "several details", 2000);
            Component mouse2 = new Component("mouse2", "several details", 100);
            Component keyboard2 = new Component("keyboard2", "several details", 1000);
            List<Component> components2 = new List<Component> { motherboard2, mouse2, keyboard2 };

            Computer computerTwo = new Computer(name2, components2);


            string name3 = "DELL";

            Component motherboard3 = new Component("motherboard3", "several details", 20000);
            Component mouse3 = new Component("mouse3", "several details", 1000);
            Component keyboard3 = new Component("keyboard3", "several details", 10000);
            List<Component> components3 = new List<Component> { motherboard3, mouse3, keyboard3 };

            Computer computerThree = new Computer(name3, components3);


            StringBuilder builder = new StringBuilder();
            builder.Append(computerOne.ToString());
            builder.Append(computerTwo.ToString());
            builder.Append(computerThree.ToString());

         //  Console.WriteLine(builder);

            List<Computer> computers = new List<Computer>() { computerThree, computerOne, computerTwo,computerThree };


            computers = computers.OrderBy(computer => computer.Price).ToList();

            for(int i = 0 ; i < computers.Count;i++)
            {
                Console.WriteLine(computers[i].ToString());
            }

            
            
        }
    }
    
}