using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ServiceComparerTests : DtoComparerTestBase<ServiceDto, string>
{
    public ServiceComparerTests() : base(new ServiceDto
    {
        Id = 1,
        Name = "Organisation",
        Description = "Service Description",
        ReferralOrganisationDto = new OrganisationDto
        {
            Id = 1,
            Name = "Organisation",
            Description = "Organisation Description",
        }

    }, new ServiceDto
    {
        Id = 2,
        Name = "Organisation",
        Description = "Service Description",
        ReferralOrganisationDto = new OrganisationDto
        {
            Id = 2,
            Name = "Organisation",
            Description = "Organisation Description",
        }

    }, dto => dto.Name)
    {

    }
}
