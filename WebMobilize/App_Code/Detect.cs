using System;
using System.Web;

namespace WebMobilize
{
    public static class Detect
    {
        #region Device Constants

      

        #endregion Device Constants

        #region Device Information

        /// <summary>
        /// Is the browsing device a Mobile device
        /// </summary>
        /// <returns></returns>
        ///

        public static bool isMobile()
        {
            string UserAgent = HttpContext.Current.Request.UserAgent.ToLower();
            string[] TestedAttributes = { DeviceConstants.Android, DeviceConstants.mobile, DeviceConstants.iPad, DeviceConstants.iPhone , DeviceConstants.WindowsPhone };

            foreach (string attribute in TestedAttributes)
            {
                if (UserAgent.Contains(attribute.ToLower())) { return true; }
            }

            return false;
        }

        /// <summary>
        /// Is the browsing device a Tablet
        /// </summary>
        /// <returns></returns>
        ///

        public static bool isTablet()
        {
            // isTablet() is a bit tricky for a couple of reasons. Android and Windows 8.

            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.iPad, StringComparison.OrdinalIgnoreCase) >= 0 || UserAgent.IndexOf(DeviceConstants.Tablet, StringComparison.OrdinalIgnoreCase) >= 0 || // catches some of the tablets out there

                // So the usual rule is that android tablets user agent strings
                // should not have the word mobile in them but will have android.
                // Not all OEMs follow this rule unfortunately. So we are checking to see
                // if Android is there but mobile is not.

                (UserAgent.IndexOf(DeviceConstants.Android, StringComparison.OrdinalIgnoreCase) >= 0 &&
                UserAgent.IndexOf(DeviceConstants.mobile , StringComparison.OrdinalIgnoreCase) <= 0))

            { return true; }
            else { return false; }
        }

        /// <summary>
        /// Is the browsing device a small form factor device.
        /// </summary>
        /// <returns></returns>
        ///
        public static bool isSmallTouch()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.iPhone, StringComparison.OrdinalIgnoreCase) >= 0) return true;
            if (UserAgent.IndexOf(DeviceConstants.mobile, StringComparison.OrdinalIgnoreCase) >= 0 &&  UserAgent.IndexOf(DeviceConstants.iPad, StringComparison.OrdinalIgnoreCase) <= 0) return true;

            
           
            return false; 
        }

        /// <summary>
        /// This returns true if ONLY the device is an iPhone or iPod
        /// It will return false if the device is an iPad. If you want detect for both an
        /// iPad and an iPhone use the isIOS() Method
        /// </summary>
        /// <returns></returns>
        ///
        public static bool isIPhone()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.iPhone, StringComparison.OrdinalIgnoreCase) >= 0)    return true; 
            else { return false; }
        }

        public static bool isIPad()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.iPad, StringComparison.OrdinalIgnoreCase) >= 0)
            { return true; }
            else { return false; }
        }

        /// <summary>
        /// Is the browsing device a Mobile device
        /// </summary>
        /// <returns></returns>
        public static bool isIOS()
        {
            string UserAgent = HttpContext.Current.Request.UserAgent.ToLower();
            string[] TestedAttributes = { DeviceConstants.iPad, DeviceConstants.iPhone };

            foreach (string attribute in TestedAttributes)
            {
                if (UserAgent.Contains(attribute.ToLower())) { return true; }
            }

            return false;
        }

        public static bool isAndroid()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.Android, StringComparison.OrdinalIgnoreCase) >= 0)
            { return true; }
            else { return false; }
        }

        public static bool isWebKit()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.WebKit, StringComparison.OrdinalIgnoreCase) >= 0)
            { return true; }
            else { return false; }
        }

       

        public static bool isChrome()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;

            if (UserAgent.IndexOf(DeviceConstants.Chrome, StringComparison.OrdinalIgnoreCase) >= 0)
            { return true; }
            else { return false; }
        }

        public static bool isIE()
        {
            string browsername = HttpContext.Current.Request.Browser.Browser;
            if (browsername.ToLower() == "ie") return true;
            else { return false; }
        }

        public static bool isBadIE()
        {
            string browsername = HttpContext.Current.Request.Browser.Browser;
            int browseMajorVersion = HttpContext.Current.Request.Browser.MajorVersion;

            if (browsername.ToLower() == "ie" && browseMajorVersion < 9) return true;
            else { return false; }
        }

        public static bool isCrawler()
        {
            return HttpContext.Current.Request.Browser.Crawler;
        }

        public static bool HasHTML5Canvas()
        {
            String UserAgent = HttpContext.Current.Request.UserAgent;
            int browseMajorVersion = HttpContext.Current.Request.Browser.MajorVersion;
            string browsername = HttpContext.Current.Request.Browser.Browser;

            if (UserAgent.IndexOf("Mozilla/5.0", StringComparison.OrdinalIgnoreCase) >= 0)
            { return true; }
            if (browsername.ToLower() == "ie" && browseMajorVersion > 9) return true;
            return false;
        }

        #endregion Device Information
    }
}