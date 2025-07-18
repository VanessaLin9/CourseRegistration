using CourseRegistration.Dtos;

namespace CourseRegistration.Repositories;

public interface IClassRepository
{
    Task<IEnumerable<ClassDto>> GetAllClassesAsync();
}