using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_2_v0._1
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            Goat goat = new Goat();
            Lion lion = new Lion();

            goat.Voice();
            animal.Food();
            lion.Voice();
            lion.Hunting();
            goat.Hunting();
            Console.ReadKey();
            
        }
    }
}