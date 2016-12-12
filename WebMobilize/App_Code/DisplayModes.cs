using System.Web.WebPages;

namespace WebMobilize.App_Code
{
    internal static class DisplayModes
    {
        // Unfortunately the the existing mobile display mode has a few issues. It appears to use
        // Request.Browser.IsMobileDevice or Request.UserAgent.IndexOf("Mobile", StringComparison.OrdinalIgnoreCase)

        // Either way this causes a couple of problems. The first being that it does not detect some Android tablets and some iPads as
        // Mobile Devices.  The second is that all Mobile devices even ones that do not support JQMobile would use the mobile display mode.

        
        //Future code: Make this a configurable tool/

        private const string ipod = "ipod";
        private const string ipad = "ipad";
        private const string iphone = "iphone";
        private const string android = "android";
        private const string mobile = "mobile";
        private const string tablet = "tablet";
        private const string winphone = "windows phone os";
        private const string iemobile = "iemobile";
        private const string webkit = "webkit";
        private const string chrome = "chrome";
        private const string ie = "ie";
        private const string HTML5 = "HTML5";

       

        public static void RegisterDisplayModes()
        {
            const int index = 0;

            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(webkit) { ContextCondition = (context => Detect.isWebKit()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(mobile) { ContextCondition = (context => Detect.isMobile()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("SmallTouch") { ContextCondition = (ctx => Detect.isSmallTouch()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("Tablet") { ContextCondition = (ctx => Detect.isTablet()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("iOS") { ContextCondition = (context => Detect.isIOS()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("iPad") { ContextCondition = (ctx => Detect.isIPad()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("iPhone") { ContextCondition = (ctx => Detect.isIPhone()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("Android") { ContextCondition = (ctx => Detect.isAndroid()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("metro") { ContextCondition = (ctx => Detect.isMetro()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode("Crawler") { ContextCondition = (ctx => Detect.isCrawler()) });
        }

      
    }
}
