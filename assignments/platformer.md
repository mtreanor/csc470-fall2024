# Assignment 6: Platformer

**Name your Unity project `platformer`**

## Description
Create a **small** 3d platformer game that:

1. Has a well thought out and (reasonably) good looking level with a goal (see Level Design below).
2. Has more interesting/enjoyable controls than the example from class (see Player Control below).

This is a two week assignment, so anticipate spending some time on details. Also, **keep your scope small**, so you have time for that attention to detail.

## Level Design
Give your game a goal, and also spend time designing the layout and look of your level.

### Ideas for goals
- Collecting all of a type of item before a timer runs out
- Navigate a maze
- Find a key to open a door
- Avoid enemies that shoot at you / destroy a bunch of enemies

### Visuals
Consider using:
- ProBuilder for interiors
- A terrain
- Custom fonts
- [poly.pizza](https://poly.pizza/) 3d models
- Maybe even some basic animation?

## Player Control
Complete at least one of the following enhancements to the player controller.

- Create a "dash" where when the player user a button, the player will "jump" foward skidding across the ground. If you know Mega Man, it is something like [this](https://megaman.fandom.com/wiki/Sliding).
- Create a "rocket pack" that will enable to player to float upwards as long as the user is pressing the "gas" button. Perhaps limit the "fuel"?
- Create something like Princess Peach's "glide" from [early Mario games](https://i.gifer.com/37Ut.gif).
- Make the player move according to the camera's position. In other words, make it so the controls aren't "tank controls" with y-rotate assigned to left and right, and forward backwards assigned to up and down. Instead, the player should face, and move forward, in the direction that the users (which will depend on where the camera is).
- Difficult double jump: While making a double jump would be pretty easy, try making a system that supports multiple jumps where the user can only perform the jump in the air if they press the button at the maximum height of their jump. Also, make it so each "air jump" has less and less power. [Super Metroid](https://metroid.fandom.com/wiki/Space_Jump) did something like this.

## Turning in your assignment
You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

**Don't forget your `.gitignore` file!**

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
Remember to modify your player settings (remember to disable compression in the Publishing settings - this is described in more detail on the setup page).
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled `platformer` in your "games" folder located in your main repository for the class (csc470-fall2024). Once you do this, it will take several minutes to build your game, and then you can commit and push your build. After five or so minutes it should be playable at: 

```
    http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2024/games/platformer
```

- If it doesn't work, you may need to take a closer look at the setup instructions.