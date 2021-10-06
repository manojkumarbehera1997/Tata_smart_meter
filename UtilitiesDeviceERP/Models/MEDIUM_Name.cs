using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class MEDIUM_Name
    {
        private string languageCodeField;
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

        [XmlAttribute(DataType = "language")]
        public string languageCode
        {
            get =>
                this.languageCodeField;
            set
            {
                this.languageCodeField = value;
                this.RaisePropertyChanged("languageCode");
            }
        }

        [XmlText]
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