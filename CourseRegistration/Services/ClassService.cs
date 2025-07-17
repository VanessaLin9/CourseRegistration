using CourseRegistration.Dtos;
using CourseRegistration.Interfaces;
namespace CourseRegistration.Services;

public class ClassService : IClassService
{
    public Task<IEnumerable<ClassDto>> GetAllClassesAsync()
    {
        // Simulate fetching data from a database or external service
        var classes = new List<ClassDto>
        {
            new ClassDto
            {
                Id = 1,
                Title = "Introduction to C#",
                Description = "Basic concepts of C# programming",
                TeacherName = "John Doe"
            }
        };

        return Task.FromResult<IEnumerable<ClassDto>>(classes);
    }
}
