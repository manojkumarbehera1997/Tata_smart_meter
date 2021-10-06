using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UtilitiesDeviceERP.Models
{
    public class PartyInternalID
    {
        private string schemeIDField;
        private string schemeAgencyIDField;
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