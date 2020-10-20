using System;
namespace dbConnectionPracticeUsingInterface
{
	partial class Program
	{
		public class Oracle : IDbConnection
		{
			public void Close()
			{
				Console.WriteLine("oracle connection closed");
			}

			public void Open()
			{
				Console.WriteLine("oracle connection opened");
			}
		}
	}
}
