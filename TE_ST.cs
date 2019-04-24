using System;
namespace te_st
public class Faggot {
	public static void Main() {
		Console.WriteLine("What is your name?");
		public string name = Console.ReadLine();
		Console.WriteLine("Are you sure you want " + name + " to be your name? You cannot change this later. (yes/no)");
		string Confirm = Console.ReadLine();
		if (Confirm=="no") {
			Console.WriteLine("Choose a new name, last chance!");
			name = Console.ReadLine();
		}
		Console.WriteLine("Your name is now " + name + "!");
	}
}
