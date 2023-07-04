using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class UserAccountComparerTests : DtoComparerTestBase<UserAccountDto, string>
{
    public UserAccountComparerTests() : base(new UserAccountDto
    {
        Id = 1,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        Team = "Team",
        OrganisationUserAccountDtos = new List<UserAccountOrganisationDto>()

    }, new UserAccountDto
    {
        Id = 2,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        Team = "Team",
        OrganisationUserAccountDtos = new List<UserAccountOrganisationDto>()


    }, dto => dto.EmailAddress)
    {

    }
}
