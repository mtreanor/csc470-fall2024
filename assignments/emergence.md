# Assignment 3: The Emergence Game

**Name your Unity project `emergence`**

## Due
Friday October 8th at 12:55pm.

## Description
Create a small game that features [Conway's Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life) in some interesting way.

The first challenge will be getting Game of Life working at all. After that, you will need to figure out how to make it fun or more interesting in some way. You can do this by adding other elements to the game, or by modifying the rules of the game.

Here are some ideas:

- Make the grid the floor, and when a cell becomes alive, have the ground rise up (potentially launching the player in the air).
- Make the grid large and allow the player to change the state of the cell they are standing in (sort of like a Minecraft-like thing).
- Give the grid a memory and change the color of each cell based on various relationships.
- Detect certain patterns and have that spawn different types of entities.
- Use the Game of Life to generate terrains (maybe even modify the rules and Cells to support states other than alive or !alive).

## Graduate Student Assignments
Essentially the same as the undergraduate assignment, but have your game feature a one dimensional cellular automata with a configurable rule instead. In other words, something like [this](https://mathworld.wolfram.com/ElementaryCellularAutomaton.html) or [this](https://en.wikipedia.org/wiki/Cellular_automaton#List_of_automata).

### Note
You might think the 2D is harder because of the extra dimension, but implementing a one dimensional CA with a configurable rule is actually more tricky.

## Turning in your assignment
You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

Before you push anything to Github, BE EXTRA REALLY SUPER CERTAIN THAT YOUR GITIGNORE FILE IS PLACED AT THE ROOT OF YOUR UNITY PROJECT FOLDER (you need to do this every time you create a new Unity project).

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
Remember to modify your player settings (remember to disable compression in the Publishing settings - this is described in more detail on the setup page).
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled "emergence" in your "games" folder located in your main repository for the class (csc470-fall2023). It will take several minutes to build your game, and when it is complete you should commit and push your build. After five or so minutes it should be playable at: http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2024/games/emergence
- If it doesn't work, you may need to take a closer look at the setup instructions.