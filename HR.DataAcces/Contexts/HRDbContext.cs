using HR.Core.Entities;

namespace HR.DataAcces.Contexts;

public class HRDbContext
{
    public static List<Company> Companies { get; set; }
    public static List<Department> Departments { get; set; }
    public static List<Employee> Employees { get; set; }
}
