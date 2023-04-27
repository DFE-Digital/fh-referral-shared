using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class ReferralStatusComparerTests : DtoComparerTestBase<ReferralStatusDto, string>
{
    public ReferralStatusComparerTests() : base(new ReferralStatusDto
    {
        Id = 1,
        Status = "Inital-Referral"
       
    }, new ReferralStatusDto
    {
        Id = 1,
        Status = "Inital-Referral"
        

    }, dto => dto.Status)
    {

    }   
}
