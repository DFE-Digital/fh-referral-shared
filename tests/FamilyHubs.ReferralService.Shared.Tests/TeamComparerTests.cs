using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class TeamComparerTests : DtoComparerTestBase<TeamDto, string>
{
    public TeamComparerTests() : base(new TeamDto
    {
        Id = 1,
        Name = "Role",
        OrganisationId = 1


    }, new TeamDto
    {
        Id = 2,
        Name = "Role",
        OrganisationId = 1

    }, dto => dto.Name)
    {

    }
}