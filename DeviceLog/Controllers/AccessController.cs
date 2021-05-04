using Inventory.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Inventory.Controllers
{
    [Authorize(Policy = "superAdmin")]
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
            {
                var TeamAdminList = sr.ReadToEnd();
                List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);
                return View("Index", adminList);
            }
        }
        public IActionResult Add(string teamName = null, string adminName = null)
        {
            var Teams = Directory.GetDirectories("./Data/");
            for (var i = 0; i < Teams.Count(); i++)
            {
                Teams[i] = Teams[i].Replace("./Data/", "");
            }
            if (!string.IsNullOrEmpty(teamName))
            {
                string TeamAdminList;
                using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
                {
                    TeamAdminList = sr.ReadToEnd();
                }
                List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);
                if (adminList.Find(s => s.Admin == adminName && s.Team == teamName) == null)
                {
                    var newAdmin = new TeamAdminList();
                    newAdmin.Admin = adminName;
                    newAdmin.Team = teamName.Replace("+", " ");
                    adminList.Add(newAdmin);
                    System.IO.File.WriteAllText("./Roles/TeamAdmin.txt", JsonConvert.SerializeObject(adminList));
                    return RedirectToAction("Index", "Access");
                }
                ViewBag.Message = "This user is already a device admin for the selected account";
            }
            return View(Teams);
        }
        public IActionResult Remove(string teamName, string teamAdmin)
        {
            if(!string.IsNullOrEmpty(teamName) && !string.IsNullOrEmpty(teamAdmin))
            {
                string TeamAdminList;
                using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
                {
                    TeamAdminList = sr.ReadToEnd();
                }
                List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);
                adminList.Remove(adminList.Find(s => s.Admin == teamAdmin && s.Team == teamName));
                System.IO.File.WriteAllText("./Roles/TeamAdmin.txt", JsonConvert.SerializeObject(adminList));
            }
            return RedirectToAction("Index", "Access");
        }
    }
}
