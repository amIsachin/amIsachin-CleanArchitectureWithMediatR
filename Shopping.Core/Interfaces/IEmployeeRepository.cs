using Shopping.Core.Entities;

namespace Shopping.Core.Interfaces;

public interface IEmployeeRepository
{
    public Task<IEnumerable<EmployeeEntity>> GetAllEmployeesAsync();

    Task<EmployeeEntity> GetEmployeeById(Guid id);

    Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity);

    Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity);

    Task<bool> DeleteEmployeeAsync(Guid employeeId);
}
