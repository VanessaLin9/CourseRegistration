using CourseRegistration.Dtos;
using CourseRegistration.Interfaces;
using CourseRegistration.Repositories;

namespace CourseRegistration.Services;

public class ClassService : IClassService
{
    private readonly IClassRepository _classRepository;

    public ClassService(IClassRepository classRepository)
    {
        _classRepository = classRepository;
    }

    public async Task<IEnumerable<ClassDto>> GetAllClassesAsync()
    {
        return await _classRepository.GetAllClassesAsync(); 
    }
}
