# Assignment 3: Rube Goldberg Machine

Create a simple “Rube Goldberg Machine” out of simple 3d shapes with custom colors/materials, at least two 3d models from [http://poly.pizza](http://poly.pizza), and the RigidBody component. While the primary purpose of this small exercise is for you to practice using the Unity user interface, you can still make some fun/hilarious stuff, so have fun! Also, while future exercises will be done with a partner, do this one individually.

## Topics we covered that you should demonstrate ability with

- The transform tools: translate, rotate, and scale. Select each by pressing the W, E, and R keys respectively.
- Controlling the editor camera: Rotate, Pan, and Zoom. https://docs.unity3d.com/Manual/SceneViewNavigation.html
- Creating primitive 3d shapes
- Creating and applying materials to the shapes
- Applying the RigidBody physics component to game objects
- Finding and importing 3d models from [http://poly.pizza](http://poly.pizza). When getting models from here, remember three things: 1. You need to include the entire unzipped folder you download in to the Assets folder of your Unity project, 2. Some of these models are just broken. To avoid difficulties you might want to stick to ones made by google or Kenney, and 3. Remember that you will need to add collider components to your models in Unity (use Box, Sphere, or Capsule).
- How to make the in game camera show a solid color background rather than the default skybox.

## Turning in your assignment

You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

Before you do anything, BE EXTRA REALLY SUPER CERTAIN THAT YOUR GITIGNORE FILE IS PLACED AT THE ROOT OF YOUR UNITY PROJECT FOLDER (you need to do this every time you create a new Unity project).

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
- **Remember to disable compression in the Publishing settings:** Go to `File->Build Settings`. And in that window, on the buttom left, click `Player Settings`. And then scroll down and click on `Publishing Settings`. And finally, change the `Compression Format` to `Disabled`.
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled `machine` in your "games" folder located in your main repository for the class (csc470-fall2023). Once you do this, it will take several minutes to build your game, and then you can commit and push your build. After five or so minutes it should be playable at: 
```
http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2024/games/machine
```
- If it doesn't work, you may need to take a closer look at the setup instructions.