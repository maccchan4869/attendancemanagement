using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Web.Common
{
    public static class HTMLHelper
    {
        public static IHtmlString Css(this HtmlHelper helper, String path)
        {
            var script = new TagBuilder("link");
            script.MergeAttribute("href", getPath(UrlHelper.GenerateContentUrl(path, helper.ViewContext.HttpContext)));
            script.MergeAttribute("rel", "stylesheet");
            return MvcHtmlString.Create(script.ToString(TagRenderMode.SelfClosing));
        }
        public static IHtmlString Js(this HtmlHelper helper, String path)
        {
            var script = new TagBuilder("script");
            script.MergeAttribute("src", getPath(UrlHelper.GenerateContentUrl(path, helper.ViewContext.HttpContext)));
            return MvcHtmlString.Create(script.ToString());
        }
        private static String getPath(String path)
        {
            var physicalPath = HostingEnvironment.MapPath(path);
            var modified = File.GetLastWriteTime(physicalPath);
            return path + "?" + modified.ToString("yyyyMMddHHmm");
        }
    }
}