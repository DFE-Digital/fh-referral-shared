namespace FamilyHubs.ReferralService.Shared.Dto;

public record TeamDto : DtoBase<long>
{
    public required string Name { get; set; }

    // A Team is associated with one Organisation
    public required long OrganisationId { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<long>.Default.GetHashCode(OrganisationId) * -1521134295;
    }

    public virtual bool Equals(TeamDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<long>.Default.Equals(OrganisationId, OrganisationId);
    }
}
