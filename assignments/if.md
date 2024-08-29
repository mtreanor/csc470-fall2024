# Interactive Fiction (welcome to C#)

Before computers could even display images at all, people made games out of words alone. This genre of game (refered to as Interactive Fiction or IF or parser fiction) became incredibly influential for how videogames developed, and people still write IF today.

In this assignment you will learn the basics of writing in the C# programming language while creating a small work of Interactive Fiction. The assignment will require two parts: 

## 1. Understanding Interactive Fiction

Play Zork for 30 minutes or more. You can play it [here](https://www.ifiction.org/games/playz.php?cat=&game=3&mode=html). Remember, the way it works is to type in a command, and see if the program responds. The main "verbs" or commands that are supported in Zork are:

- `go [north | south | east | west]`
- `take [item]`
- `examine [item]`
- `look`
- and [many others](https://zork.fandom.com/wiki/Command_List)...

### What to turn in

Write a short reflection about what it was like to play Zork, and include it as a block comment at the top of you dotfiddle code project (described below).

It will look something like this: 

```
/*
This was the first time I ever played something like this and here's what I thought about it........
*/
// and then the rest of your program.
```

## 2. Create a Simple Work of Interactive Fiction using C# in dotnetfiddle.

Your Interactive Fiction game should conform to the requirements below.

Also, as creating C# projects typically requires a lot of configuration, we are avoiding that by using an online C# code editor named [http://dotnetfiddle.com](http://dotnetfiddle.com). You'll need to make a free account in order to save your work.

### Requirements

1. The player must be able to navigate through a 'world' that you create using the `go [north | south | east | west]` command.
1. Each place the player is in should have a description.
1. There needs to be at least 5 locations that are linked together.
1. There needs to be at least 5 collectable items in the whole game.
1. There needs to be at least 1 location description that changes based on what the player has collected.

## Turning in your work

Turn in your game by submitting a link to your dotnetfiddle project. Remember to make it public on the top right, and then click the share button to get a sharable link to the project.

## Resources

- If you are primarily familiar with Python this [C# for Python Programmers](https://gist.github.com/mrkline/8302959) might be useful. Also, just google or check youtube for that and you may find other good resources.
- To gather a command from the player you can use `string command = Console.ReadLine();`
- In order to have a list, you need to put `using System.Collections.Generic;` at the top of your file.
- [Here's a cool talk/documentary about Interaction Fiction](https://www.youtube.com/watch?v=LRhbcDzbGSU) in case you are interested!