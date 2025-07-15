namespace api.Models;

public class Campaign
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public Campaign(string title)
    {
        Title = title;
    }
}