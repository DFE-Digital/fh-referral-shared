using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class OrganisationComparerTests : DtoComparerTestBase<OrganisationDto, string>
{
    public OrganisationComparerTests() : base(new OrganisationDto
    {
        Id = 1,
        Name = "Organisation",
        Description = "Organisation Description",

    }, new OrganisationDto
    {
        Id = 2,
        Name = "Organisation",
        Description = "Organisation Description",

    }, dto => dto.Name)
    {

    }
}
