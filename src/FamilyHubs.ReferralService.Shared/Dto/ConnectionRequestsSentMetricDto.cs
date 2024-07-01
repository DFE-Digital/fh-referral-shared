
namespace FamilyHubs.ReferralService.Shared.Dto;

//todo: UserOrganisationId should really come in through the usual DTOs/entities
// This already exists: Referral.ReferralUserAccountDto.OrganisationUserAccounts.Organisation.Id
// However, OrganisationUserAccounts is not currently used, and the modelling appears to be incorrect
// It's outside the scope of adding metrics to fix that, so we'll just add this for now
public record ConnectionRequestsSentMetricDto(long UserOrganisationId);
