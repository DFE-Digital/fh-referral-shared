using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralStatusComparerTests : DtoComparerTestBase<ReferralStatusDto, string>
{
    public ReferralStatusComparerTests() : base(new ReferralStatusDto
    {
        Id = 1,
        Status = "New"
       
    }, new ReferralStatusDto
    {
        Id = 1,
        Status = "New"
        

    }, dto => dto.Status)
    {

    }   
}
