using System.Net;

namespace FamilyHubs.ReferralService.Shared.Dto;

public record UpdateConnectionRequestsSentMetricDto(HttpStatusCode HttpStatusCode, long? ConnectionRequestId);
