using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralStatusComparerTests : DtoComparerTestBase<ReferralStatusDto, string>
{
    public ReferralStatusComparerTests() : base(new ReferralStatusDto
    {
        Id = 1,
        Name = "New",
        SortOrder = 1
       
    }, new ReferralStatusDto
    {
        Id = 1,
        Name = "New",
        SortOrder = 1
        

    }, dto => dto.Name)
    {

    }   
}
