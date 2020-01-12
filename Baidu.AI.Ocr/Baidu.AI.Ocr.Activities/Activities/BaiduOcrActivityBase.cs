using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    public abstract class BaiduOcrActivityBase : AsyncTaskCodeActivity
    {
        #region Properties

        [LocalizedDisplayName(nameof(Resources.VatInvoiceActivityImagePathDisplayName))]
        [LocalizedDescription(nameof(Resources.VatInvoiceActivityImagePathDescription))]
        [LocalizedCategory(nameof(Resources.Input))]
        public InArgument<string> ImagePath { get; set; }

        [LocalizedDisplayName(nameof(Resources.VatInvoiceActivityResultDisplayName))]
        [LocalizedDescription(nameof(Resources.VatInvoiceActivityResultDescription))]
        [LocalizedCategory(nameof(Resources.Output))]
        public OutArgument<JObject> Result { get; set; }

        #endregion

        #region Constructors

        public BaiduOcrActivityBase()
        {
            Constraints.Add(ActivityConstraints.HasParentType<BaiduOcrActivityBase, BaiduOcrScope>(Resources.ValidationMessage));
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Validates properties at design-time.
        /// </summary>
        /// <param name="metadata"></param>
        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ImagePath == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(ImagePath)));

            base.CacheMetadata(metadata);
        }

        /// <summary>
        /// Runs the main logic of the activity. Has access to the context, 
        /// which holds the values of properties for this activity and those from the parent scope.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            var property = context.DataContext.GetProperties()[BaiduOcrScope.ApplicationTag];
            var app = property.GetValue(context.DataContext) as Application;

            var imagePath = ImagePath.Get(context);
            var image = File.ReadAllBytes(imagePath);

            var result = await InvokeBaiduOcrAsync(app, image);
            return ctx => Result.Set(ctx, result);
        }

        protected abstract Task<JObject> InvokeBaiduOcrAsync(Application app, byte[] image);

        #endregion
    }
}
