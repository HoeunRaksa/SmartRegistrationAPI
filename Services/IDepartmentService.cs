using SmartRegistrationAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRegistrationAPI.Services;

public interface IDepartmentService
{
    Task<IEnumerable<Department>> GetDepartmentsAsync();
    Task<Department?> GetDepartmentByIdAsync(int id);
    Task<Department> CreateDepartmentAsync(Department department);
    Task<Department> UpdateDepartmentAsync(Department department);
    Task<bool> DeleteDepartmentAsync(int id);
}
