///////////////////////////////////
//Adam Horvath-Smith
//CEG 4110-01
//Dr. Derek Doran
//Homework 1
///////////////////////////////////

/*
 * ABOUT:
 * This file drives the visible color panel within the painting
 * mode of the app. This handles the button presses for all functions
 * at the bottom of the screen. Note that the functionality for the
 * canvas itself is defined in the Draw.cs file.
 */

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.Content;
using Android;
using Android.Content.PM;
using Android.Support.V4.App;
using System;

namespace Homework1 {
    [Activity(Label = "Color Wizard", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ColorPanel : Activity {

        // Create the Paint object that we will use to color the canvas
        public Paint Drawing = new Paint {
            AntiAlias = true,
            Dither = true,
            Color = Color.Black,
            StrokeWidth = 12,
            StrokeJoin = Paint.Join.Round,
            StrokeCap = Paint.Cap.Round
        };

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ColorPanelLayout);

            // Add handler to open the color chooser
            Button ChooseColor = FindViewById<Button>(Resource.Id.ChooseColor);
            ChooseColor.Click += HandleChooseColor;

            // Add handler to save file
            Button SaveFile = FindViewById<Button>(Resource.Id.Save);
            SaveFile.Click += HandleSaveFile;

            // Add handler to clear all lines from picture
            Button ClearAll = FindViewById<Button>(Resource.Id.ClearAll);
            ClearAll.Click += HandleClearAll;
        }

        // Handles clear all button press
        private void HandleClearAll(object sender, EventArgs e) {
            Draw Canvas = FindViewById<Draw>(Resource.Id.Draw);
            Canvas.ClearAll();
        }

        // Handle save file request and manages permissions
        private void HandleSaveFile(object sender, EventArgs e) {
            Draw Canvas = FindViewById<Draw>(Resource.Id.Draw);
            
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) == (int)Permission.Granted) {
                Canvas.SavePicture();
                Toast.MakeText(this, "Saved to /DCIM/Drawings", ToastLength.Long).Show();
            }

            else {
                ActivityCompat.RequestPermissions(this, new string[] { "Manifest.Permission.WriteExternalStorage" }, 0);
            }

        }

        // Opens color chooser activity
        private void HandleChooseColor(object sender, EventArgs e) {
            Intent RecieveColor = new Intent(this, typeof(ColorChooser));
            StartActivityForResult(RecieveColor, 0);
        }

        // Handles returned 
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) {
            try {
                int ChosenColor = (int) data.Extras.Get("color");
                Draw Canvas = FindViewById<Draw>(Resource.Id.Draw);
                Canvas.SetColor(ChosenColor);
            } catch (NullReferenceException) {
                // Only happens if user doesn't choose a color 
            }
        }
    }
}

