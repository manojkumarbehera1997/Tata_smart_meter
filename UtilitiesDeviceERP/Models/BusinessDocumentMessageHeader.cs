using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeader
    {
        public BusinessDocumentMessageID id { get; set; }
        public UUID uUID{ get; set; }
        public BusinessDocumentMessageID referenceID { get; set; }
        public UUID referenceUUID { get; set; }
        public DateTime creationDateTime { get; set; }
        public bool testDataIndicator { get; set; }
        public bool reconciliationIndicator { get; set; }
        public string senderBusinessSystemID { get; set; }
        public BusinessDocumentMessageHeaderParty senderParty { get; set; }
        public BusinessDocumentMessageHeaderParty[] recipientParty { get; set; }
        public BusinessScope[] businessScope { get; set; }
    }
}