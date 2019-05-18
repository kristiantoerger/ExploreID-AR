# ExploreID-AR
An Android Augmented Reality educational application which can be used to watch tourism video of certain provinces in INDONESIA and get a brief information about the provinces. The information consists some of the provinces' facts, culinary recommendation, and point of interests. The info also includes one of the provinces' folk song which are able to be listened by the users.

How it works:

Scan the provinces' official tourism logo, then a button to play the tourism video will pop out. 

There are menus to read the provinces' information. To read the information of each province, select the logo of the province which info you'd like to read. The information along with two buttons will pop out. The buttons are used to play the folk song and stop the song from playing.

The application is using Indonesian language.


Download links:

apk file: https://drive.google.com/open?id=1SgUBcRz88fgGTIKIyT_dE_o3BgQj5zYo

manual book (in Indonesian language): https://drive.google.com/open?id=1IKYlXZqwoU3XYNH6HD6IWKkMaaG8ZsCh

markers/official tourism logo of the provinces: https://drive.google.com/open?id=1WF-4eSBd6riZ6LAe2hmToZ-soFRsYRJN

Scripts explanation:

ARscenecontrol.cs is used to function the 'back' button in users' phones to go back to the main menu when the AR camera mode is used.

ButtonFunctions.cs is used to control each buttons' functions to open their own menus.

LogoInfoControl.cs is used to control the tourism logos' (in the "Temukan Informasi" menu) behavior (when one of them is clicked, it shows and the other logos are not shown)

Tap-to-play vidbutton.cs is used to function the play button above the marker (in the AR camera mode) when the marker is scanned. It will play the game's trailer video once it's hit.
