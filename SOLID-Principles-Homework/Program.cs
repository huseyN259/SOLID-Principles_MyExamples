class Program
{
	static void Main()
	{
		// Problem
		//Console.WriteLine("Problem:\n");
		//var sqlCommand = new SQLCommand();
		//sqlCommand.Execute("Select * From Table");
		//sqlCommand.BulkCopy("From Table", "To Table");

		//var mySqlCommand = new MySQLCommand();
		//mySqlCommand.Execute("Select * From Table");
		//try
		//{
		//	mySqlCommand.BulkCopy("From Table", "To Table");
		//}
		//catch (Exception ex)
		//{
		//	Console.WriteLine(ex.Message);
		//}


		// Solution
		Console.WriteLine("\nSolution:\n");
		IBulkCopy bulkCopy = new SQLCommand();
		bulkCopy.Execute("Select * From Table");
		bulkCopy.BulkCopy("From Table", "To Table");

		ICommand command = new MySQLCommand();
		command.Execute("Select * From Table");
	}
}