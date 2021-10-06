using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageID
    {
        private string schemeIDField;
        private string schemeAgencyIDField;
        private string schemeAgencySchemeAgencyIDField;
        private string valueField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute(DataType = "token")]
        public string schemeID
        {
            get =>
                this.schemeIDField;
            set
            {
                this.schemeIDField = value;
                this.RaisePropertyChanged("schemeID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string schemeAgencyID
        {
            get =>
                this.schemeAgencyIDField;
            set
            {
                this.schemeAgencyIDField = value;
                this.RaisePropertyChanged("schemeAgencyID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string schemeAgencySchemeAgencyID
        {
            get =>
                this.schemeAgencySchemeAgencyIDField;
            set
            {
                this.schemeAgencySchemeAgencyIDField = value;
                this.RaisePropertyChanged("schemeAgencySchemeAgencyID");
            }
        }

        [XmlText(DataType = "token")]
        public string Value
        {
            get =>
                this.valueField;
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
    }
}