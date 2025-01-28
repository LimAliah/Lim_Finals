using System;
namespace exam {
class Program {
	static void Main(string[] args)
	{
		Console.WriteLine("a. react \nb. skip"  );
		Console.WriteLine("Enter Choice: ");
		string choice = Console.ReadLine();
		
		if(choice == "a" || choice == "A")
		{
			string[] choose = new[] {"Waffles", "Pancakes","Cola","Pepsi", "Apples", "Banana", "Pokemon", "Digimon","Sweet", "Spicy" };

			Console.Write("Pick 10 of the choices: ");

			Console.Write(choose[0]);
			Console.WriteLine(choose[1]);
			Console.WriteLine(choose[2]);
			Console.WriteLine(choose[3]);
			Console.WriteLine(choose[4]);
			Console.WriteLine(choose[5]);
			Console.WriteLine(choose[6]);
			Console.WriteLine(choose[7]);
			Console.WriteLine(choose[8]);
			Console.WriteLine(choose[9]);

			Console.Write("the one you liked: ");
			string chooseliked = Console.ReadLine();
            Console.WriteLine("Liked: " + chooseliked);
            

			Console.Write("The one you disliked: " );
			string choosedisliked = Console.ReadLine();
			Console.WriteLine("DisLiked: " + choosedisliked);
			
	    if(choice == "b" || choice == "B")
		{
		   Console.WriteLine("Thank you for choosing! ");
		}
		}
	}
  }
}
