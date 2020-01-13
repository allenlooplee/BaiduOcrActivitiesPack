using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.TaxiReceiptActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.TaxiReceiptActivityescription))]
    public class TaxiReceiptActivity : BaiduOcrActivityBase
    {
        protected override Task<JObject> InvokeBaiduOcrAsync(Application app, byte[] image)
        {
            return Task.Run(() => app.BaiduOcrClient.TaxiReceipt(image));
        }
    }
}
