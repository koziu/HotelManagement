using System.Web.Optimization;

namespace HotelManagement.Mvc
{
  public class BundleConfig
  {
    // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery.dataTables").Include(
        "~/Scripts/datatables/jquery.dataTables.min.js",
        "~/Scripts/datatables/jquery.dataTables.Config.js"
        ));
      bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
        "~/Scripts/jquery-ui.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
      "~/Content/bootstrap/js/bootstrap.min.js",
      "~/Scripts/moment.min.js",
      "~/Scripts/bootstrap-datetimepicker.min.js",
      "~/Scripts/respond.js"
      ));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
        "~/Scripts/jquery.unobtrusive*",
        "~/Scripts/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        "~/Content/jQuery/jQuery-2.1.4.min.js",
        "~/Content/dist/js/app.min.js",
        "~/Content/bootstrap/js/bootstrap.min.js",
        "~/Scripts/jquery-{version}.js",
        "~/Scripts/chosen/chosen.jquery.min.js",
        "~/Scripts/datepicker/bootstrap-datepicker.js"
        ));
      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
      //            "~/Scripts/modernizr-*"));

      bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

      bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
        "~/Content/themes/base/jquery.ui.core.css",
        "~/Content/themes/base/jquery.ui.resizable.css",
        "~/Content/themes/base/jquery.ui.selectable.css",
        "~/Content/themes/base/jquery.ui.accordion.css",
        "~/Content/themes/base/jquery.ui.autocomplete.css",
        "~/Content/themes/base/jquery.ui.button.css",
        "~/Content/themes/base/jquery.ui.dialog.css",
        "~/Content/themes/base/jquery.ui.slider.css",
        "~/Content/themes/base/jquery.ui.tabs.css",
        "~/Content/themes/base/jquery.ui.datepicker.css",
        "~/Content/themes/base/jquery.ui.progressbar.css",
        "~/Content/themes/base/jquery.ui.theme.css",
        "~/Content/chosen/chosen.min.css"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
        "~/Content/bootstrap/css/bootstrap.min.css",
        "~/Content/dist/css/AdminLTE.min.css",
        "~/Content/dist/css/skins/skin-red.min.css",
        "~/Content/bootstrap-datetimepicker.min.css"
        ));
    }
  }
}