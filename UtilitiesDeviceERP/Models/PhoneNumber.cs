using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class PhoneNumber
    {
        private string areaIDField;
        private string subscriberIDField;
        private string extensionIDField;
        private string countryCodeField;
        private string countryDiallingCodeField;
        private MEDIUM_Name countryNameField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 0)]
        public string AreaID
        {
            get =>
                this.areaIDField;
            set
            {
                this.areaIDField = value;
                this.RaisePropertyChanged("AreaID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 1)]
        public string SubscriberID
        {
            get =>
                this.subscriberIDField;
            set
            {
                this.subscriberIDField = value;
                this.RaisePropertyChanged("SubscriberID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 2)]
        public string ExtensionID
        {
            get =>
                this.extensionIDField;
            set
            {
                this.extensionIDField = value;
                this.RaisePropertyChanged("ExtensionID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 3)]
        public string CountryCode
        {
            get =>
                this.countryCodeField;
            set
            {
                this.countryCodeField = value;
                this.RaisePropertyChanged("CountryCode");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 4)]
        public string CountryDiallingCode
        {
            get =>
                this.countryDiallingCodeField;
            set
            {
                this.countryDiallingCodeField = value;
                this.RaisePropertyChanged("CountryDiallingCode");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 5)]
        public MEDIUM_Name CountryName
        {
            get =>
                this.countryNameField;
            set
            {
                this.countryNameField = value;
                this.RaisePropertyChanged("CountryName");
            }
        }
    }
}