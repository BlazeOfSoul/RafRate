namespace RafRate.Data.Contexts;

public class ConnectionStringContext
{
    public static string ConnectionString { get; } =  Environment.GetEnvironmentVariable("ConnectionString") 
                                                     ?? throw new InvalidOperationException();
}
