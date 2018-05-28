using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ins.Library.RNInsLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNInsLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNInsLibraryModule"/>.
        /// </summary>
        internal RNInsLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNInsLibrary";
            }
        }
    }
}
