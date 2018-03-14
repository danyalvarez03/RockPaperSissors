/*
 * Created by SharpDevelop.
 * User: 0726176
 * Date: 3/14/2018
 * Time: 11:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace RockPaperScissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to RockPaperScissors!");
			Console.ReadLine();
			Console.WriteLine("Make your choice");
			gameFunc();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void gameFunc()
		{
			Random rand = new Random();
			
			string rock = "ROCK";
			string paper = "PAPER"
			string scissors ="SCISSORS";
			string choice = Console.ReadLine();
		
			int random + Random.Next(1,4);
			choice = choice.ToUpper();
			
			switch (random)
			{ 
				case 1:
						if (choice == rock)
					{ 
							Console.WriteLine(choice + " <- you vs. us -> " + rock + "./n");
							Console.WtriteLine("Issa tie");	             
		            }
				
						else if (choice == paper)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + rock + "./n");
							Console.WtriteLine("You win!");	   
					}
						
						else if (choice == scissors)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + rock + "./n");
							Console.WtriteLine("You lose!");	   
					}
						else
				    {
							Console.WriteLine(choice + "is not a choice");
					}
					break;
						
				case 2:
					 
					if (choice == rock)
					{ 
							Console.WriteLine(choice + " <- you vs. us -> " + paper + "./n");
							Console.WtriteLine("You lose!");	             
		            }
				
						else if (choice == paper)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + paper + "./n");
							Console.WtriteLine("Issa tie!");	   
					}
						
						else if (choice == scissors)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + paper + "./n");
							Console.WtriteLine("You win!");	   
					}
						else
				    {
							Console.WriteLine(choice + "is not a choice");
					}	
					break;
						
				default:
					
					if (choice == rock)
					{ 
							Console.WriteLine(choice + " <- you vs. us -> " + scissors + "./n");
							Console.WtriteLine("You win!");	             
		            }
				
						else if (choice == paper)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + scissors + "./n");
							Console.WtriteLine("You lose!");	   
					}
						
						else if (choice == scissors)
					{
						Console.WriteLine(choice + " <- you vs. us -> " + scissors + "./n");
							Console.WtriteLine("Issa tie!");	   
					}
						else
				    {
							Console.WriteLine(choice + "is not a choice");
					}	
					break;
					
	}
			Console.ReadLine();
			
}