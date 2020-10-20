using System;

namespace dbConnectionPracticeUsingInterface
{
	partial class Program
	{
		static void Main(string[] args)
		{
			var dbCommand = new DbCommand(new SqlConnection() ,"sql instruction");
			dbCommand.Execute();
			
			var dbCommand2 = new DbCommand(new Oracle() ,"sql instruction");
			dbCommand2.Execute();
		}
	}
}
