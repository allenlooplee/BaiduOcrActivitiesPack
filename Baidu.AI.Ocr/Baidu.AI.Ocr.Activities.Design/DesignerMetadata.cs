using System;
using System.Activities.Presentation.Metadata;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using Baidu.AI.Ocr.Activities.Design.Properties;

namespace Baidu.AI.Ocr.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");
            var designerLookup = BuildDesignerLookup();

            foreach (var key in designerLookup.Keys)
            {
                builder.AddCustomAttributes(key, categoryAttribute);
                builder.AddCustomAttributes(key, new DesignerAttribute(designerLookup[key]));
                builder.AddCustomAttributes(key, new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));
            }

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        private Dictionary<Type, Type> BuildDesignerLookup()
        {
            return new Dictionary<Type, Type>
            {
                [typeof(BaiduOcrScope)] = typeof(BaiduOcrScopeDesigner),
                [typeof(VatInvoiceActivity)] = typeof(VatInvoiceActivityDesigner),
                [typeof(QuotaInvoiceActivity)] = typeof(QuotaInvoiceActivityDesigner),
                [typeof(TaxiReceiptActivity)] = typeof(TaxiReceiptActivityDesigner),
                [typeof(IdCardActivity)] = typeof(IdCardActivityDesigner),
                [typeof(HouseholdRegisterActivity)] = typeof(HouseholdRegisterActivityDesigner),
                [typeof(BirthCertificateActivity)] = typeof(BirthCertificateActivityDesigner),
                [typeof(PassportActivity)] = typeof(PassportActivityDesigner),
                [typeof(HkMacauExitentrypermitActivity)] = typeof(HkMacauExitentrypermitActivityDesigner),
                [typeof(TaiwanExitentrypermitActivity)] = typeof(TaiwanExitentrypermitActivityDesigner),
                [typeof(TrainTicketActivity)] = typeof(TrainTicketActivityDesigner),
                [typeof(BusinessLicenseActivity)] = typeof(BusinessLicenseActivityDesigner),
                [typeof(BankCardActivity)] = typeof(BankCardActivityDesigner),
                [typeof(VehicleLicenseActivity)] = typeof(VehicleLicenseActivityDesigner),
                [typeof(DrivingLicenseActivity)] = typeof(DrivingLicenseActivityDesigner),
                [typeof(VehicleInvoiceActivity)] = typeof(VehicleInvoiceActivityDesigner),
                [typeof(VehicleCertificateActivity)] = typeof(VehicleCertificateActivityDesigner)
            };
        }
    }
}
