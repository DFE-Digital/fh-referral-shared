using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralComparerTests : DtoComparerTestBase<ReferralDto, string>
{
    public ReferralComparerTests() : base(new ReferralDto
    {
        Id = 1,
        ReasonForSupport = "Reason For Support",
        EngageWithFamily = "Engage With Family",
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
        ReferrerDto = new ReferrerDto
        {
            Id = 1,
            EmailAddress = "Bob.Referrer@email.com",
        },
        Status = new List<ReferralStatusDto>
                {
                    new ReferralStatusDto
                    {
                        Status = "Inital-Referral"
                    }
                },
        ReferralServiceDto = new ReferralServiceDto
        {
            Id = 1,
            Name = "Service",
            Description = "Service Description",
            ReferralOrganisationDto = new ReferralOrganisationDto
            {
                Id = 1,
                Name = "Organisation",
                Description = "Organisation Description",
            }
        }

    }, new ReferralDto
    {
        Id = 1,
        ReasonForSupport = "Reason For Support",
        EngageWithFamily = "Engage With Family",
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
        ReferrerDto = new ReferrerDto
        {
            Id = 1,
            EmailAddress = "Bob.Referrer@email.com",
        },
        Status = new List<ReferralStatusDto>
                {
                    new ReferralStatusDto
                    {
                        Status = "Inital-Referral"
                    }
                },
        ReferralServiceDto = new ReferralServiceDto
        {
            Id = 1,
            Name = "Service",
            Description = "Service Description",
            ReferralOrganisationDto = new ReferralOrganisationDto
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
