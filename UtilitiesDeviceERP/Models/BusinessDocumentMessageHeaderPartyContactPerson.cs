namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderPartyContactPerson
    {
        public ContactPersonInternalID internalIDField { get; set; }
        public string[] organisationFormattedNameField { get; set; }
        public string[] personFormattedNameField { get; set; }
        public PhoneNumber[] phoneNumberField { get; set; }
        public PhoneNumber[] faxNumberField { get; set; }
        public EmailURI[] emailURIField { get; set; }
    }
}