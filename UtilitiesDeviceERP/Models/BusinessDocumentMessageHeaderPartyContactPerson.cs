using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeaderPartyContactPerson
    {
        private ContactPersonInternalID internalIDField;
        private string[] organisationFormattedNameField;
        private string[] personFormattedNameField;
        private PhoneNumber[] phoneNumberField;
        private PhoneNumber[] faxNumberField;
        private EmailURI[] emailURIField;

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
        public ContactPersonInternalID InternalID
        {
            get =>
                this.internalIDField;
            set
            {
                this.internalIDField = value;
                this.RaisePropertyChanged("InternalID");
            }
        }

        [XmlElement("OrganisationFormattedName", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string[] OrganisationFormattedName
        {
            get =>
                this.organisationFormattedNameField;
            set
            {
                this.organisationFormattedNameField = value;
                this.RaisePropertyChanged("OrganisationFormattedName");
            }
        }

        [XmlElement("PersonFormattedName", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string[] PersonFormattedName
        {
            get =>
                this.personFormattedNameField;
            set
            {
                this.personFormattedNameField = value;
                this.RaisePropertyChanged("PersonFormattedName");
            }
        }

        [XmlElement("PhoneNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public PhoneNumber[] PhoneNumber
        {
            get =>
                this.phoneNumberField;
            set
            {
                this.phoneNumberField = value;
                this.RaisePropertyChanged("PhoneNumber");
            }
        }

        [XmlElement("FaxNumber", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public PhoneNumber[] FaxNumber
        {
            get =>
                this.faxNumberField;
            set
            {
                this.faxNumberField = value;
                this.RaisePropertyChanged("FaxNumber");
            }
        }

        [XmlElement("EmailURI", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public EmailURI[] EmailURI
        {
            get =>
                this.emailURIField;
            set
            {
                this.emailURIField = value;
                this.RaisePropertyChanged("EmailURI");
            }
        }
    }
}