// BEFORE
/*abstract class Command
{
	public abstract void Execute(string sql);
	public abstract void BulkCopy(string fromSql, string toSql);
}

class SQLCommand : Command
{
	public override void BulkCopy(string fromSql, string toSql)
	{
		Console.WriteLine("SQL Bulk Copy is Started...");
	}

	public override void Execute(string sql)
	{
		Console.WriteLine("SQL is Executed...");
	}
}

class MySQLCommand : Command
{
	public override void BulkCopy(string fromSql, string toSql)
	{
		throw new NotImplementedException("MySQL Bulk Copy is Not Implemented Yet...");
	}

	public override void Execute(string sql)
	{
		Console.WriteLine("MySQL is Executed...");
	}
}*/


// AFTER
interface ICommand
{
	void Execute(string sql);
}

interface IBulkCopy : ICommand
{
	void BulkCopy(string fromSQL, string toSQl);
}

class SQLCommand : IBulkCopy
{
	public void Execute(string sql)
	{
		Console.WriteLine("SQL is Executed...");
	}

	public void BulkCopy(string fromSql, string toSql)
	{
		Console.WriteLine("SQL Bulk Copy is Started...");
	}
}

class MySQLCommand : ICommand
{
	public void Execute(string sql)
	{
		Console.WriteLine("MySQL is Executed...");
	}
}