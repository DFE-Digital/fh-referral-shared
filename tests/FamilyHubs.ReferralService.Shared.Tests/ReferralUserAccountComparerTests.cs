using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralUserAccountComparerTests : DtoComparerTestBase<ReferralUserAccountDto, string>
{
    public ReferralUserAccountComparerTests() : base(new ReferralUserAccountDto
    {
        Id = 1,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        UserAccountRoles = new List<UserAccountRoleDto>(),
        Team = "Team"

    }, new ReferralUserAccountDto
    {
        Id = 2,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        UserAccountRoles = new List<UserAccountRoleDto>(),
        Team = "Team"


    }, dto => dto.EmailAddress)
    {

    }
}