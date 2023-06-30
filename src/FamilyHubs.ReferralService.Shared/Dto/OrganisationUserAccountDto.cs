namespace FamilyHubs.ReferralService.Shared.Dto;

public record OrganisationUserAccountDto : DtoBase<long>
{
    public virtual required OrganisationDto Organisation { get; set; }
    public virtual required UserAccountDto UserAccount { get; set; }
}
