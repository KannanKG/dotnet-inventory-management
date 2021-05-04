using Microsoft.AspNetCore.Authorization;

namespace Inventory
{
    public class SuperAdmin : IAuthorizationRequirement
    {
        public SuperAdmin()
        {
            Role = "superAdmin";
        }
        public string Role { get; set; }

        //string Role = userRole();
        //public static string userRole()
        //{
        //    var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
        //    var user = "";
        //    if (identity.Name.Split('\\')[1] == "kannanganesan")
        //    {
        //        user = "superAdmin";
        //    }
        //    return user;
        //}
    }
}
