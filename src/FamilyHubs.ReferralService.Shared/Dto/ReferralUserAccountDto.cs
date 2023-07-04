using System.Diagnostics.Metrics;

namespace FamilyHubs.ReferralService.Shared.Dto;

public record ReferralUserAccountDto : DtoBase<long>
{
    public required string EmailAddress { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public IList<UserAccountRoleDto>? UserAccountRoles { get; set; }
    public string? Team { get; set; }


    public override int GetHashCode()
    {
        var result = EqualityComparer<string>.Default.GetHashCode(EmailAddress) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Name!) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(PhoneNumber!) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Team!) * -1521134295;

        return result;

       
    }

    public virtual bool Equals(ReferralUserAccountDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(EmailAddress, other.EmailAddress) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
            EqualityComparer<string>.Default.Equals(Team, other.Team);
    }
}
