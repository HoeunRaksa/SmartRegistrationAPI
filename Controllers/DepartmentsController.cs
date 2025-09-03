using Microsoft.AspNetCore.Mvc;
using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Services;
using SmartRegistrationAPI.DTOs;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult<IEnumerable<DepartmentReadDto>>> Get()
        {
            var departments = await _service.GetDepartmentsAsync();

            // Map Entity → DTO
            var dtoList = departments.Select(d => new DepartmentReadDto
            {
                Id = d.Id,
                Name = d.Name,
                Code = d.Code,
                Faculty = d.Faculty,
                Title = d.Title,
                Description = d.Description
            });

            return Ok(dtoList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentReadDto>> Get(int id)
        {
            var department = await _service.GetDepartmentByIdAsync(id);
            if (department == null) return NotFound();

            var dto = new DepartmentReadDto
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Faculty = department.Faculty,
                Title = department.Title,
                Description = department.Description
            };

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<DepartmentReadDto>> Post([FromBody] DepartmentCreateDto dto)
        {
            var department = new Department
            {
                Name = dto.Name,
                Code = dto.Code,
                Faculty = dto.Faculty,
                Title = dto.Title,
                Description = dto.Description,
                ContactEmail = dto.ContactEmail,
                PhoneNumber = dto.PhoneNumber,
                ImagePath = dto.ImagePath
            };

            var created = await _service.CreateDepartmentAsync(department);

            var readDto = new DepartmentReadDto
            {
                Id = created.Id,
                Name = created.Name,
                Code = created.Code,
                Faculty = created.Faculty,
                Title = created.Title,
                Description = created.Description
            };

            return CreatedAtAction(nameof(Get), new { id = created.Id }, readDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<DepartmentReadDto>> Put(int id, [FromBody] DepartmentUpdateDto dto)
        {
            var department = await _service.GetDepartmentByIdAsync(id);
            if (department == null) return NotFound();

            // Update fields
            department.Name = dto.Name;
            department.Code = dto.Code;
            department.Faculty = dto.Faculty;
            department.Title = dto.Title;
            department.Description = dto.Description;
            department.ContactEmail = dto.ContactEmail;
            department.PhoneNumber = dto.PhoneNumber;
            department.ImagePath = dto.ImagePath;

            var updated = await _service.UpdateDepartmentAsync(department);

            var readDto = new DepartmentReadDto
            {
                Id = updated.Id,
                Name = updated.Name,
                Code = updated.Code,
                Faculty = updated.Faculty,
                Title = updated.Title,
                Description = updated.Description
            };

            return Ok(readDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteDepartmentAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
