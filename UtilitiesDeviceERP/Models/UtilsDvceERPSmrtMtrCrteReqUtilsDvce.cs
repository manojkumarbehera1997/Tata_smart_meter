using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqUtilsDvce
    {
        public UtilitiesDeviceID id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string serialID { get; set; }
        public ProductInternalID materialID { get; set; }
        public ProductStandardID_V1 productUniqueItemID{ get; set; }
        public UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo individualMaterialManufacturerInformation { get; set; }
        public string SmartMeter  { get; set; }
    }
}