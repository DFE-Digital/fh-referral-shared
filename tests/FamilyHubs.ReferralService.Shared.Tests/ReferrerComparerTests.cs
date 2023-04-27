using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferrerComparerTests : DtoComparerTestBase<ReferrerDto, string>
{
    public ReferrerComparerTests() : base(new ReferrerDto
    {
        Id = 1,
        EmailAddress = "Bob.Referrer@email.com",

    }, new ReferrerDto
    {
        Id = 1,
        EmailAddress = "Bob.Referrer@email.com",


    }, dto => dto.EmailAddress)
    {

    }
}