using RafRate.Data.Interaces;

namespace RafRate.Data.Entities
{
    public class UserEntity : IEntity
    {
        public Guid Id { get; set; }

        public string EmailAddress { get; set; }
        
        public string PasswordHash { get; set; }  
        
        public string Nickname { get; set; }
        
        public string FIO { get; set; }

        public int Course { get; set; }
        
        public int Group { get; set; }

        public double AverageScore { get; set; }
        
        public int Role { get; set; }
    }
}
