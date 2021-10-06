using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class PhoneNumber
    {
        public string areaID { get; set; }
        public string subscriberID { get; set; }
        public string extensionID { get; set; }
        public string countryCode{ get; set; }
        public string countryDiallingCode { get; set; }
        public MEDIUM_Name countryName { get; set; }
    }
}