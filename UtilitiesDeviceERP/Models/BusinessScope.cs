using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessScope
    {
        public BusinessScopeTypeCode typeCode { get; set; }
        public BusinessScopeInstanceID instanceID { get; set; }
        public BusinessScopeID id { get; set; }
    }
}