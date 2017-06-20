using Android.App;
using Android.Widget;
using Android.OS;
using Org.Artoolkit.AR.Base;
using Org.Artoolkit.AR.Base.Rendering;
using System;
using Android.Views;

namespace ARToolKit
{
    [Activity(Label = "ARToolKit", MainLauncher = true, Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class ARSimple : ARActivity
    {
		/**
		 * A custom renderer is used to produce a new visual experience.
		 */
		private SimpleRenderer simpleRenderer = new SimpleRenderer();

		/**
		 * The FrameLayout where the AR view is displayed.
		 */
		private FrameLayout mainLayout;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mainLayout = (FrameLayout)this.FindViewById(Resource.Id.mainLayout);
            mainLayout.Click += (sender, e) => simpleRenderer.Click();
        }

        protected override FrameLayout SupplyFrameLayout()
        {
            return (FrameLayout)this.FindViewById(Resource.Id.mainLayout);
		}

        protected override ARRenderer SupplyRenderer()
        {
            return simpleRenderer;
        }
    }
}

