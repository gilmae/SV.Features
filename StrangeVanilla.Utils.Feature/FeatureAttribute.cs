namespace StrangeVanilla.Utils.Feature
{
    using System.Web.Mvc;
    public class FeatureAttribute : ActionFilterAttribute
    {
        private string Feature { get; set; }
		public string RedirectTo { get; set; }

		public FeatureAttribute(string feature, string redirectTo = "~/")
        {
            this.Feature = feature;
			this.RedirectTo = redirectTo;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!string.IsNullOrEmpty(this.Feature))
            {
                return;
            }

            if (!FeaturesHelper.IsActive(this.Feature))
            {
				filterContext.Result = new RedirectResult(this.RedirectTo);
            }
        }
    }
}
