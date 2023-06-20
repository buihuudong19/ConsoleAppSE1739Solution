using WinFormsAppHR.Entities;
using WinFormsAppHR.ContextDb;
namespace WinFormsAppHR.Repository;

public class EmpRepsitory : IEmpRepository
{
    private DataContextDb _db;

    public EmpRepsitory()
    {
        _db = new DataContextDb();  
    }
    public EmpRepsitory(DataContextDb db)
    {
        _db = db;
    }

    public void AddEmployee(Employee e)
    {
        throw new NotImplementedException();
    }

    public void DeleteEmployee(Employee e)
    {
        throw new NotImplementedException();
    }

    public Employee GetEmployeeById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetEmployees()
        => _db.GetAllEmployees();
   
    public void UpdateEmployee(Employee e)
    {
        throw new NotImplementedException();
    }
}
