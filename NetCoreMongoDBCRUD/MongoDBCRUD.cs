using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplicationNetMongo
{
	public class MongoDBCRUD
	{
		private IMongoClient mongoClient;
		private IMongoDatabase mongoDatabase;
		private var studentsCollection;

		public MongoDBCRUD () : this()
		{
			InitializeDatabaseParameters();
		}

		private void InitializeDatabaseParameters()
		{
			mongoClient = new MongoClient();
			mongoDatabase = new MongoDatabase(Program.DATABASE_NAME);
			studentsCollection = mongoDatabase.GetCollection(Program.COLLECTION_NAME);
		}

		public bool InsertStudent(Student student)
		{
			try
			{
				studentsCollection.InsertOne(student);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}

		public bool DeleteStudent(Student student)
		{
			try
			{
				studentsCollection.DeleteOne(student);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}

		public Student FindStudent()
		{
			try
			{
				// TO-DO
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void FindAll()
		{
			try
			{
				var students = studentsCollection.Find(new BsonDocument());

				foreach (var student in students)
				{
					Console.WriteLine(student.ToString());
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}