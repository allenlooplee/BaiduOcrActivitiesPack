using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.IdCardActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.IdCardActivityDescription))]
    public class IdCardActivity : BaiduOcrActivityBase
    {
        [LocalizedDisplayName(nameof(Resources.IdCardSideDisplayName))]
        [LocalizedDescription(nameof(Resources.IdCardSideDescription))]
        [LocalizedCategory(nameof(Resources.Input))]
        public InArgument<IdCardSide> IdCardSide { get; set; }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (IdCardSide == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(IdCardSide)));

            base.CacheMetadata(metadata);
        }

        protected override Task<JObject> InvokeBaiduOcrAsync(Baidu.Aip.Ocr.Ocr baiduOcr, byte[] image, AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            var idCardSide = IdCardSide.Get(context).ToString().ToLower();

            return Task.Run(() => baiduOcr.Idcard(image, idCardSide));
        }
    }

    public enum IdCardSide
    {
        Front,
        Back
    }
}
