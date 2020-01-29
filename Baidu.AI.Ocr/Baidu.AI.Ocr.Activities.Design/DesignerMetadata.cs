﻿using System.Activities.Presentation.Metadata;
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

            var categoryAttribute =  new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(BaiduOcrScope), categoryAttribute);
            builder.AddCustomAttributes(typeof(BaiduOcrScope), new DesignerAttribute(typeof(BaiduOcrScopeDesigner)));
            builder.AddCustomAttributes(typeof(BaiduOcrScope), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(VatInvoiceActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new DesignerAttribute(typeof(VatInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), new DesignerAttribute(typeof(QuotaInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), new DesignerAttribute(typeof(TaxiReceiptActivityDesigner)));
            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(IdCardActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(IdCardActivity), new DesignerAttribute(typeof(IdCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(IdCardActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), new DesignerAttribute(typeof(HouseholdRegisterActivityDesigner)));
            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(BirthCertificateActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BirthCertificateActivity), new DesignerAttribute(typeof(BirthCertificateActivityDesigner)));
            builder.AddCustomAttributes(typeof(BirthCertificateActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(PassportActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(PassportActivity), new DesignerAttribute(typeof(PassportActivityDesigner)));
            builder.AddCustomAttributes(typeof(PassportActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), new DesignerAttribute(typeof(HkMacauExitentrypermitActivityDesigner)));
            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), new DesignerAttribute(typeof(TaiwanExitentrypermitActivityDesigner)));
            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(TrainTicketActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(TrainTicketActivity), new DesignerAttribute(typeof(TrainTicketActivityDesigner)));
            builder.AddCustomAttributes(typeof(TrainTicketActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new DesignerAttribute(typeof(BusinessLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(BankCardActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BankCardActivity), new DesignerAttribute(typeof(BankCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(BankCardActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), new DesignerAttribute(typeof(VehicleLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            builder.AddCustomAttributes(typeof(DrivingLicenseActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(DrivingLicenseActivity), new DesignerAttribute(typeof(DrivingLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(DrivingLicenseActivity), new HelpKeywordAttribute("https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/README.md"));

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
