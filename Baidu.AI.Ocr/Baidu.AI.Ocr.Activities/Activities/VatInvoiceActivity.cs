using System;
using System.Activities;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.VatInvoiceActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.VatInvoiceActivityDescription))]
    public class VatInvoiceActivity : BaiduOcrActivityBase
    {
        protected override Task<JObject> InvokeBaiduOcrAsync(Application app, byte[] image)
        {
            return Task.Run(() => app.BaiduOcrClient.VatInvoice(image));
        }
    }
}
