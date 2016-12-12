using System.Linq;
using System.Web.Mvc;

namespace WebMobilize.App_Code
{
    internal class WMRazorViewEngine : RazorViewEngine
    {
        const string STR_ViewsActionViewscshtml = "~/Views/{1}/{0}/{0}.cshtml";
        const string STR_ViewsActionViewsSharedcshtml = "~/Views/{1}/Shared/{0}.cshtml";

        public WMRazorViewEngine()
        {
            base.ViewLocationFormats = base.ViewLocationFormats.Concat
            (new[] { STR_ViewsActionViewscshtml, STR_ViewsActionViewsSharedcshtml, }).ToArray();

            base.PartialViewLocationFormats = base.PartialViewLocationFormats.Concat
            (new[] {
                        "~/Views/{1}/shared/{0}.cshtml",
                        "~/Views/Shared/Menus/{0}.cshtml",
                        "~/Views/Shared/Footers/{0}.cshtml",
                        "~/Views/Shared/Headers/{0}.cshtml" ,
                        "~/Loaders/{0}.cshtml"
                        }).ToArray();
        }
    }
}
