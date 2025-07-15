namespace api.Models;

public class Account
{
    public int Id { get; set; }
    public EMailPreferences EMailPreferences { get; set; }
    public Address Address { get; set; }
}