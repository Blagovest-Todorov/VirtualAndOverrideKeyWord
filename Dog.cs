using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConnection
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking…");
        }

        public override void Talk()  // override, this method extends or redifines the base definded method
        {
            base.Talk();
            Console.WriteLine(" And I am a Dog also.");
        }
    }
}
