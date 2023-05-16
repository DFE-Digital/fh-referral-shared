﻿namespace FamilyHubs.ReferralService.Shared.Dto;



public record ReferralDto : DtoBase<long>
{
    public required string ReasonForSupport { get; set; }
    public required string EngageWithFamily { get; set; }
    public required RecipientDto RecipientDto { get; set; }
    public required ReferrerDto ReferrerDto { get; set; }
    public required ReferralServiceDto ReferralServiceDto { get; set; }
    public required ReferralStatusDto Status { get; set; }

    public string? ReasonForDecliningSupport { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastModified { get; set; }
    
    public override int GetHashCode()
    {
        var result =
           EqualityComparer<string?>.Default.GetHashCode(ReasonForSupport) * -1521134295 +
           EqualityComparer<string?>.Default.GetHashCode(EngageWithFamily) * -1521134295;

        if (!string.IsNullOrEmpty(ReasonForDecliningSupport))
            result += EqualityComparer<string>.Default.GetHashCode(ReasonForDecliningSupport);

        return result;
    }

    public virtual bool Equals(ReferralDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(ReasonForSupport, other.ReasonForSupport) &&
            EqualityComparer<string>.Default.Equals(EngageWithFamily, other.EngageWithFamily) &&
            EqualityComparer<string>.Default.Equals(ReasonForDecliningSupport, other.ReasonForDecliningSupport);
    }
}
