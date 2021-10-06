using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UtilitiesDeviceERP.Models
{
    public class UtilsDvceERPSmrtMtrCrteReqUtilsDvce
    {
        private UtilitiesDeviceID idField;
        private DateTime startDateField;
        private DateTime endDateField;
        private string serialIDField;
        private ProductInternalID materialIDField;
        private ProductStandardID_V1 productUniqueItemIDField;
        private UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo individualMaterialManufacturerInformationField;
        private UtilsDvceERPSmrtMtrCrteReqSmrtMtr smartMeterField;

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
        public UtilitiesDeviceID ID
        {
            get =>
                this.idField;
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "date", Order = 1)]
        public DateTime StartDate
        {
            get =>
                this.startDateField;
            set
            {
                this.startDateField = value;
                this.RaisePropertyChanged("StartDate");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "date", Order = 2)]
        public DateTime EndDate
        {
            get =>
                this.endDateField;
            set
            {
                this.endDateField = value;
                this.RaisePropertyChanged("EndDate");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, DataType = "token", Order = 3)]
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

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 4)]
        public ProductInternalID MaterialID
        {
            get =>
                this.materialIDField;
            set
            {
                this.materialIDField = value;
                this.RaisePropertyChanged("MaterialID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 5)]
        public ProductStandardID_V1 ProductUniqueItemID
        {
            get =>
                this.productUniqueItemIDField;
            set
            {
                this.productUniqueItemIDField = value;
                this.RaisePropertyChanged("ProductUniqueItemID");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 6)]
        public UtilsDvceERPSmrtMtrCrteReqIndivMatlMfrInfo IndividualMaterialManufacturerInformation
        {
            get =>
                this.individualMaterialManufacturerInformationField;
            set
            {
                this.individualMaterialManufacturerInformationField = value;
                this.RaisePropertyChanged("IndividualMaterialManufacturerInformation");
            }
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified, Order = 7)]
        public UtilsDvceERPSmrtMtrCrteReqSmrtMtr SmartMeter
        {
            get =>
                this.smartMeterField;
            set
            {
                this.smartMeterField = value;
                this.RaisePropertyChanged("SmartMeter");
            }
        }
    }
}