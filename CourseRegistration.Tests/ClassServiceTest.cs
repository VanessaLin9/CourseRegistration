using CourseRegistration.Dtos;
using CourseRegistration.Repositories;
using CourseRegistration.Services;
using FluentAssertions;
using Moq;

namespace CourseRegistration.Tests;

public class ClassServiceTest
{
    private readonly ClassService _classService;
    private readonly Mock<IClassRepository> _classRepositoryMock;

    public ClassServiceTest()
    {
        _classRepositoryMock = new Mock<IClassRepository>();
        _classService = new ClassService(_classRepositoryMock.Object);
    }

    [Fact]
    public async Task GetAllClassesAsync_Should_Return_All_Classes()
    {
        // Arrange
        var expected = new List<ClassDto>
        {
            new() {
                Id = 1,
                Title = "Introduction to C#",
                Description = "Basic concepts of C# programming",
                TeacherName = "John Doe"
            }
        };
        _classRepositoryMock
            .Setup(repo => repo.GetAllClassesAsync())
            .ReturnsAsync(expected);

        // Act
        var result = await _classService.GetAllClassesAsync();

        // Assert
        _classRepositoryMock.Verify(repo => repo.GetAllClassesAsync(), Times.Once);
        result.Should().BeEquivalentTo(expected);
    }
}
