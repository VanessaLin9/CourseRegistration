using CourseRegistration.Dtos;
using Microsoft.AspNetCore.Mvc;
using CourseRegistration.Interfaces;

namespace CourseRegistration.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClassController(IClassService classService) : ControllerBase
{
    private readonly IClassService _classService = classService;

    [HttpGet]
    public async Task<IEnumerable<ClassDto>> GetAllClasses()
    {
        return await _classService.GetAllClassesAsync();
    }
}
