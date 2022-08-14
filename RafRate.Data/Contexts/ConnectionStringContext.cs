namespace RafRate.Data.Contexts;

public class ConnectionStringContext
{
    public string ConnectionString { get; init; } =  Environment.GetEnvironmentVariable("ConnectionString") 
                                                     ?? throw new InvalidOperationException();
}
