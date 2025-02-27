using AutoMapper;
using CarService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/car")]
public class CarController : ControllerBase
{
    private readonly IMapper _mapper;

    public CarController(IMapper mapper)
    {
        _mapper = mapper;
    }

    // Örnek araba listesi
    private static readonly List<Car> Cars = new List<Car>
    {
        new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Year = 2020 },
        new Car { Id = 1, Brand = "Toyota", Model = "CR-H", Year = 2024 },
        new Car { Id = 2, Brand = "Ford", Model = "Focus", Year = 2019 },
        new Car { Id = 3, Brand = "BMW", Model = "320i", Year = 2021 },
        new Car { Id = 4, Brand = "Audi", Model = "A4", Year = 2022 }
    };

    [HttpGet]
    public IActionResult GetCars([FromQuery] int? id, 
                                 [FromQuery] string? brand, 
                                 [FromQuery] string? model, 
                                 [FromQuery] int? year)
    {
        var carDtos = Cars.Select(c => _mapper.Map<CarDto>(c)).ToList();

        // Dinamik filtreleme
        if (id.HasValue)
            carDtos = carDtos.Where(c => c.Id == id.Value).ToList();

        if (!string.IsNullOrEmpty(brand))
            carDtos = carDtos.Where(c => c.Brand != null && c.Brand.Equals(brand, System.StringComparison.OrdinalIgnoreCase)).ToList();

        if (!string.IsNullOrEmpty(model))
            carDtos = carDtos.Where(c => c.Model != null && c.Model.Equals(model, System.StringComparison.OrdinalIgnoreCase)).ToList();

        if (year.HasValue)
            carDtos = carDtos.Where(c => c.Year == year.Value).ToList();

        return Ok(carDtos);
    }
}
