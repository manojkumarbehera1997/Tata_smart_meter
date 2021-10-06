using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqSmrtMtr
    {
        private UtilitiesAdvancedMeteringSystemID utilitiesAdvancedMeteringSystemIDField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 0)]
        public UtilitiesAdvancedMeteringSystemID UtilitiesAdvancedMeteringSystemID
        {
            get =>
                this.utilitiesAdvancedMeteringSystemIDField;
            set
            {
                this.utilitiesAdvancedMeteringSystemIDField = value;
                this.RaisePropertyChanged("UtilitiesAdvancedMeteringSystemID");
            }
        }
    }
}