using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IHomeService _service;


    public HomeController(IHomeService service)
    {
        _service = service;
    }
    // GET
    [HttpGet]
    public HomeDTO Index()
    {
        return _service.Get();
    }
}