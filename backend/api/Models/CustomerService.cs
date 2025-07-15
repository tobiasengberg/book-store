namespace api.Models;

public class CustomerService : ICustomerService
{
    public Customer GetCurrentUser()
    {
        return new Customer();
    }
}