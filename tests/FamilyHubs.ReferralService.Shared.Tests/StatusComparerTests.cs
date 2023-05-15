using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class StatusComparerTests : DtoComparerTestBase<StatusDto, string>
{
    public StatusComparerTests() : base(new StatusDto
    {
        Id = 1,
        Name = "New"
       
    }, new StatusDto
    {
        Id = 1,
        Name = "New"
        

    }, dto => dto.Name)
    {

    }   
}
