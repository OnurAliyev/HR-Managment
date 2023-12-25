using HR.Core.Interfaces;
using System.Data;

namespace HR.Core.Entities;

public class Department : IEntity
{
    public int Id { get; }
    private static int _id;
    public string Name { get; set; }
    public string About { get; set; }
    public int EmployeeLimit { get; set; }
    public int EmployeeCount { get; set; }
    public Company CompanyId { get; set; }
    bool IsActive { get; set; } = true;

    public Department(string name, string about,int employeeLimit,Company companyId)
    {
        Id = _id++;
        Name = name;
        About = about;
        EmployeeLimit=employeeLimit;
        CompanyId = companyId;
    }



}
