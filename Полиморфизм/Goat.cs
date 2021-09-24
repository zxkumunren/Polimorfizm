using System;



namespace ДЗ_2_v0._1
{


    public class Goat : Animal
    {
        public string Postion { get; set; }

        public override void Voice()
        {
            Console.WriteLine("я блею");
        }

        public override void Food()
        {
            Console.WriteLine("я ем марихуану");
        }

        public override void Eyes()
        {
            Console.WriteLine("мои зрачки вертикальные");
        }

        public override void Hunting()
        {
            Console.WriteLine("я не умею охотиться");

        }

    }

}