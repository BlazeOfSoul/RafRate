namespace RafRate.Data.Entities.Teachers;

using RafRate.Data.Interfaces;

public class TeacherEntity : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string JobTitle { get; set; }

    public string Disciplines { get; set; }
}
