using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Baidu.AI.Ocr.Activities.Design.Designers;
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

            builder.AddCustomAttributes(typeof(BaiduOcrClientActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BaiduOcrClientActivity), new DesignerAttribute(typeof(BaiduOcrClientActivityDesigner)));
            builder.AddCustomAttributes(typeof(BaiduOcrClientActivity), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
