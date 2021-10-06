using System;
using System.Collections.Generic;
using UtilitiesDeviceERP.Models;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqMsg
    {
        public BusinessScopeInstanceID businessScopeInstanceID { get; set; }
        public string AgencyIdentificationCode { get; set; }
        public UUID uUIDs { get; set; }
        public string PhoneNumberAreaID { get; set; }
        public string PhoneNumberExtensionID { get; set; }
        public string CountryDiallingCode { get; set; }
        public BusinessScopeTypeCode businessScopeTypeCodes { get; set; }
        public  BusinessScopeID businessScopeIDs  { get; set; }
        public string PhoneNumberSubscriberID { get; set; }
        public string Indicator { get; set; }
        public  UtilitiesDeviceID utilitiesDeviceID { get; set; }
        public string BusinessSystemID { get; set; }
        public  UtilitiesAdvancedMeteringSystemID utilitiesAdvancedMeteringSystemIDs { get; set; }
        public MEDIUM_Name mEDIUM_Names { get; set; }
        public PartyStandardID partyStandardIDs { get; set; }
        public DateTime Date { get; set; }
        public string SerialID { get; set; }
        public ProductInternalID productInternalIDs { get; set; }
        public PartyInternalID partyInternalIDs { get; set; }
        public ContactPersonInternalID contactPersonInternalIDs { get; set; }
        public BusinessDocumentMessageID businessDocumentMessageIDs { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string LANGUAGEINDEPENDENT_LONG_Name { get; set; }
        public string GLOBAL_DateTime { get; set; }
        public string LANGUAGEINDEPENDENT_MEDIUM_Name { get; set; }
        public ProductStandardID_V1 productStandardID_V1s { get; set; }
        public string businessScopeInstanceIDs  { get; set; }
        public string businessDocumentMessageID { get; set; }
        public MEDIUM_Name mEDIUM_Names1 { get; set; }
        public UtilitiesDeviceID utilitiesDeviceIDs { get; set; }
        public BusinessScopeTypeCode businessScopeTypeCode { get; set; }
        public  PartyInternalID partyInternalID { get; set; }
        public UtilsDvceERPSmrtMtrCrteReqMsg utilsDvceERPSmrtMtrCrteReqMsg { get; set; }

        public  UUID uUID { get; set; }
        public  BusinessDocumentMessageHeaderParty businessDocumentMessageHeaderParty { get; set; }
        public  PhoneNumber phoneNumber { get; set; }
        public  BusinessDocumentMessageHeader businessDocumentMessageHeader{ get; set; }
        public  ProductInternalID productInternalID { get; set; }
        public  UtilitiesAdvancedMeteringSystemID utilitiesAdvancedMeteringSystemID { get; set; }
        public  ContactPersonInternalID contactPersonInternalID { get; set; }
        public  BusinessScope businessScopeid { get; set; }
        public  PartyStandardID partyStandardID { get; set; }
        public  UtilsDvceERPSmrtMtrCrteReqUtilsDvce utilsDvceERPSmrtMtrCrteReqUtilsDvce { get; set; }
        public BusinessDocumentMessageHeaderPartyContactPerson businessDocumentMessageHeaderPartyContactPerson { get; set; }
        public EmailURI emailURI { get; set; }
        public  UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo utilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo { get; set; }
        public  UtilsDvceERPSmrtMtrCrteReqSmrtMtr utilsDvceERPSmrtMtrCrteReqSmrtMtr{ get; set; }
        public  ProductStandardID_V1 productStandardID_V1 { get; set; }
        public  BusinessScopeID businessScopeID { get; set; }
    }
}
