using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Baidu.AI.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.BaiduOcrClientActivity_DisplayName), typeof(Resources))]
    [LocalizedDescription(nameof(Resources.BaiduOcrClientActivity_Description), typeof(Resources))]
    public class BaiduOcrClientActivity : BaseOcrClientActivity
    {
        #region Properties

        [LocalizedDisplayName(nameof(Resources.BaiduOcrClientActivity_ApiKey_DisplayName), typeof(Resources))]
        [LocalizedDescription(nameof(Resources.BaiduOcrClientActivity_ApiKey_Description), typeof(Resources))]
        [LocalizedCategory(nameof(Resources.Input_Category), typeof(Resources))]
        public InArgument<string> ApiKey { get; set; }

        [LocalizedDisplayName(nameof(Resources.BaiduOcrClientActivity_SecretKey_DisplayName), typeof(Resources))]
        [LocalizedDescription(nameof(Resources.BaiduOcrClientActivity_SecretKey_Description), typeof(Resources))]
        [LocalizedCategory(nameof(Resources.Input_Category), typeof(Resources))]
        public InArgument<string> SecretKey { get; set; }

        #endregion

        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ApiKey == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ApiKey)));
            if (SecretKey == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(SecretKey)));

            base.CacheMetadata(metadata);
        }

        protected override IOcrClient GetOcrClient(AsyncCodeActivityContext context)
        {
            var apiKey = ApiKey.Get(context);
            var secretKey = SecretKey.Get(context);

            return new BaiduOcrClient(apiKey, secretKey);
        }

        #endregion
    }
}

