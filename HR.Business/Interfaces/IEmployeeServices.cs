namespace HR.Business.Interfaces;

public interface IEmployeeServices
{
    void Create(string name, string surname, int age, string gender, string role,
        string email, string phoneNumber, decimal salary);
    void Activate(int id);
    void Deactivate(int id);
    void ChangeDepartment(int departmentId, string newDepartmentName);
    void ShowAll();
}
