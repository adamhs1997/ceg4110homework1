///////////////////////////////////
//Adam Horvath-Smith
//CEG 4110-01
//Dr. Derek Doran
//Homework 1
///////////////////////////////////

/*
 * ABOUT:
 * Drives the color chooser within the drawing app. Note that all 
 * activity within the color picker itself is defined in the color
 * picker external library. Essentially all this file does is drive
 * the select button, which sends the chosen color back to the 
 * paint board activity.
 */

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Content.PM;
using Com.Flask.Colorpicker;

namespace Homework1 {
    [Activity(Label = "Color Wizard", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ColorChooser : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ColorChooserLayout);

            // Add handler to confirm the color selection
            Button ColorSelection = FindViewById<Button>(Resource.Id.ColorSelect);
            ColorSelection.Click += HandleColorSelection;
        }

        // Send back the user's color selection to the paint activity
        private void HandleColorSelection(object sender, System.EventArgs e) {
            ColorPickerView Wheel = FindViewById<ColorPickerView>(Resource.Id.ColorPickerView);
            Intent ToReturn = new Intent();
            ToReturn.PutExtra("color", Wheel.SelectedColor);
            SetResult(Result.Ok, ToReturn);
            Finish();
        }
    }
}