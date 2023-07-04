namespace FamilyHubs.ReferralService.Shared.Dto;

public record UserAccountOrganisationDto : DtoBase<long>
{
    public required OrganisationDto Organisation { get; set; }
    public required UserAccountDto UserAccount { get; set; }
}
