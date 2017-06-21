using System.Linq;
using System.Web.Mvc;

namespace WebMobilize
{
    internal class WM_WebformViewEngine : WebFormViewEngine
    {
        private const string STR_Views = "~/Views/{1}/";

        private const string STR_Webform = "/{0}.aspx";
        private const string STR_WebformPartial = "/{0}.ascx";

        private const string STR_ViewsActionViewsWebForm = "~/Views/{1}/{0}/{0}.aspx";
        private const string STR_ViewsActionViewsWebFormPartial = "~/Views/{1}/{0}/{0}.ascx";

        /// <summary>
        /// Initializes a new instance of the <see cref="mWebformViewEngine"/> class.
        /// </summary>
        public WM_WebformViewEngine()
        {


            base.ViewLocationFormats = base.ViewLocationFormats.Concat
            (new[] { STR_ViewsActionViewsWebForm }).ToArray();

            base.PartialViewLocationFormats = base.PartialViewLocationFormats.Concat
            (new[] {
                         STR_ViewsActionViewsWebFormPartial,
                         "~/Views/Shared/Footers/{0}.ascx",
                         "~/Views/Shared/Headers/{0}.ascx"
                        }).ToArray();
        }
    }
}
