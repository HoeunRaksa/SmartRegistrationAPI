using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Repositories;
namespace SmartRegistrationAPI.Services;
public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _repository;

    public DepartmentService(IDepartmentRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Department>> GetDepartmentsAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<Department?> GetDepartmentByIdAsync(int id)
    {
        return _repository.GetByIdAsync(id);
    }

    public Task<Department> CreateDepartmentAsync(Department department)
    {
        return _repository.AddAsync(department);
    }

    public Task<Department> UpdateDepartmentAsync(Department department)
    {
        return _repository.UpdateAsync(department);
    }

    public Task<bool> DeleteDepartmentAsync(int id)
    {
        return _repository.DeleteAsync(id);
    }
}
