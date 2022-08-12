namespace RafRate.Data.Contexts;

public class ConnectionStringContext
{
    // TODO don't work 
    private string _connectionString;

    ConnectionStringContext()
    {
        _connectionString = Environment.GetEnvironmentVariable("ConnectionString") 
                            ?? throw new InvalidOperationException();
    }

    public string ReturnConnectionString()
    {
        return _connectionString;
    }
}