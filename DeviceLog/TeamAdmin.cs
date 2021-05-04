using Microsoft.AspNetCore.Authorization;

namespace Inventory
{
    public class TeamAdmin : IAuthorizationRequirement
    {
        public TeamAdmin()
        {
            Role = "teamAdmin";
        }
        public string Role { get; set; }
    }
}
