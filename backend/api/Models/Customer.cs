using Microsoft.AspNetCore.Identity;

namespace api.Models;

public class Customer : IdentityUser
{
    public CustomerProfile CustomerProfile { get; set; }
}