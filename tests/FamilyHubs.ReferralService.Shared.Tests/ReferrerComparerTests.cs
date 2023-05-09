using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferrerComparerTests : DtoComparerTestBase<ReferrerDto, string>
{
    public ReferrerComparerTests() : base(new ReferrerDto
    {
        Id = 1,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        Role = "Role",
        Team = "Team"

    }, new ReferrerDto
    {
        Id = 2,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        Role = "Role",
        Team = "Team"


    }, dto => dto.EmailAddress)
    {

    }
}