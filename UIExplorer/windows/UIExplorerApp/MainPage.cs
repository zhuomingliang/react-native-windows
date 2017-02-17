﻿using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using System.Collections.Generic;

namespace UIExplorerApp
{
    class MainPage : ReactPage
    {
        public override string MainComponentName
        {
            get
            {
                return "UIExplorerApp";
            }
        }

        public override string JavaScriptMainModuleName
        {
            get
            {
                return "Examples/UIExplorer/js/UIExplorerApp.windows";
            }
        }

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages
        {
            get
            {
                return new List<IReactPackage>
                {
                    new MainReactPackage(),
                };
            }
        }

        public override bool UseDeveloperSupport
        {
            get
            {
#if DEBUG
                return true;
#else
                return false;
#endif
            }
        }
    }
}
