# CEG 4110 Homework 1

**Adam Horvath-Smith, 9-13-2018**

_First homework assignment for CEG 4110, Wright State University, Fall 2018._

This app is a sort of "Color Wizard" with two main modes of operation. In one mode, users may type freely into a text box using the system keyboard. When finished, the user can press a button that will change the color of the typed text at random. The app will also display the RGB and Hex values associated with the random color generated. In the second mode, users are presented with a blank drawing canvas (much like Microsoft Paint). Users can draw freely on this canvas by dragging their fingers across the screen. This mode also presents users options to select which color to draw in, allows users to save their creations, and allows users to reset the screen to a blank canvas if they are unsatisfied with their work.

# Running this app on your phone

_TODO: Elaborate on build process. Cover "special deployment instructions" and "resources"_

# How to use this app

The Color Wizard app is very simple. Upon opening the app, users are presented with a welcome screen and menu to switch between the two modes of operation mentioned in the introduction to this Readme. A view of this menu is shown here:

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
