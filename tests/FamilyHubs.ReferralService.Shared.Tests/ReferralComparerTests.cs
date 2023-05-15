using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralComparerTests : DtoComparerTestBase<ReferralDto, string>
{
    public ReferralComparerTests() : base(new ReferralDto
    {
        Id = 1,
        ReasonForSupport = "Reason For Support",
        EngageWithFamily = "Engage With Family",
        ReasonForDecliningSupport = "Reason For Declining Support",
        RecipientDto = new RecipientDto
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
        },
        TeamDto = new TeamDto
        { 
            Id = 1,
            Name = "Team",
            OrganisationId = 1,   
        },
        UserDto = new UserDto
        {
            Id = 1,
            Name = "Bob Referrer",
            EmailAddress = "Bob.Referrer@email.com",
            PhoneNumber = "0122 865 278",
            Role = "Role",
            Team = "Team"
        },
        Status = new StatusDto
        {
            Id = 1,
            Name = "New"
        },
        ServiceDto = new ServiceDto
        {
            Id = 1,
            Name = "Service",
            Description = "Service Description",
            ReferralOrganisationDto = new OrganisationDto
            {
                Id = 1,
                Name = "Organisation",
                Description = "Organisation Description",
            }
        }

    }, 
    new ReferralDto
    {
        Id = 2,
        ReasonForSupport = "Reason For Support",
        EngageWithFamily = "Engage With Family",
        ReasonForDecliningSupport = "Reason For Declining Support",
        RecipientDto = new RecipientDto
        {
            Id = 2,
            Name = "Joe Blogs",
            Email = "JoeBlog@email.com",
            Telephone = "078123456",
            TextPhone = "078123456",
            AddressLine1 = "Address Line 1",
            AddressLine2 = "Address Line 2",
            TownOrCity = "Town or City",
            Country = "Country",
            PostCode = "B30 2TV"
        },
        UserDto = new UserDto
        {
            Id = 2,
            Name = "Bob Referrer",
            EmailAddress = "Bob.Referrer@email.com",
            PhoneNumber = "0122 865 278",
            Role = "Role",
            Team = "Team"
        },
        TeamDto = new TeamDto
        {
            Id = 1,
            Name = "Team",
            OrganisationId = 1,
        },
        Status = new StatusDto
        {
            Id = 1,
            Name = "New"
        },
        ServiceDto = new ServiceDto
        {
            Id = 2,
            Name = "Service",
            Description = "Service Description",
            ReferralOrganisationDto = new OrganisationDto
            {
                Id = 2,
                Name = "Organisation",
                Description = "Organisation Description",
            }
        }


    }, dto => dto.ReasonForSupport)
    {

    }
}
