using System;
namespace dbConnectionPracticeUsingInterface
{
	partial class Program
	{
		public class SqlConnection : IDbConnection
		{
			public void Close()
			{
				Console.WriteLine("sql connection closed");
			}

			public void Open()
			{
				Console.WriteLine("sql connection opened");
			}
		}
	}
}
