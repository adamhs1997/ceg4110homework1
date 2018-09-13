///////////////////////////////////
//Adam Horvath-Smith
//CEG 4110-01
//Dr. Derek Doran
//Homework 1
///////////////////////////////////

/*
 * ABOUT:
 * This file defines all handlers for the Color Text activity, where
 * users can type into the text box and change the color of the text at
 * random.
 */

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content.PM;

namespace Homework1 {
    [Activity(Label = "Color Wizard", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ColorText : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ColorTextLayout);

            // Add handler to change the color in the EditText when button pressed
            Button ChangeColor = FindViewById<Button>(Resource.Id.ChangeColor);
            ChangeColor.Click += ChangeColorHandler;
        }

        // Generate random text color on button press
        private void ChangeColorHandler(object sender, System.EventArgs e) {
            // Get the EditText
            EditText ColorText = FindViewById<EditText>(Resource.Id.ColorText);

            // Generate random numbers for the RGB values
            System.Random Random = new System.Random();
            int Red = Random.Next(255);
            int Green = Random.Next(255);
            int Blue = Random.Next(255);

            // Set the new random color to the EditText
            Color NewColor = Color.Rgb(Red, Green, Blue);
            ColorText.SetTextColor(NewColor);

            // Get the color text to update its values
            TextView ColorDisplay = FindViewById<TextView>(Resource.Id.ColorDisplay);
            string HexColor = NewColor.R.ToString("X2") + NewColor.G.ToString("X2") + NewColor.B.ToString("X2");
            ColorDisplay.Text = "COLOR: " + Red + "r, " + Green + "g, " + Blue + "b, #" + HexColor;
        }
    }
}