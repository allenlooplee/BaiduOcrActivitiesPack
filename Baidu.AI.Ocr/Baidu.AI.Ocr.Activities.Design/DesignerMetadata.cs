using System.Activities.Presentation.Metadata;
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

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
