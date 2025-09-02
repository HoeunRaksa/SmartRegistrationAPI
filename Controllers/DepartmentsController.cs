using Microsoft.AspNetCore.Mvc;
using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRegistrationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<Department>> Get()
        {
            return _service.GetDepartmentsAsync();
        }

        [HttpGet("{id}")]
        public Task<Department?> Get(int id)
        {
            return _service.GetDepartmentByIdAsync(id);
        }

        [HttpPost]
        public Task<Department> Post([FromBody] Department department)
        {
            return _service.CreateDepartmentAsync(department);
        }

        [HttpPut]
        public Task<Department> Put([FromBody] Department department)
        {
            return _service.UpdateDepartmentAsync(department);
        }

        [HttpDelete("{id}")]
        public Task<bool> Delete(int id)
        {
            return _service.DeleteDepartmentAsync(id);
        }
    }
}
