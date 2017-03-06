using System;

namespace ConsoleApplicationNetMongo
{
	public class Student
	{
		public string firstName { get; private set; }
		public string lastName { get; private set; }
		public int age { get; private set; }
		public string address { get; private set; }

		public Student (string firstName, string lastName, int age, string address)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.address = address;
		}
	}
}