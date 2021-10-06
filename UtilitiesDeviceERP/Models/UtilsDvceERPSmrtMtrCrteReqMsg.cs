using System;
using System.Collections.Generic;
using UtilitiesDeviceERP.Models;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqMsg
    {
        public BusinessDocumentMessageHeader messageHeader{ get; set; }
        public UtilsDvceERPSmrtMtrCrteReqUtilsDvce utilitiesDevice { get; set; }
    }
}
