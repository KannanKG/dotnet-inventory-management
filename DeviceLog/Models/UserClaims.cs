using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class UserClaims
    {
        public string Name { get; set; }
        public Claim ClaimName { get; set; }
    }
}
