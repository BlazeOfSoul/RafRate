namespace RafRate.Data.Entities.ActiveDays;

using RafRate.Data.Interfaces;

public class ActiveDayEntity : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

}
