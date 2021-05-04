using Inventory.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory
{
    public class TeamAdminHandler : AuthorizationHandler<TeamAdmin>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TeamAdmin requirement)
        {
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string TeamAdminList;
            using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
            {
                TeamAdminList = sr.ReadToEnd();
            }
            List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);

            if (adminList.Contains(adminList.Find(a => a.Admin == identity)))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
