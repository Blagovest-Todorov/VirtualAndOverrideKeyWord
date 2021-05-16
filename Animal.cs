using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConnection
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating…");
        }

        public virtual void Talk()  //virtual-this methos i chi;d class can be extended, defined again
        {
            Console.WriteLine("Hi i am an animal.");
        }
    }
}
