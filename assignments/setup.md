# Setting up your Unity Development Environment

## Unity
1. Download and install [Unity Hub](https://unity.com/download).
1. Using Unity Hub, download and install Unity LTS Release 2022.3.17f1. **Make 100% certain you are downloading that exact version!**
    - When prompted, be sure to include WebGL build support
    - **When asked, definitely choose to download and use Visual Studio!!!**

## Github
1. Go to [github.com](https://github.com/) and create an account
1. Add your Github username to the Google Sheet linked on the course [Canvas](https://canvas.american.edu) page.
1. Download and install [Github Desktop](https://desktop.github.com/)
1. Log into Github desktop

## Create your repository for the class
1. Open Github desktop and log in (you may need to go to Preferences->Accounts)
1. Add a repository for the exercise
    - Name the repository exactly "game615-spring2024" **Make 100% certain you are using that exact name - all lowercase**
    - Make the repository public by unchecking "Keep this repository private"
    - For Local Path put it wherever you like to keep your class files on your computer
    - Ignore the other setting options
    - Check "Initialize this repository with a README"
    - Click "Create Repository"
1. Locate the repository folder on your computer, and add two folders to it: `assignments` and `games`
1. Commit your changes to the repository "locally" by typing a brief summary of what you did in the Summary field (e.g. "Created the repository for game615") and click "Commit to master" (this should be on the bottom left of the window).
1. On the top/middle region of the screen, click "Publish repository"
1. In the future, in order to upload your assignments to Github you will go through a similar process as what you did in the last two steps. You will need to first "commit" your changes, and then you will press the button labeled "Push origin" (located at the same place as the "Publish repository" button).

## Setting up your Github repository for submitting work
- Go to your web browser, log into Github.com, and find the repository you just created and posted (click the repositories tab).
- Click the "Settings" tab (located in the top middle of the window). Then, click the "Pages" button on the left middle of that window. In that window, under the label that says "Branch" there will be a dropdown that reads "None". Select "main" and click the save button.
- NOTE: If you get something that says "Upgrade or make this repository public to enable Pages", this means that you did not uncheck the box that read "keep it private" when you published your repository. To fix this, you will need to click the "General button" (on the left side of the screen), then scroll down to the bottom of the page where it says "Danger Zone" and click the "Change visibility" button. Follow the steps to make your repository "public", and then try this step again.

## Creating a Unity project
1. Using Unity Hub, create a new project
    - Click "New Project"
    - When prompoted, select "3D Core" (for now)
    - Name your project as is specified in the assignment prompts (remember, everything is case sensitive)
    - Set the project's location to the `assignments` folder within your local repository for this class (i.e. the folder on your computer).
1. For each project, create a .gitignore file with the contents located [here](https://raw.githubusercontent.com/github/gitignore/main/Unity.gitignore) and to place the file in the root directory of the Unity project.
    - Remember to save the file as exactly ".gitignore" (i.e. no file extension such as .txt or .md). I'd recommend using Visual Studio Code to create the file, and then paste in the text on the website linked above.
    - You will need to do this for every Unity project! Tons of the errors I encounter are because students forget to do this.
1. Remember to switch your build settings to WebGL.
1. Once you've done this, you will need to change one setting for your build to work. Go to `File->Build Settings`. And in that window, on the buttom left, click `Player Settings`. And then scroll down and click on `Publishing Settings`. And finally, change the `Compression Format` to `Disabled`.
1. Remember to add your Unity scene to the build settings before you build your project.
1. You might as well set the aspect ratio for your game to 16:10 now by clicking on the Game tab in Unity, and selecting the aspect ration from the dropdown list.