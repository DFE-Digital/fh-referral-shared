namespace FamilyHubs.ReferralService.Shared.Dto;

public record RoleDto : DtoBase<long>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}
