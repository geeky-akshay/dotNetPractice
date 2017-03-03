using System;

namespace ConsoleApplicationNetMongo
{
	public class Student
	{
		public ObjectId Id { get; set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public int Age { get; private set; }
		public string Address { get; private set; }

		public Student : this()
		{ }

		public Student (string firstName, string lastName, int age, string address)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Address = address;
		}
	}
}