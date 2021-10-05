using System;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqUtilsDvce
    {
        public UtilitiesDeviceID idField { get; set; }
        public DateTime startDateField { get; set; }
        public DateTime endDateField { get; set; }
        public string serialIDField { get; set; }
        public ProductInternalID materialIDField { get; set; }
        public ProductStandardID_V1 productUniqueItemIDField { get; set; }
        public UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo individualMaterialManufacturerInformationField { get; set; }
        public UtilsDvceERPSmrtMtrCrteReqSmrtMtr smartMeterField { get; set; }
    }
}