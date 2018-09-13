# CEG 4110 Homework 1

**Adam Horvath-Smith, 9-13-2018**

_First homework assignment for CEG 4110, Wright State University, Fall 2018._

This app is a sort of "Color Wizard" with two main modes of operation. In one mode, users may type freely into a text box using the system keyboard. When finished, the user can press a button that will change the color of the typed text at random. The app will also display the RGB and Hex values associated with the random color generated. In the second mode, users are presented with a blank drawing canvas (much like Microsoft Paint). Users can draw freely on this canvas by dragging their fingers across the screen. This mode also presents users options to select which color to draw in, allows users to save their creations, and allows users to reset the screen to a blank canvas if they are unsatisfied with their work.

# Running this app on your phone

To run this app on your phone, simply download and load the Homework1.apk file onto your phone. _No external resources/files are needed to run the app on your device._ After downloading the apk onto your computer, connect your phone to it with a USB cable. You may have to enable file sharing on your phone to be able to access its file system on your computer. Then, simply move the apk anywhere onto your phone's storage and, from your phone's file explorer, run the apk. Follow the prompts to install the app (you may have to allow your phone to install from untrusted sources). Once the installer is done, open the app and enjoy!

# How to use this app

The Color Wizard app is very simple. Upon opening the app, users are presented with a welcome screen and menu to switch between the two modes of operation mentioned in the introduction to this Readme. A view of this menu is shown below. After selecting one of the two modes, users may press the "Back" button on their phones to return to this menu at any time.

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/main-menu.png" width="350">

## Mode 1: Make Colorful Text

There isn't much to this mode of operation; it works almost exactly as described in the introduction. Simply tap on the white text box, labelled "Tap to change color." This will open the keyboard and place a cursor inside the text box if it wasn't there already. 

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/blank-color-text.png" width="350">

Then, using the on-screen keyboard, begin typing into the text box. Type whatever you want, the app doesn't care. Note that by default the text is boring black-on-white. 

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/black-color-text.png" width="350">

To liven up our words, simply tap the "Change Color" button. The text will change to a randomly-generated new color, whose RGB and Hex values are shown below the button.

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/colorful-color-text.png" width="350">

Users may tap the "Change Color" button as often as they like; the app will continue to generate new colors.

## Mode 2: Paint a Picture

This mode of operation lets users have a little more fun. It, too, isn't terribly complicated, but provides more creative freedom in that users can choose what to draw and what colors to use. When users select this mode, they are first presented with a blank white canvas and three option buttons, as shown:

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/blank-canvas.png" width="350">

By default, users can draw on the screen in black ink.

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/black-canvas.png" width="350">

To change colors, users simply click on the "Change Color" button below the canvas. This will bring up a color wheel with infinite options for users to choose from.

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/color-wheel.png" width="350">

Users can select from one of the several colors on the wheel, then adapt that color in any way using the brightness and alpha sliders below the wheel. Once satisfied with their color option, users can tap the "Select" button to go back to the drawing board. Or, if they change their mind about choosing a new color, users can simply hit the phone's back button to return without changing colors. Note users can draw with as many colors as they like on the canvas by choosing new colors.

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/colorful-canvas.png" width="350">

To save their creations, users can tap the "Save" button in the bottom left corner. This will save their picture to their phone's internal storage in PNG format. All files are saved to /DCIM/Drawings and are titled with a timestamp, accurate to the second. Users will get a notification once their picture has been saved. (Note that this appears over top of the "Change Color" button.)

<img src="https://github.com/adamhs1997/ceg4110homework1/raw/master/Screenshots/saving-canvas.png" width="350">

If users want to start from scratch, simply press the "Clear All" button to return to a blank canvas.

# Design and Implementation

Before discussing the design of this app, let me note that a month prior to the start of this class, I had no mobile programming experience. Under recommendation from the professor (Dr. Derek Doran), I began to teach myself to use Microsoft's Xamarin platform. This proved quick and easy to learn, so I proceeded to use Xamarin to create this app. That being said, the app was created using Xamarin's stock Android app template (which I imagine is very similar to how other Android apps are structured). Each screen in the app (e.g., the main menu, the drawing canvas, etc.) is implemented as a separate activity. Code for each activity is implemented in its own .cs file as a class extending Activity. Each activity also has its own .axml file defining the layout of the program.

Four .cs files (ColorChooser, ColorPanel, ColorText, and MainActivity) implement the four different acivities present in the app. Each of these has a corresponding .axml layout in the Resources/layout folder. The .axml files define the layout of the activity; the .cs files define the function of the elements in the activity. This (I believe) is the standard layout for an Android application; no attempt was made to do anything unorthodox.

The file Draw.cs contains my implementation of a drawing canvas, used in the "Paint a Picture" mode of operation. Having such little design experience with Android, this was the most difficult part of the entire project. I was able to piece this together by referring to the following two websites: 

 * https://android.googlesource.com/platform/development/+/master/samples/ApiDemos/src/com/example/android/apis/graphics/FingerPaint.java
 * https://medium.com/@ssaurel/learn-to-create-a-paint-application-for-android-5b16968063f8

Using these sites as a guide, I was able to figure out how to extend the View class to build my own drawing canvas capable of doing what I needed. I had tried to look for a drawing canvas library, but none seemed to have all the functionality necessary for this project (e.g., the ability to change colors while drawing). Thus, I decided to implement my own drawing canvas class.

The color wheel present in the drawing canvas mode is made possible using a free Android library, available from https://github.com/QuadFlask/colorpicker. As this library was written in Java and Xamarin uses C#, this had to be imported in a kind of odd way. You will notice there are actually two projects in this repo, one for the main Homework1 files, the other for this ColorPickerLib. The latter project is simply a C# wrapper around the Java code, generated by Xamarin. The Homework1 project simply references the code in ColorPickerLib to implement the color picker.

Overall, I was happy with the outcome of this project. Xamarin proved an easy and flexible development platform, even when working with Java libraries wrapped in C# code. It was great for starting out, and I will likely continue using this platform in the future.

# Acknowledgments

Aside from the resources noted above, I should again iterate that this is a class project for CEG 4110 (Introduction to Software Engineering) at Wright State University. The app idea is not my own; requirements were specified in the project outline given to the class by Dr. Derek Doran. The design and implementation of this app, aside from the imported color picker library, is completely my own.
