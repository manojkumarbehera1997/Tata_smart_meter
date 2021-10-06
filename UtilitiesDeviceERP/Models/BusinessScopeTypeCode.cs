using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessScopeTypeCode
    {
        private string listIDField;
        private string listVersionIDField;
        private string listAgencyIDField;
        private string listAgencySchemeIDField;
        private string listAgencySchemeAgencyIDField;
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
        public string listID
        {
            get =>
                this.listIDField;
            set
            {
                this.listIDField = value;
                this.RaisePropertyChanged("listID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string listVersionID
        {
            get =>
                this.listVersionIDField;
            set
            {
                this.listVersionIDField = value;
                this.RaisePropertyChanged("listVersionID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string listAgencyID
        {
            get =>
                this.listAgencyIDField;
            set
            {
                this.listAgencyIDField = value;
                this.RaisePropertyChanged("listAgencyID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string listAgencySchemeID
        {
            get =>
                this.listAgencySchemeIDField;
            set
            {
                this.listAgencySchemeIDField = value;
                this.RaisePropertyChanged("listAgencySchemeID");
            }
        }

        [XmlAttribute(DataType = "token")]
        public string listAgencySchemeAgencyID
        {
            get =>
                this.listAgencySchemeAgencyIDField;
            set
            {
                this.listAgencySchemeAgencyIDField = value;
                this.RaisePropertyChanged("listAgencySchemeAgencyID");
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