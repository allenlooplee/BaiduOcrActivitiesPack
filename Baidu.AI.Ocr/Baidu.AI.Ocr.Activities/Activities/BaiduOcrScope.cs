using System;
using System.Activities;
using System.ComponentModel;
using System.Activities.Statements;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Baidu.AI.Ocr;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{

    [LocalizedDescription(nameof(Resources.BaiduOcrScopeDescription))]
    [LocalizedDisplayName(nameof(Resources.BaiduOcrScopeDisplayName))]
    public class BaiduOcrScope : AsyncTaskNativeActivity
    {
		#region Properties
    
        private Application App;

		public const string ApplicationTag = "BaiduOcrScopeApplication";

		[Browsable(false)]
        public ActivityAction<Application> Body { get; set; }

        [LocalizedCategory(nameof(Resources.Input))]
        public InArgument<string> ApiKey { get; set; }

        [LocalizedCategory(nameof(Resources.Input))]
        public InArgument<string> SecretKey { get; set; }

        #endregion


        #region Constructors

        public BaiduOcrScope()
        {
            Body = new ActivityAction<Application>
            {
                Argument = new DelegateInArgument<Application>(ApplicationTag),
                Handler = new Sequence { DisplayName = "Do" }
            };
        }

        #endregion


        #region Private Methods

        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            if (ApiKey == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(ApiKey)));
            if (SecretKey == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(SecretKey)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<NativeActivityContext>> ExecuteAsync(NativeActivityContext context, CancellationToken cancellationToken)
        {
            // Initialize Application
            var apiKey = ApiKey.Get(context);
            var secretKey = SecretKey.Get(context);
            App = new  Application(apiKey, secretKey);

            // Schedule the child activities in the scope's body to run and make the client available to them
            if (Body != null)
				context.ScheduleAction<Application>(Body, App, OnCompleted, OnFaulted);

			// Any actions to perform after the child activities are scheduled go here
			return _ => { };
		}

        private void OnFaulted(NativeActivityFaultContext faultContext, Exception propagatedException, ActivityInstance propagatedFrom)
        {
        }

        private void OnCompleted(NativeActivityContext context, ActivityInstance completedInstance)
        {
        }

        #endregion


        #region Helpers
        
        #endregion
    }
}
