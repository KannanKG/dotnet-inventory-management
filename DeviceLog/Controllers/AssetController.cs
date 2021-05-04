using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Inventory.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index(string teamName)
        {
            var Teams = Directory.GetDirectories("./Data/");
            var output = new TeamDetails();
            for (var i = 0; i < Teams.Count(); i++)
            {
                output.TeamList.Add(Teams[i].Replace("./Data/", ""));
            }
            if (!string.IsNullOrEmpty(teamName))
            {
                teamName = teamName.Replace("+", " ");
                var Devices = Directory.GetFiles("./Data/" + teamName).ToList();
                if(Devices.Count != 0)
                {
                    foreach (var device in Devices)
                    {
                        var deviceFile = new StreamReader(device);
                        var deviceDetails = deviceFile.ReadToEnd();
                        output.DeviceList.Add(JsonConvert.DeserializeObject<DeviceDetails>(deviceDetails));
                        deviceFile.Close();
                    }
                } else
                {
                    output.Error = "No devices associated to this Team name";
                }
            }
            return View(output);
        }
        public IActionResult Remove(string teamName, string deviceName)
        {
            teamName = teamName.Replace("+", " ");
            deviceName = deviceName.Replace("+", " ");
            if (System.IO.File.Exists("./Data/" + teamName + "/" + deviceName + ".txt"))
            {
                System.IO.File.Delete("./Data/" + teamName + "/" + deviceName + ".txt");
            }
            return RedirectToAction("Index", "Asset", new { teamName = teamName });
        }
    }
    
    public class TeamDetails
    {
        public TeamDetails()
        {
            TeamList = new List<string>();
            DeviceList = new List<DeviceDetails>();
        }
        public List<string> TeamList { get; set; }
        public List<DeviceDetails> DeviceList { get; set; }
        public string Error { get; set; }
    }
}
