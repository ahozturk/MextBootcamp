using Custify.Domain.Enums;

namespace Custify.Domain;

public class UpdateCustomerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    // public string IdentificationNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }
}
