using System;
using DBApp.Models;
namespace DBApp
{
	class Program
	{
		static void Main(string[] args)
		{
			CitusTrainingContext context = new CitusTrainingContext();

			Dal dal = new Dal(context);

			Console.WriteLine($"Category available {dal.GetCategory(1)}");


			Console.ReadLine();
		}
	}
}
