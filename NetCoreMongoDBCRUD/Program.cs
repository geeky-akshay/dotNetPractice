using System;

namespace ConsoleApplicationNetMongo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayMenu();
        }

		public void DisplayMenu()
		{
			Console.WriteLine("_____MENU_____");
			Console.WriteLine();
			Console.WriteLine("1. Insert Student");
			Console.WriteLine("2. Update Student");
			Console.WriteLine("3. Delete Student");
			Console.WriteLine("4. Find Student");
			Console.WriteLine("5. Find All");
			Console.WriteLine("6. Exit");
			Console.WriteLine();
		}

		public Student GetStudent()
		{
			Console.WriteLine("Enter First Name : ");
			string firstName = Console.ReadLine();

			Console.WriteLine("Enter Last Name : ");
			string lastName = Console.ReadLine();

			Console.WriteLine("Enter Age : ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Address : ");
			string address = Console.ReadLine();

			var student = new Student (firstName: firstName, lastName: lastName, age: age, address: address);

			return student;
		}
    }
}
