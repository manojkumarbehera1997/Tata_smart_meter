using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderPartyContactPerson
    {
        public ContactPersonInternalID internalID { get; set; }
        public string[] organisationFormattedName { get; set; }
        public string[] personFormattedName { get; set; }
        public PhoneNumber[] phoneNumber { get; set; }
        public PhoneNumber[] faxNumber { get; set; }
        public EmailURI[] emailURI { get; set; }
    }
}