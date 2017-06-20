using System;
using Android.App;
using Android.Runtime;
using Org.Artoolkit.AR.Base.Assets;

namespace ARToolKit
{
    [Application]
    public class ARSimpleApplication : Application
    {
        private static Application sInstance;

		public static Application GetInstance()
		{
			return sInstance;
		}

		public ARSimpleApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
	    {
		}

        public override void OnCreate()
        {
            base.OnCreate();
			sInstance = this;
			((ARSimpleApplication)sInstance).InitializeInstance();
        }

		// Here we do one-off initialisation which should apply to all activities
		// in the application.
		protected void InitializeInstance()
		{

			// Unpack assets to cache directory so native library can read them.
			// N.B.: If contents of assets folder changes, be sure to increment the
			// versionCode integer in the AndroidManifest.xml file.
            AssetHelper assetHelper = new AssetHelper(this.Assets);
			assetHelper.CacheAssetFolder(GetInstance(), "Data");
		}
    }
}
