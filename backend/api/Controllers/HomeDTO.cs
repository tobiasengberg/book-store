using api.Models;

namespace api.Controllers;

public class HomeDTO
{
    public List<Campaign>? Campaigns { get; set; } = new();
    public List<Product>? Products { get; set; } = new();
}