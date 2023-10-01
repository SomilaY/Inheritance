using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype01
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is eating.");
          
        }

        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping.");
           
        }

        public override void Move()
        {
            Console.WriteLine("The dog is running.");
            Console.ReadLine();

        }
    }
}
