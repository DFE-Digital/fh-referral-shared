
using FamilyHubs.ReferralService.Shared.Dto;

namespace FamilyHubs.ReferralService.Shared.CreateUpdateDto;

public record CreateReferralDto(ReferralDto Referral, ConnectionRequestsSentMetricDto Metrics);