using Microsoft.EntityFrameworkCore;
using Shopping.Core.Entities;
using Shopping.Core.Interfaces;
using Shopping.Infrastructure.Data;

namespace Shopping.Infrastructure.Repositories;

public class EmployeeRepository(AppDbContext _context) : IEmployeeRepository
{
    public async Task<IEnumerable<EmployeeEntity>> GetAllEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<EmployeeEntity> GetEmployeeById(Guid id)
    {
        return await _context.Employees.FirstOrDefaultAsync(x => x.Id == id) ?? null!;
    }

    public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity)
    {
        employeeEntity.Id = Guid.NewGuid();
        _context.Employees.Add(employeeEntity);
        await _context.SaveChangesAsync();

        return employeeEntity;
    }

    public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

        if (employee is not null)
        {
            employee.Name = employeeEntity.Name;
            employee.Email = employeeEntity.Email;
            employee.Phone = employeeEntity.Phone;
            await _context.SaveChangesAsync();

            return employee;
        }


        return employeeEntity;
    }

    public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

        if (employee is not null)
        {
            _context.Employees.Remove(employee);

            return await _context.SaveChangesAsync() > 0;
        }

        return false;
    }
}