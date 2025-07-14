using api.Models;

namespace api.DTO;

public class ProductDto
{
    public int Id { get; set; }
    public int Published { get; set; }
    public string? Title { get; set; }
    public List<string> Authors { get; set; } = null!;
    public string? Publisher { get; set; }
    public string? Isbn { get; set; }
    public string? CoverLink { get; set; }
    public string? CoverAlt { get; set; }
    public decimal Price { get; set; }
    public int Rebate { get; set; }
    
}