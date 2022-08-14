using RafRate.Data.Interaces;

namespace RafRate.Data.Entities;

// will be replaced with Identity 
public class UserEntity : IEntity
{
    public Guid Id { get; set; }

    public string Email { get; set; }
        
    public string PasswordHash { get; set; }  
        
    public string Nickname { get; set; }
        
    public string FullName { get; set; }

    public int Role { get; set; }
}