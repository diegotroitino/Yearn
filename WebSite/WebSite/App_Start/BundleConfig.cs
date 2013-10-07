using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/core.js").Include(
                "~/Content/scripts/libs/jquery-{version}.js",
                "~/Content/scripts/libs/bootstrap.js"
                )
            );

            bundles.Add(new StyleBundle("~/bundles/css/core.css").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/font-awesome.css"
                )
            );
        }
    }
}