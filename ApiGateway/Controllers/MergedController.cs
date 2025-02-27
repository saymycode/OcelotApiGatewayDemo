using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("gateway/combined")]
public class CombinedController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public CombinedController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet]
    public async Task<IActionResult> GetCombinedData()
    {
        try
        {
            // UserService ve CarService'den veri çekme
            var userResponse = await _httpClient.GetStringAsync("http://localhost:5002/api/user");
            var carResponse = await _httpClient.GetStringAsync("http://localhost:5001/api/car");

            // Yanıtları birleştiriyoruz
            var combinedResult = new
            {
                User = userResponse,
                Car = carResponse
            };

            return Ok(combinedResult);
        }
        catch (Exception ex)
        {
            // Hata durumunda 500 yanıtı döner
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
