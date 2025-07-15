using api.Models;

namespace api.DTO;

public class CustomerDTO
{
    public List<Order> Orders { get; set; }
    public Account Account { get; set; }
    public List<Invoice> Invoices { get; set; }
    public string PaymentOptions { get; set; }
}