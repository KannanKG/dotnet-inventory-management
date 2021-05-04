using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Inventory
{
    public class SuperAdminHandler : AuthorizationHandler<SuperAdmin>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SuperAdmin requirement)
        {
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            var superAdminList = new StreamReader("./Roles/SuperAdmin.txt");
            var adminList = superAdminList.ReadToEnd();

            if (identity == adminList)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
