using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Last.FeatureFolders
{
    public static class RazorExtensions
    {
        public static void ConfigureFeatureFolders(this RazorViewEngineOptions options)
        {
            // {0} - Action Name
            // {1} - Controller Name
            // {2} - Area Name
            // {3} - Feature Name
            options.AreaViewLocationFormats.Clear();
            //options.AreaViewLocationFormats.Insert(0, "/Features/{2}/{1}/{0}.cshtml");
            //options.AreaViewLocationFormats.Insert(0, "/Features/{2}/{1}/Views/{0}.cshtml");
            options.AreaViewLocationFormats.Insert(0, "/Features/{3}/{1}/{0}.cshtml");
            options.AreaViewLocationFormats.Insert(0, "/Features/{3}/{1}/Views/{0}.cshtml");
            //options.AreaViewLocationFormats.Add("/Areas/{2}/Features/{3}/{1}/{0}.cshtml");
            //options.AreaViewLocationFormats.Add("/Areas/{2}/Features/{3}/{0}.cshtml");
            //options.AreaViewLocationFormats.Add("/Areas/{2}/Features/Shared/{0}.cshtml");
            //options.AreaViewLocationFormats.Add("/Areas/Shared/{0}.cshtml");

            // replace normal view location entirely
            //options.ViewLocationFormats.Clear();
            //options.ViewLocationFormats.Add("/Features/{3}/{1}/{0}.cshtml");
            //options.ViewLocationFormats.Add("/Features/{3}/{0}.cshtml");
            //options.ViewLocationFormats.Add("/Features/Shared/{0}.cshtml");           
            options.ViewLocationExpanders.Add(new FeatureViewLocationExpander());
        }
    }
}
