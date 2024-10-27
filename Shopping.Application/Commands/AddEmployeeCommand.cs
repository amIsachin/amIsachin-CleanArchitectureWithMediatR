using MediatR;
using Shopping.Core.Entities;
using Shopping.Core.Interfaces;

namespace Shopping.Application.Commands;

public record AddEmployeeCommand(EmployeeEntity employeeEntity) : IRequest<EmployeeEntity>;

public class AddEmployeeCommandHandler(IEmployeeRepository _employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
{
    public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeRepository.AddEmployeeAsync(request.employeeEntity);     
    }
}