using CourseRegistration.Dtos;

namespace CourseRegistration.Repositories;

public class ClassRepository : IClassRepository
{
    public async Task<IEnumerable<ClassDto>> GetAllClassesAsync()
    {
        // Simulate fetching data from a database or external service
        var classes = new List<ClassDto>
        {
            new() {
                Id = 1,
                Title = "Introduction to C#",
                Description = "Basic concepts of C# programming",
                TeacherName = "John Doe"
            }
        };

        return await Task.FromResult(classes);
    }
}