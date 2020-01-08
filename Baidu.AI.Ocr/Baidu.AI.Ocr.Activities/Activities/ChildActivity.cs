using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
	[LocalizedDisplayName(nameof(Resources.ChildActivityDisplayName))]
	[LocalizedDescription(nameof(Resources.ChildActivityDescription))]
	public class ChildActivity : AsyncTaskCodeActivity
	{
		#region Properties

		[LocalizedDisplayName(nameof(Resources.ChildActivityFirstNumberDisplayName))]
		[LocalizedDescription(nameof(Resources.ChildActivityFirstNumberDescription))]
		[LocalizedCategory(nameof(Resources.Input))]
		public InArgument<int> FirstNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.ChildActivitySecondNumberDisplayName))]
        [LocalizedDescription(nameof(Resources.ChildActivitySecondNumberDescription))]
        [LocalizedCategory(nameof(Resources.Input))]
        public InArgument<int> SecondNumber { get; set; }

        [LocalizedDisplayName(nameof(Resources.ChildActivitySumDisplayName))]
		[LocalizedDescription(nameof(Resources.ChildActivitySumDescription))]
		[LocalizedCategory(nameof(Resources.Output))]
		public OutArgument<int> Sum { get; set; }

        #endregion

        public ChildActivity()
        {
            Constraints.Add(ActivityConstraints.HasParentType<ChildActivity, ParentScope>(Resources.ValidationMessage));
        }

        #region Protected Methods

        /// <summary>
        /// Validates properties at design-time.
        /// </summary>
        /// <param name="metadata"></param>
        protected override void CacheMetadata(CodeActivityMetadata metadata)
		{
			if (FirstNumber == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(FirstNumber)));
            if (SecondNumber == null) metadata.AddValidationError(string.Format(Resources.MetadataValidationError, nameof(SecondNumber)));

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
            var property = context.DataContext.GetProperties()[ParentScope.ApplicationTag];
            var app = property.GetValue(context.DataContext) as Application;
           
            var firstValue = FirstNumber.Get(context);
            var secondValue = SecondNumber.Get(context);

            var sum = app.Sum(firstValue, secondValue);
			return ctx =>
            {
                Sum.Set(ctx, sum);
            };
		}

		#endregion
	}
}
