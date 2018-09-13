///////////////////////////////////
//Adam Horvath-Smith
//CEG 4110-01
//Dr. Derek Doran
//Homework 1
///////////////////////////////////

/*
 * ABOUT:
 * This file defines the Draw object, which is the drawing canvas
 * used in the Color Panel activity. This file includes all functions
 * to track a users touches on the screen, as well as functions that 
 * clear the screen, save the drawn bitmap, and change the color of the
 * paths the user draws.
 * 
 * ACKNOWLEDGMENTS:
 * To learn how to create a drawing canvas, I used the folowing sites
 * as resources:
 * https://android.googlesource.com/platform/development/+/master/samples/ApiDemos/src/com/example/android/apis/graphics/FingerPaint.java
 * https://medium.com/@ssaurel/learn-to-create-a-paint-application-for-android-5b16968063f8
 */

using Android.Graphics;
using Android.Views;
using Android.Content;
using Android.Util;
using System;
using System.Collections;


namespace Homework1 {
    // This class will contain our drawing tools
    public class Draw : View {

        // Initialize all the drawing tools we need
        private Bitmap Bitmap;
        private Path Path;
        private Paint LocalPaint;
        private ArrayList Paths = new ArrayList();
        private ArrayList Colors = new ArrayList();
        private int CurrentColor;

        public Draw(Context context, IAttributeSet attrs) : base(context, attrs) {
            Path = new Path();
            LocalPaint = new Paint();
            Bitmap = Bitmap.CreateBitmap(1, 1, Bitmap.Config.Argb8888);
            CurrentColor = 0;
        }

        //Allows user to set the current drawing color
        public void SetColor(int color) {
            CurrentColor = color;
        }

        // This is where all the fun happens
        protected override void OnDraw(Canvas canvas) {
            base.OnDraw(canvas);

            // Set our canvas color
            canvas.DrawColor(Color.White);

            //Set size of bitmap to size of canvas
            if (Bitmap.Width != canvas.Width || Bitmap.Height != canvas.Height)
                Bitmap = Bitmap.CreateBitmap(canvas.Width, canvas.Height, Bitmap.Config.Argb8888);

            // Draw on this bitmap, starting in location (0,0), using the given paint object
            canvas.DrawBitmap(Bitmap, 0, 0, LocalPaint);

            // Draw the actual paths across the canvas in their related paints
            for (int i = 0; i < Paths.Count; i++) {
                canvas.DrawPath((Path) Paths[i], (Paint) Colors[i]);
            }
        }

        // Handle a user's touches on screen
        public override bool OnTouchEvent(MotionEvent e) {
            // Extract the X and Y position of movement
            float XPos = e.GetX();
            float YPos = e.GetY();

            // Handle the three stages of user movement
            switch (e.Action) {
                case MotionEventActions.Down:
                    StartDrawing(XPos, YPos);
                    Invalidate();
                    break;
                case MotionEventActions.Move:
                    CaptureMotion(XPos, YPos);
                    Invalidate();
                    break;
                case MotionEventActions.Up:
                    CommitDrawing();
                    Invalidate();
                    break;
            }

            return true;
        }

        // These functions handle the three different possible motion events
        //   triggered in the OnTouchEvent

        // Hold our initial x and y positions here
        private float InitX, InitY;

        // Moves cursor to the starting x and y position
        //   and saves these in the InitX and InitY vars
        private void StartDrawing(float x, float y) {
            //Create this path AND the color that goes with it
            Path = new Path();
            Paths.Add(Path);
            Colors.Add(GeneratePaint(CurrentColor));

            //Set initial point of drawing
            Path.MoveTo(x, y);
            InitX = x;
            InitY = y;
        }

        //Trace the motion of what is drawn on screen
        private void CaptureMotion(float x, float y) {
            float dx = Math.Abs(x - InitX);
            float dy = Math.Abs(y - InitY);
            if (dx >= 4 || dy >= 4) {
                Path.QuadTo(InitX, InitY, (x + InitX) / 2, (y + InitY) / 2);
                InitX = x;
                InitY = y;
            }
        }

        // Creates a line from the end point back to the start
        private void CommitDrawing() {
            Path.LineTo(InitX, InitY);
        }

        //Helper to generate a paint given a certain color
        private Paint GeneratePaint(int color) {
            Paint ThisColor = new Paint {
                AntiAlias = true,
                Dither = true,
                StrokeWidth = 12,
                StrokeJoin = Paint.Join.Round,
                StrokeCap = Paint.Cap.Round
            };

            if (color != 0) ThisColor.Color = new Color(color);
            else ThisColor.Color = Color.Black;
            ThisColor.SetStyle(Paint.Style.Stroke);

            return ThisColor;
        }

        //Save off your drawing to local storage
        public void SavePicture() {
            //Copy our bitmap to a temporary local canvas
            Canvas ToWrite = new Canvas(Bitmap);
            Draw(ToWrite);

            //Save to local DCIM folder
            string Root = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            string Filename = DateTime.Now.ToString("MMddyyyyHHmmss");
            System.IO.Directory.CreateDirectory(Root + "/DCIM/Drawings");
            System.IO.FileStream Stream = System.IO.File.Create(Root + "/DCIM/Drawings/" + Filename + ".png");
            System.IO.StreamWriter Output = new System.IO.StreamWriter(Stream);
            Bitmap.Compress(Bitmap.CompressFormat.Png, 100, Stream);
            Stream.Flush();
            Stream.Close();

            //Hack to "remove" the temp canvas we had to draw
            ToWrite = new Canvas(Bitmap.CreateBitmap(1, 1, Bitmap.Config.Argb8888));
            Draw(ToWrite);
        }

        //Clear all drawings from the screen
        public void ClearAll() {
            //Overwrite all the saved paths and colors
            Paths = new ArrayList();
            Colors = new ArrayList();

            //Clear what is currently on the screen
            Invalidate();
        }
    }
}