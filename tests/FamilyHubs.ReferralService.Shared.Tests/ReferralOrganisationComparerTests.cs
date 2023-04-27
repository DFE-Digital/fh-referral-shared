using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralOrganisationComparerTests : DtoComparerTestBase<ReferralOrganisationDto, string>
{
    public ReferralOrganisationComparerTests() : base(new ReferralOrganisationDto
    {
        Id = 1,
        Name = "Organisation",
        Description = "Organisation Description",

    }, new ReferralOrganisationDto
    {
        Id = 1,
        Name = "Organisation",
        Description = "Organisation Description",

    }, dto => dto.Name)
    {

    }
}
