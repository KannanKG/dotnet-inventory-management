using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class DeviceStatusController : Controller
    {
        [HttpGet]
        public IActionResult Index(string team = null, string serialNumber = null)
        {
            var Data = new DeviceStatusUpdate();
            try
            {
                team = team.Replace("+", " ");
                Data.TeamName = team;
            }
            catch
            {
                Data.Error = "Team name can't be empty";
                return View(Data);
            }
            //string line;
            Data.Devices = Directory.GetFiles("./Data/" + team).ToList();
            for (var i = 0; i < Data.Devices.Count(); i++)
            {
                Data.Devices[i] = Data.Devices[i].Replace("./Data/" + team + "\\", "").Replace(".txt", "");
            }
            Data.Teams = Directory.GetDirectories("./Data/").ToList();
            for (var j = 0; j < Data.Teams.Count(); j++)
            {
                Data.Teams[j] = Data.Teams[j].Replace("./Data/", "");
            }
            if (!string.IsNullOrEmpty(serialNumber))
            {
                Data.SerialNumber = serialNumber;
                try
                {
                    var deviceFile = new StreamReader("./Data/" + team + "/" + serialNumber + ".txt");
                    Data.Device = new DeviceDetails();
                    var deviceDetails = deviceFile.ReadToEnd();
                    Data.Device = JsonConvert.DeserializeObject<DeviceDetails>(deviceDetails);
                    deviceFile.Close();
                }
                catch
                {
                    Data.Error = "Device info not found";
                }
            }
            return View(Data);
        }
        [HttpGet]
        public IActionResult StatusUpdate(DeviceDetails details)
        {
            var output = new DeviceStatusUpdate();
            output.Device = details;
            try
            {
                if(details.LoanStatus == null)
                {
                    details.LoanStatus = "false";
                    details.LoanedTeam = "";
                }
                var data = JsonConvert.SerializeObject(details);
                var path = "./Data/" + details.OwnerTeam.Replace("+", " ") + "/" + details.DeviceName + ".txt";
                if (!System.IO.File.Exists(path))
                {
                    using (StreamWriter sw = System.IO.File.CreateText(path))
                    {
                        sw.WriteLine(data);
                    }
                }
                else
                {
                    System.IO.File.WriteAllText(path, data);
                }
                return View(output);
            }
            catch
            {
                output.Error = "There was some error while updating the device status, please try again later.";
                return View(output);
            }
        }
    }
}
