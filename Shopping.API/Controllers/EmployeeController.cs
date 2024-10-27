using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping.Application.Commands;
using Shopping.Core.Entities;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity entity)
        {
            try
            {
                var result = await sender.Send(new AddEmployeeCommand(entity));

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}