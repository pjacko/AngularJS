using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using AngularJS.Infrastructure.DotLess;

namespace AngularJS.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap")
                        .Include("~/Content/bootstrap.min.css")
                        .Include("~/Content/bootstrap-theme.min.css"));

#if DEBUG

            foreach (var bundle in bundles)
            {
                if (bundle.GetType() == typeof(ScriptBundle))
                {
                    bundle.Transforms.Clear();
                }

            }
#endif

        }
    }
}