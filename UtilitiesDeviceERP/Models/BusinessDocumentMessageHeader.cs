using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class BusinessDocumentMessageHeader
    {
        private BusinessDocumentMessageID idField;
        private UUID uUIDField;
        private BusinessDocumentMessageID referenceIDField;
        private UUID referenceUUIDField;
        private DateTime creationDateTimeField;
        private bool testDataIndicatorField;
        private bool testDataIndicatorFieldSpecified;
        private bool reconciliationIndicatorField;
        private bool reconciliationIndicatorFieldSpecified;
        private string senderBusinessSystemIDField;
        private string recipientBusinessSystemIDField;
        private BusinessDocumentMessageHeaderParty senderPartyField;
        private BusinessDocumentMessageHeaderParty[] recipientPartyField;
        private BusinessScope[] businessScopeField;

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
        public BusinessDocumentMessageID ID
        {
            get =>
                this.idField;
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 1)]
        public UUID UUID
        {
            get =>
                this.uUIDField;
            set
            {
                this.uUIDField = value;
                this.RaisePropertyChanged("UUID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 2)]
        public BusinessDocumentMessageID ReferenceID
        {
            get =>
                this.referenceIDField;
            set
            {
                this.referenceIDField = value;
                this.RaisePropertyChanged("ReferenceID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 3)]
        public UUID ReferenceUUID
        {
            get =>
                this.referenceUUIDField;
            set
            {
                this.referenceUUIDField = value;
                this.RaisePropertyChanged("ReferenceUUID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 4)]
        public DateTime CreationDateTime
        {
            get =>
                this.creationDateTimeField;
            set
            {
                this.creationDateTimeField = value;
                this.RaisePropertyChanged("CreationDateTime");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 5)]
        public bool TestDataIndicator
        {
            get =>
                this.testDataIndicatorField;
            set
            {
                this.testDataIndicatorField = value;
                this.RaisePropertyChanged("TestDataIndicator");
            }
        }

        [XmlIgnore]
        public bool TestDataIndicatorSpecified
        {
            get =>
                this.testDataIndicatorFieldSpecified;
            set
            {
                this.testDataIndicatorFieldSpecified = value;
                this.RaisePropertyChanged("TestDataIndicatorSpecified");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 6)]
        public bool ReconciliationIndicator
        {
            get =>
                this.reconciliationIndicatorField;
            set
            {
                this.reconciliationIndicatorField = value;
                this.RaisePropertyChanged("ReconciliationIndicator");
            }
        }

        [XmlIgnore]
        public bool ReconciliationIndicatorSpecified
        {
            get =>
                this.reconciliationIndicatorFieldSpecified;
            set
            {
                this.reconciliationIndicatorFieldSpecified = value;
                this.RaisePropertyChanged("ReconciliationIndicatorSpecified");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 7)]
        public string SenderBusinessSystemID
        {
            get =>
                this.senderBusinessSystemIDField;
            set
            {
                this.senderBusinessSystemIDField = value;
                this.RaisePropertyChanged("SenderBusinessSystemID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 8)]
        public string RecipientBusinessSystemID
        {
            get =>
                this.recipientBusinessSystemIDField;
            set
            {
                this.recipientBusinessSystemIDField = value;
                this.RaisePropertyChanged("RecipientBusinessSystemID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 9)]
        public BusinessDocumentMessageHeaderParty SenderParty
        {
            get =>
                this.senderPartyField;
            set
            {
                this.senderPartyField = value;
                this.RaisePropertyChanged("SenderParty");
            }
        }

        [XmlElement("RecipientParty", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public BusinessDocumentMessageHeaderParty[] RecipientParty
        {
            get =>
                this.recipientPartyField;
            set
            {
                this.recipientPartyField = value;
                this.RaisePropertyChanged("RecipientParty");
            }
        }

        [XmlElement("BusinessScope", Form = XmlSchemaForm.Unqualified, Order = 11)]
        public BusinessScope[] BusinessScope
        {
            get =>
                this.businessScopeField;
            set
            {
                this.businessScopeField = value;
                this.RaisePropertyChanged("BusinessScope");
            }
        }
    }
}