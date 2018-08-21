using System.Web.WebPages;




namespace WebMobilize
{
    internal static class DisplayModeRegistration
    {
        // Unfortunately the the existing mobile display mode has a few issues. It appears to use
        // Request.Browser.IsMobileDevice or Request.UserAgent.IndexOf("Mobile", StringComparison.OrdinalIgnoreCase)

        // Either way this causes a couple of problems. The first being that it does not detect some Android tablets and some iPads as
        // Mobile Devices.  The second is that all Mobile devices even ones that do not support JQMobile would use the mobile display mode.

        
        //Future code: Make this a configurable tool/

       

        public static void RegisterDisplayModes()
        {
            const int index = 0;



            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.WebKit) { ContextCondition = (context => Detect.isWebKit()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.mobile) { ContextCondition = (context => Detect.isMobile()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.SmallTouch) { ContextCondition = (ctx => Detect.isSmallTouch()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.Tablet) { ContextCondition = (ctx => Detect.isTablet()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.iOS) { ContextCondition = (context => Detect.isIOS()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.iPad) { ContextCondition = (ctx => Detect.isIPad()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.iPad) { ContextCondition = (ctx => Detect.isIPhone()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.Android) { ContextCondition = (ctx => Detect.isAndroid()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.BADIE) { ContextCondition = (ctx => Detect.isBadIE()) });
            DisplayModeProvider.Instance.Modes.Insert(index, new DefaultDisplayMode(DeviceConstants.WebCrawler) { ContextCondition = (ctx => Detect.isCrawler()) });
        }

      
    }
}
