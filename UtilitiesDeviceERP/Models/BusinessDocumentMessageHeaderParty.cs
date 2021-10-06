using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderParty
    {
        private PartyInternalID internalIDField;
        private PartyStandardID[] standardIDField;
        private BusinessDocumentMessageHeaderPartyContactPerson contactPersonField;

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
        public PartyInternalID InternalID
        {
            get =>
                this.internalIDField;
            set
            {
                this.internalIDField = value;
                this.RaisePropertyChanged("InternalID");
            }
        }

        [XmlElement("StandardID", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public PartyStandardID[] StandardID
        {
            get =>
                this.standardIDField;
            set
            {
                this.standardIDField = value;
                this.RaisePropertyChanged("StandardID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 2)]
        public BusinessDocumentMessageHeaderPartyContactPerson ContactPerson
        {
            get =>
                this.contactPersonField;
            set
            {
                this.contactPersonField = value;
                this.RaisePropertyChanged("ContactPerson");
            }
        }
    }
}