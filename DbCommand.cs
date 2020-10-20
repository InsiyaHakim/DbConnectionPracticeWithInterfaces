using System.Data;

namespace dbConnectionPracticeUsingInterface
{
	public class DbCommand
	{
		private readonly IDbConnection _dbConnection;
		private readonly string _instructions;
		public DbCommand(IDbConnection dbConnection, string instruction)
		{
			_dbConnection = dbConnection;
			_instructions = instruction;
		}

		public void Execute()
		{
			_dbConnection.Open();
			System.Console.WriteLine("Instruction");
			_dbConnection.Close();
		}
	}
}
