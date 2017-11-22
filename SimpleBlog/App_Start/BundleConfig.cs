using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Admin/Scripts")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-3.1.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Areas/Admin/Scripts/Forms.js"));

            bundles.Add(new ScriptBundle("~/Scripts")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jqurey-3.1.1.js")
                .Include("~/Scripts/jquery.timeago.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/Frontend.js"));

            bundles.Add(new ScriptBundle("~/Admin/Post/Scripts")
                .Include("~/Areas/Admin/Scripts/PostEditor.js"));

            bundles.Add(new StyleBundle("~/Admin/Styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/admin.css"));

            bundles.Add(new StyleBundle("~/Styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/site.css"));

        }
    }
}
