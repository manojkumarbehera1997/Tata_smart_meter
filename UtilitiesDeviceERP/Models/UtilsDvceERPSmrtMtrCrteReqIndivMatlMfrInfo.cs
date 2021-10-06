using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo
    {
        private PartyInternalID partyInternalIDField;
        private ProductInternalID partNumberIDField;
        private string serialIDField;

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
        public PartyInternalID PartyInternalID
        {
            get =>
                this.partyInternalIDField;
            set
            {
                this.partyInternalIDField = value;
                this.RaisePropertyChanged("PartyInternalID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 1)]
        public ProductInternalID PartNumberID
        {
            get =>
                this.partNumberIDField;
            set
            {
                this.partNumberIDField = value;
                this.RaisePropertyChanged("PartNumberID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 2)]
        public string SerialID
        {
            get =>
                this.serialIDField;
            set
            {
                this.serialIDField = value;
                this.RaisePropertyChanged("SerialID");
            }
        }
    }
}