using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class EmailURI
    {
        private string schemeIDField;
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

        [XmlText(DataType = "anyURI")]
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