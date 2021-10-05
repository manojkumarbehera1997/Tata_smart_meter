namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderParty
    {
        public PartyInternalID internalIDField { get; set; }
        public PartyStandardID[] standardIDField { get; set; }
        public BusinessDocumentMessageHeaderPartyContactPerson contactPersonField { get; set; }
    }
}