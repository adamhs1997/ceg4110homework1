///////////////////////////////////
//Adam Horvath-Smith
//CEG 4110-01
//Dr. Derek Doran
//Homework 1
///////////////////////////////////

/*
 * ABOUT:
 * This file is the main driver to this program. It drives the main menu
 * that users see when first opening the app. This file defines all handlers
 * for features visible on the main menu page.
 */

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace Homework1 {
    [Activity(Label = "Color Wizard", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Menu);

            // Handle the button clicks (of course!)
            Button ToColorText = FindViewById<Button>(Resource.Id.TextLauncher);
            ToColorText.Click += HandleTextLaunch;

            Button ToColorPanel = FindViewById<Button>(Resource.Id.PaintLauncher);
            ToColorPanel.Click += HandlePaintLaunch;
        }

        //Launch the painting mode of the app
        private void HandlePaintLaunch(object sender, System.EventArgs e) {
            StartActivity(typeof(ColorPanel));
        }

        //Launch the text mode of the app
        private void HandleTextLaunch(object sender, System.EventArgs e) {
            StartActivity(typeof(ColorText));
        }
    }
}

