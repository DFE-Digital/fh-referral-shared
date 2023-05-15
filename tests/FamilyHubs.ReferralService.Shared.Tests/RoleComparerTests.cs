using FamilyHubs.ReferralService.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHubs.ReferralService.Shared.Tests;

public class RoleComparerTests : DtoComparerTestBase<RoleDto, string>
{
    public RoleComparerTests() : base(new RoleDto
    {
        Id = 1,
        Name = "Role",
        

    }, new RoleDto
    {
        Id = 2,
        Name = "Role",

    }, dto => dto.Name)
    {

    }
}