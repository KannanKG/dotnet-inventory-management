using System.Collections.Generic;

namespace Inventory.Models
{
    public class DeviceStatusUpdate
    {
        public DeviceStatusUpdate()
        {
            Teams = new List<string>();
            Devices = new List<string>();
        }
        public string TeamName { get; set; }
        public string SerialNumber { get; set; }
        public List<string> Devices { get; set; }
        public List<string> Teams { get; set; }
        public DeviceDetails Device { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }
    public class DeviceDetails
    {
        public DeviceDetails()
        {
            DeviceName = string.Empty;
        }
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }
        public string LastUpdatedDate { get; set; }
        public string DeviceOwner { get; set; }
        public string Status { get; set; }
        public string OwnerTeam { get; set; }
        public string LoanStatus { get; set; }
        public string LoanedTeam { get; set; }
    }
}
