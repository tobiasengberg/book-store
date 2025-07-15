using api.Controllers;

namespace api.Models;

public class HomeService : IHomeService
{
    private readonly IProductRepo _context;

    public HomeService(IProductRepo context)
    {
        _context = context;
    }
    public HomeDTO Get()
    {
        HomeDTO home = new();
        Campaign campaign1 = new Campaign("Campaigne 1");
        Campaign campaign2 = new Campaign("Campaigne 2");
        Campaign campaign3 = new Campaign("Campaigne 3");
        Campaign campaign4 = new Campaign("Campaigne 4");
        home.Campaigns.Add(campaign1);
        home.Campaigns.Add(campaign2);
        home.Campaigns.Add(campaign3);
        home.Campaigns.Add(campaign4);
        home.Products.Add(_context.GetProductById(4));
        home.Products.Add(_context.GetProductById(8));
        return home;
    }
}