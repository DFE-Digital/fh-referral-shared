using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class UserComparerTests : DtoComparerTestBase<UserDto, string>
{
    public UserComparerTests() : base(new UserDto
    {
        Id = 1,
        Name = "Bob Referrer",
        EmailAddress = "Bob.Referrer@email.com",
        PhoneNumber = "0122 865 278",
        Role = "Role",
        Team = "Team"

    }, new UserDto
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