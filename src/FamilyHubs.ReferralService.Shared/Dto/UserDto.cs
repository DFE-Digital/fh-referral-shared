using System.Diagnostics.Metrics;

namespace FamilyHubs.ReferralService.Shared.Dto;

public record UserDto : DtoBase<long>
{
    public required string EmailAddress { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Role { get; set; }
    public string? Team { get; set; }


    public override int GetHashCode()
    {
        var result = EqualityComparer<string>.Default.GetHashCode(EmailAddress) * -1521134295;
        if (!string.IsNullOrEmpty(Name))
            result += EqualityComparer<string>.Default.GetHashCode(Name);
        if (!string.IsNullOrEmpty(PhoneNumber))
            result += EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
        if (!string.IsNullOrEmpty(Role))
            result += EqualityComparer<string>.Default.GetHashCode(Role);
        if (!string.IsNullOrEmpty(Team))
            result += EqualityComparer<string>.Default.GetHashCode(Team);

        return result;

       
    }

    public virtual bool Equals(UserDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(EmailAddress, other.EmailAddress) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
            EqualityComparer<string>.Default.Equals(Role, other.Role) &&
            EqualityComparer<string>.Default.Equals(Team, other.Team);
    }
}
