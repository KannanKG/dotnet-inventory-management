using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [Authorize(Policy = "superAdmin")]
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            var Teams = Directory.GetDirectories("./Data/");
            for (var i = 0; i < Teams.Count(); i++)
            {
                Teams[i] = Teams[i].Replace("./Data/", "");
            }
            return View(Teams);
        }
        public IActionResult Add(string teamName)
        {
            string Message;
            teamName = teamName.Replace("+", " ");
            if (Directory.Exists("./Data/" + teamName))
            {
                Message = "Team name already exists";
            } else
            {
                Directory.CreateDirectory("./Data/" + teamName);
                Message = "Team name: " + teamName + ", is created successfully";
            }
            return View("Add", Message);
        }
        public IActionResult Remove(string team)
        {
            team = team.Replace("+", " ");
            string Message;
            if (Directory.Exists("./Data/" + team))
            {
                Directory.Delete("./Data/" + team, true);
                Message = team + " has been deleted successfully";
            }
            else
            {
                Message = team + " does not exist in the context or already removed";
            }
            return View("Add", Message);
        }
    }
}
