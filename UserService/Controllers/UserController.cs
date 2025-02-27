using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserService.Models;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IMapper _mapper;

    public UserController(IMapper mapper)
    {
        _mapper = mapper;
    }

    // Örnek kullanıcı listesi
    private static readonly List<User> Users = new List<User>
    {
        new User { Id = 1, Name = "John Doe", Email = "john@example.com", Age = 30, City = "İzmir" },
        new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Age = 25, City = "Ankara" },
        new User { Id = 3, Name = "Bob Johnson", Email = "bob@example.com", Age = 22, City = "İstanbul" }
    };

    [HttpGet]
    public IActionResult GetUsers([FromQuery] int? id, 
                                  [FromQuery] string? name, 
                                  [FromQuery] string? email, 
                                  [FromQuery] int? age, 
                                  [FromQuery] string? city)
    {
        var userDtos = Users.Select(u => _mapper.Map<UserDto>(u)).ToList();

        // Dinamik filtreleme
        if (id.HasValue)
            userDtos = userDtos.Where(u => u.Id == id.Value).ToList();

        if (!string.IsNullOrEmpty(name))
            userDtos = userDtos.Where(u => u.Name != null && u.Name.Contains(name, System.StringComparison.OrdinalIgnoreCase)).ToList();

        if (!string.IsNullOrEmpty(email))
            userDtos = userDtos.Where(u => u.Email != null && u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase)).ToList();

        if (age.HasValue)
            userDtos = userDtos.Where(u => u.Age == age.Value).ToList();

        if (!string.IsNullOrEmpty(city))
            userDtos = userDtos.Where(u => u.City != null && u.City.Equals(city, System.StringComparison.OrdinalIgnoreCase)).ToList();

        // Eğer sonuç bulunamazsa NotFound döndür
        if (!userDtos.Any())
            return NotFound(new { Message = "No users found with the provided criteria." });

        return Ok(userDtos);
    }
}
