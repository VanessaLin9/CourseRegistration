using CourseRegistration.Controllers;
using CourseRegistration.Dtos;
using Moq;
using FluentAssertions;
using Xunit;
using CourseRegistration.Interfaces;

namespace CourseRegistration.Tests;

public class ClassControllerTests
{
    private readonly ClassController _controller;
    
    private readonly Mock<IClassService> _classServiceMock;

    public ClassControllerTests()
    {
        _classServiceMock = new Mock<IClassService>();
        _controller = new ClassController(_classServiceMock.Object);
    }

    [Fact]
    public async Task GetAllClasses_Should_Return_ClassList()
    {
        // Arrange
        var expected = new[] {
            new ClassDto
            {
                Id = 1,
                Title = "Introduction to C#",
                Description = "Basic concepts of C# programming",
                TeacherName = "John Doe"
            },
        };
        _classServiceMock
            .Setup(service => service.GetAllClassesAsync())
            .ReturnsAsync(expected);

        // Act
        var ClassDto = await _controller.GetAllClasses();

        // Assert
        // ClassDto.Should().BeNull();
        ClassDto.Should().BeEquivalentTo(expected);
    }
}
