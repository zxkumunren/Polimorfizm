using System;
namespace ДЗ_2_v0._1
{
	public class Animal
	{
		public string Name { get; set; }
		public string View { get; set; }
		public string Classs { get; set; }

		public Animal(string Name, string View, string Classs)
		{
			Name = Name;
			View = View;
			Classs = Classs;
		}
		public Animal()
		{

		}
		virtual public void Voice()
		{
			Console.WriteLine("Рычит");
		}

		virtual public void Food()
		{
			Console.WriteLine("Ем траву");
		}

		virtual public void Eyes()
		{
			Console.WriteLine("Вертикальные");
		}

		public void Going()
		{
			Console.WriteLine("Я умею ходить");
		}

		public void Fun()
		{
			Console.WriteLine("умею резвиться");

		}

		virtual public void Hunting()
		{
			Console.WriteLine("я умею охотиться");

		}

	}
}