namespace FamilyHubs.ReferralService.Shared.Dto;

public class UserAccountServiceDto
{
    public required ReferralServiceDto ReferralService { get; set; }
    public required UserAccountDto UserAccount { get; set; }
}
