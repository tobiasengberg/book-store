using api.DTO;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;


    public CustomerController(ICustomerService service)
    {
        _service = service;
    }
    [HttpGet]
    // GET
    public CustomerDTO Index()
    {
        CustomerDTO dto = new();

        return dto;
    }
}