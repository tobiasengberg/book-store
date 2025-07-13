namespace api.Models;

public class Publication
{
    public int Id { get; set; }
    public int Year { get; set; }
    public string Title { get; set; }
    public List<Person> Authors { get; set; }
    public string? Publisher { get; set; }
    public string? ISBN { get; set; }
    public Image Cover { get; set; }
    
    public Publication() { }

    public Publication(int year, string title, List<Person> authors, string? publisher, string? isbn, Image cover)
    {
        Year = year;
        Title = title;
        Authors = authors;
        Publisher = publisher;
        ISBN = isbn;
        Cover = cover;
    }
    
    
}