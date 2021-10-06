using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderParty
    {
        public PartyInternalID internalID { get; set; }
        public PartyStandardID[] standardID { get; set; }
        public BusinessDocumentMessageHeaderPartyContactPerson contactPerson { get; set; }
    }
}