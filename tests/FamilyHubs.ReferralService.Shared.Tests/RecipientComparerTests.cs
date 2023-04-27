using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class RecipientComparerTests : DtoComparerTestBase<RecipientDto, string>
{
    public RecipientComparerTests() : base(new RecipientDto
    {
        Id = 1,
        Name = "Joe Blogs",
        Email = "JoeBlog@email.com",
        Telephone = "078123456",
        TextPhone = "078123456",
        AddressLine1 = "Address Line 1",
        AddressLine2 = "Address Line 2",
        TownOrCity = "Town or City",
        Country = "Country",
        PostCode = "B30 2TV"
    }, new RecipientDto
    {
        Id = 1,
        Name = "Joe Blogs",
        Email = "JoeBlog@email.com",
        Telephone = "078123456",
        TextPhone = "078123456",
        AddressLine1 = "Address Line 1",
        AddressLine2 = "Address Line 2",
        TownOrCity = "Town or City",
        Country = "Country",
        PostCode = "B30 2TV"

    }, dto => dto.Email)
    {

    }   
}