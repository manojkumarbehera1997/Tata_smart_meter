using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo
    {
        public PartyInternalID partyInternalID { get; set; }
        public ProductInternalID partNumberID{ get; set; }
        public string serialID { get; set; }
    }
}