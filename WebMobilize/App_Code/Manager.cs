using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;

namespace WebMobilize
{
    public static class Manager
    {
        public static void Initialize(bool DebugMode = false)
        {
            DisplayModes.RegisterDisplayModes();

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new WMRazorViewEngine());
        }

        public static List<String> ListDisplayModes()
        {
            List<String> displaymodes = new List<string>();
            List<IDisplayMode> displaymodelist = DisplayModeProvider.Instance.Modes.ToList();

            foreach (IDisplayMode DPM in displaymodelist)
            {
                if (DPM.DisplayModeId.Length > 0)
                {
                    displaymodes.Add(DPM.DisplayModeId);
                }
            }

            displaymodes.Add("null (default)");
            return displaymodes;
        }
    }
}