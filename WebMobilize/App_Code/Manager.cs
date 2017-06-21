using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;


namespace WebMobilize
{
    public static class Manager
    {
        public static void Initialize(bool load_RazorViewEngine = true ,  bool load_WebFormViewEngine = false)
        {
            DisplayModeRegistration.RegisterDisplayModes();

            ViewEngines.Engines.Clear();
            if (load_RazorViewEngine)  ViewEngines.Engines.Add(new WM_RazorViewEngine());
            if (load_WebFormViewEngine) ViewEngines.Engines.Add(new WM_WebformViewEngine());

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