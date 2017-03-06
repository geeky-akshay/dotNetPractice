using System;

namespace ConsoleApplicationNetMongo
{
    public class Program
    {
		public static string DATABASE_NAME = "school";
		public static string COLLECTION_NAME = "studentDetails";

        public static void Main(string[] args)
        {

			
        }

		private void DisplayMenu()
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

		private Student GetStudent()
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

		private void PerformOperations()
		{
			var choice;
			var mongoCRUD = new MongoDBCRUD();

			do
			{
				DisplayMenu();
				Console.Write("Enter your choice : ");
				choice = Console.ReadLine();

				switch (choice)
				{
					case 1 :
						{
							mongoCRUD.InsertStudent(GetStudent());
						}
						break;
				}
			} while (choice != 6);
			
		}
    }
}
