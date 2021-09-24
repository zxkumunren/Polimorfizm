using System;



    namespace ДЗ_2_v0._1
{
    class Lion : Animal
    {
        public string Postion { get; set; }

        public override void Voice()
        {
            Console.WriteLine("я Мурчу");
        }

        public override void Food()
        {
            Console.WriteLine("я ем мясо");
        }

        public override void Eyes()
        {
            Console.WriteLine("мои зрачки горизонтальные");
        }

        public override void Hunting()
        {
            Console.WriteLine("я умею охотиться");

        }

    }

}