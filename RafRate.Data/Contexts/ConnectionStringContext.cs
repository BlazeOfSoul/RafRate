namespace RafRate.Data.Contexts;

public class ConnectionStringContext
{
    public ConnectionStringContext()
    {
        _connectionString = Environment.GetEnvironmentVariable("ConnectionString")
                           ?? throw new InvalidOperationException();
    }
    private string _connectionString;
    
    public string ConnectionString
    {
        get {
            return _connectionString;
        }
        set
        {
            _connectionString = value;
        }
    }
}
