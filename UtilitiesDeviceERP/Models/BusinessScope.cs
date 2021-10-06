using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessScope
    {
        private BusinessScopeTypeCode typeCodeField;
        private BusinessScopeInstanceID instanceIDField;
        private BusinessScopeID idField;

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
        public BusinessScopeTypeCode TypeCode
        {
            get =>
                this.typeCodeField;
            set
            {
                this.typeCodeField = value;
                this.RaisePropertyChanged("TypeCode");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 1)]
        public BusinessScopeInstanceID InstanceID
        {
            get =>
                this.instanceIDField;
            set
            {
                this.instanceIDField = value;
                this.RaisePropertyChanged("InstanceID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 2)]
        public BusinessScopeID ID
        {
            get =>
                this.idField;
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
    }
}