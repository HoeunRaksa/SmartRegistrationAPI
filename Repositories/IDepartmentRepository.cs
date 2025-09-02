using SmartRegistrationAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRegistrationAPI.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id); // <-- corrected
        Task<Department> AddAsync(Department department);
        Task<Department> UpdateAsync(Department department);
        Task<bool> DeleteAsync(int id);
    }
}
