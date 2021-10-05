using System;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeader
    {
        public BusinessDocumentMessageID idField { get; set; }
        public UUID uUIDField { get; set; }
        public BusinessDocumentMessageID referenceIDField { get; set; }
        public UUID referenceUUIDField { get; set; }
        public DateTime creationDateTimeField { get; set; }
        public bool testDataIndicatorField { get; set; }
        public bool testDataIndicatorFieldSpecified { get; set; }
        public bool reconciliationIndicatorField { get; set; }
        public bool reconciliationIndicatorFieldSpecified { get; set; }
        public string senderBusinessSystemIDField { get; set; }
        public string recipientBusinessSystemIDField { get; set; }
        public BusinessDocumentMessageHeaderParty senderPartyField { get; set; }
        public BusinessDocumentMessageHeaderParty[] recipientPartyField { get; set; }
        public BusinessScope[] businessScopeField { get; set; }
    }
}