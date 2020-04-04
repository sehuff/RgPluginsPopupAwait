﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace RgPluginsPopupAwait.iOS 
{
    public class Application : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            Rg.Plugins.Popup.Popup.Init();
        }
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Rg.Plugins.Popup.Popup.Init();            
            global::Xamarin.Forms.Forms.Init();     
            return base.FinishedLaunching(app, options);
        }
    }
}
    
