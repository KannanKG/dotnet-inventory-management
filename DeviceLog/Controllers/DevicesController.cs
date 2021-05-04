using Inventory.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Inventory.Controllers
{
    [Authorize(Policy = "teamAdmin")]
    public class DevicesController : Controller
    {
        public IActionResult Index()
        {
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string TeamAdminList;
            using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
            {
                TeamAdminList = sr.ReadToEnd();
            }
            List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);
            var output = new List<DeviceDetails>();
            List<string> teams = new List<string>();
            foreach(var team in adminList)
            {
                if(team.Admin == identity)
                {
                    teams.Add(team.Team);
                }
            }
            foreach(var team in teams)
            {
                var Devices = Directory.GetFiles("./Data/" + team).ToList();
                foreach(var device in Devices)
                {
                    var deviceFile = new StreamReader(device);
                    var deviceDetails = deviceFile.ReadToEnd();
                    output.Add(JsonConvert.DeserializeObject<DeviceDetails>(deviceDetails));
                    deviceFile.Close();
                }
            }
            return View(output);
        }
        public IActionResult Add(string teamName, string deviceName, string serialNumber)
        {
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string TeamAdminList;
            using (StreamReader sr = new StreamReader("./Roles/TeamAdmin.txt"))
            {
                TeamAdminList = sr.ReadToEnd();
            }
            List<TeamAdminList> adminList = JsonConvert.DeserializeObject<List<TeamAdminList>>(TeamAdminList);
            var output = new DeviceStatusUpdate();
            foreach (var team in adminList)
            {
                if (team.Admin == identity)
                {
                    output.Teams.Add(team.Team);
                }
            }
            if (!string.IsNullOrEmpty(teamName) && !string.IsNullOrEmpty(deviceName))
            {
                teamName = teamName.Replace("+", " ");
                deviceName = deviceName.Replace("+", " ");
                if (System.IO.File.Exists("./Data/" + teamName + "/" + deviceName + ".txt"))
                {
                    output.Error = "This device is already associated to your account, please contact component owner to know more information info";
                }
                else
                {
                    using (StreamWriter sw = System.IO.File.CreateText("./Data/" + teamName + "/" + deviceName + ".txt"))
                    {
                        var deviceDetails = new DeviceDetails();
                        deviceDetails.DeviceName = deviceName;
                        deviceDetails.SerialNumber = serialNumber?.Replace("+", " ");
                        deviceDetails.LastUpdatedDate = DateTime.Now.ToString();
                        deviceDetails.DeviceOwner = identity;
                        deviceDetails.OwnerTeam = teamName;
                        deviceDetails.Status = "";
                        deviceDetails.LoanStatus = "";
                        deviceDetails.LoanedTeam = "";
                        sw.WriteLine(JsonConvert.SerializeObject(deviceDetails));
                        output.Message = "Device name: " + deviceName + ", is created successfully, and associated to your account";
                    }
                }
            }
            return View(output);
        }
        public IActionResult Remove(string teamName, string deviceName)
        {
            teamName = teamName.Replace("+", " ");
            deviceName = deviceName.Replace("+", " ");
            if (System.IO.File.Exists("./Data/" + teamName + "/" + deviceName + ".txt")){
                System.IO.File.Delete("./Data/" + teamName + "/" + deviceName + ".txt");
            }
            return RedirectToAction("Index", "Devices");
        }
    }
}
