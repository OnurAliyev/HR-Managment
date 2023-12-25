using HR.Core.Interfaces;

namespace HR.Core.Entities;
public class Company : IEntity
{
    public int Id { get; }
    private static int _id;
    public string Name { get; set; }
    public string About { get; set; }
    bool IsActive { get; set; } = true;

    public Company(string name, string about)
    {
        Id = _id++;
        Name = name;
        About = about;
    }
}
