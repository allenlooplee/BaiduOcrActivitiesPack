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
            builder.AddCustomAttributes(typeof(BaiduOcrScope), new HelpKeywordAttribute("https://go.uipath.com"));

            builder.AddCustomAttributes(typeof(VatInvoiceActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new DesignerAttribute(typeof(VatInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new HelpKeywordAttribute("https://go.uipath.com"));

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
