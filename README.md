# unity_starwipe
Just a little demo of using a shader and renderTexture to make a stupid starwipe gag.

press UP to starWipe in
press DOWN to starWipe out

gag reference
https://www.youtube.com/watch?v=72bUheqRE5o

useful video (not mine) on the general concept
https://www.youtube.com/watch?v=ZuV9Xlt-l6g&feature=related

starter shader i used (i added a color overlay to get that thick white border on the star)
http://wiki.unity3d.com/index.php?title=Texture_Mask

ideas to make this fancier:
animate the texture sizes so that the star "expands" instead of scaling it up (this would allow you to "cut" to your star camera more seamlessly instead of staying on the renderTexture)



THE DREAM
====================================================
just have a script that takes two cameras and a 0-1 slider value and starwipes between the two cameras (not sure if this achievable w/o RenderTextures ATM)
