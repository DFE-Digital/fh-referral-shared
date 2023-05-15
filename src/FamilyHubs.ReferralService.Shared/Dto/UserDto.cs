namespace FamilyHubs.ReferralService.Shared.Dto;

public record UserDto : DtoBase<long>
{
    public required string EmailAddress { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public required long OrganisationId { get; set; }

    public override int GetHashCode()
    {
        var result = EqualityComparer<string>.Default.GetHashCode(EmailAddress) * -1521134295 +
                     EqualityComparer<long>.Default.GetHashCode(OrganisationId) * -1521134295;
        if (!string.IsNullOrEmpty(Name))
            result += EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295;
        if (!string.IsNullOrEmpty(PhoneNumber))
            result += EqualityComparer<string>.Default.GetHashCode(PhoneNumber) * -1521134295;
       

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
            EqualityComparer<long>.Default.Equals(OrganisationId, other.OrganisationId);


    }
}
