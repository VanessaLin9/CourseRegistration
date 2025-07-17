using CourseRegistration.Dtos;

namespace CourseRegistration.Interfaces;

public interface IClassService
{
    Task<IEnumerable<ClassDto>> GetAllClassesAsync();
}