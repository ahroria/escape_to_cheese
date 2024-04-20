# Escape to Cheese: A Rat's Adventure
Team:   Kirby's Dream Team
Members: Sophia Wu   	       | swu405@gatech.edu	 | swu405
	 Ramya Ramaswamy       | rramaswamy33@gatech.edu | rramaswamy33
	 Soughtout Olasupo-Ojo | solasupoojo3@gatech.edu | solasupoojo3
	 Jaysson Solano        | jsolano9@gatech.edu     | jsolano9
	 Dev Patel	       | dpatel426@gatech.edu    | dpatel426

##Game Information
Start Scene: StartingMenu

How to Play: Navigate yourself as the rat through the world. Solve various puzzles
	     to obtain keys and make your escape to obtain your reward of cheese. Obtain new 
	     skills after solving puzzles and use it to your advantage! Be careful and hide 
	     from the spiders! Spiders will ruin your progress and send you back to the 
             beginning if caught. 

Controls:    W - Move Forwards
	     S - Move Backwards
	     A - Move Left
	     D - Move Right 
	     E - Interact with Objects
	     1 - Invisibility Skill
	     Up-Arrow - Move Camera View Up (If Arrow-Camera Switch on) 
	     Down-Arrow - Move Camera View Down (If Arrow-Camera Switch on) 
	     Left-Arrow - Move Camera View Left (If Arrow-Camera Switch on) 
	     Right-Arrow - Move Camera View Right (If Arrow-Camera Switch on) 

What Parts of the Level to Observe Technology Requirements:
	- 3D Game: The game starts off on a starting menu to support starting action. There are menu UI elements to
		communication with the player to express progression, such as keeping track of the number of keys that
		the player has obtained. 
	- 3D Character with Real-Time Control: This requirement can be observed after the player clicked start on the
		start menu and loads into the starting area. The player takes control of a rat character that has fluid
		animations which responds to player input. The control schema of the player is a standard WASD control-scheme
		and there are visual UI elements which clearly express to the user what controls are tied to what 
		game elements (i.e, interaction with objects/skills) and are mapped to controls that are not difficult
		to interact with. 
	- Physics and Spatial Simulation: In the StartingArea scene, there are barrels scattered along the player's path. 
		These barrels will serve to cover locations or items to the player, leading to the player needing to interact
		and collide with the barrel to uncover new information. Within the Minigame scene, there are environmental
		physical interactions where the player has pressure panels that they much go over in the correct order to
		solve the puzzle.
	- Steering Behavior/AI: In the StartingArea scene, there are spider enemies. There are two types of spiders.
		One type of spider is an attacking spider and this AI character follows the player around. The second type of spider
		is a patrolling spider that goes between waypoints, when the player collides with the spider it stops movement and
		restarts the level. 


## Asset Implementation
format:  name - asset file name - description of implementation

Sophia Wu - Door.controller - animation controller for doors, handling the transitions states between the door
			      opening and closing. also implemented playing of sound clips when door is opened or closed.
	  - DoorClose.anim - animation for a closing door
	  - DoorOpen.anim - animation for an opening door
          - StartingArea.unity - scene where player spawns. there has been walls and doors added to the scene with
				 colliders. Unity's terrain was used to shape the terrain and add prefab objects
				 around the scene, including trees, flowers, and rocks.
          - StartMenu.unity - scene for the starting menu that includes the game logo, game buttons (start game,
			      quit), and prefab assets despicting cheese on a table. the scene has had 
			      post-processing applied to the camera.
			    - added tutorial text that updates based on player progress on the scene
          - Minigame.unity - modified scene visually with terrains and textures for player visual interest
			     added a sign with dummy text meant to show the riddle to the player
		           - after playtest, riddle was modified to be a image based puzzle to make it more intuitive and
			     easier to understand for players
			   - after playtest feedback, added helper overlay that notifies player of their current objective
          - Minigame2.unity - after playtest feedback, added helper overlay that notifies player of their current objective
	  - EndArea.unity - scene where player is taken after completing the puzzle. player interacts with the cheese on
			    the table to complete the game.

Ramya Ramaswamy - PauseMenu.unity - implemented the pause screen with different buttons for resuming the game, 
				    going back to the start menu, and quitting the game as well as pausing audio
		- OptionsMenu.unity - scene for options menu for changing volume and going back to the start menu
				      screen and in the future can be used for instructions screen
		- StartingArea.unity - added BackgroundAudio Game Object and connected the audio file in the audio
				       source component
		- StartMenu.unity - changed UI of buttons using Figma and uploaded png's for easier access to other 
				    fonts and editing
		- Story1 & Story2 - added an introduction to the game (cinematic or storytelling still images) to 
				    help the player understand the goal of the rat to escape and obtain cheese
		- PauseMenu.unity, OptionsMenu.unity, ControlsMenu.unity - created, modified and adjusted other UI screens to help player understand 
									   final objective and tie in with theme of the game (options) (change other menus to match startmenu and story) 
		- WinScene(EndArea.unity) - made an end area scene (you won!) telling the user that they won and giving them options to either
					    return back to the main menu or to quit the game

Soughtout Olasupo-Ojo - Minigame.unity - scene where path minigame occurs, has a 10x10 array of tiles. the player 
					 controlling the rat is able to walk along the path, lighting up the panels
					 as they step on them.
		      - PauseMenu.unity - Added the Arrow-Camera toggle button allowing the player to switch camera
					  functionality.

Jaysson Solano - TestingGround.unity - scene where the new camera movement and rat animations were tested. Just a blue plane with the rat ontop.
					 This is where most testing will take place that will involve the rat.
			   - SampleScene.unity - The first iteration of the starting area. This was to show the capabilities we were planning to add into
			   	the game. Most features that are implemented here are going to be refined and put into the new overhaul script that is being made.
			   - Rat prefab - Contains all the animations (walk, run, idle, more to come) as well as the scripts needed to have the rat working
			   	as intended.

Dev Patel - StartingArea.unity - Created the attacking Spider and the patrolling spider in this Area.
			       - After playtest feedback, made the enemies faster to increase difficulty.
	  - Minigame.unity - Created riddle area and set enemy AI for this area.
			   - After playtest feedback, changed area to a maze type area where the hints are stored. Set the enemy AI in this portion.
	  - Minigame3.unity - Set the enemies for the final mini game.
	  - Spider Animator Controller - Controller for the Spider's walk animation
		

## Code Contribution
format:  name - script name - description of changes

Sophia Wu - Door.cs - handles animation for doors when player interacts
 	  - PlayerInteraction.cs - handles player interaction with objects
				   shows prompts to player if object is interactable
	  - SkillUI.cs - handles toggling skill UI elements when players use skills. Intended to help player
			 understand when skills are usable or on cooldown. Cooldown function to be implemented later.
	  - TilePress.cs - modified to handle a proper solution
		           if player walks on an incorrect tile, tile now turns red and restarts the puzzle
			   added sound support for when player steps on a correct tile (audio feedback)
	  - WinMenu.cs - handles player interaction with the cheese in the final area, triggers the win menu when player
			 interacts with cheese, handles buttons on win menu to close to the game or return the main menu
				   
Jaysson Solano - AnimatorManager.cs - manages the shifts in animation
	       - NewPlayerMovement.cs - revamped the player movement system using Unity's New Input System
	       - NewPlayerManager.cs - is the bridge between the animator and the player movement
	       - NewInputManager.cs - is the base of Unity's New Input System
				      shows prompts to player if object is interactable
				      shows prompts to player if object is interactable
           - MinigameManager.cs - teleports player back to the starting area when puzzle is completed
		   - MinigameManager2.cs - ^^^
		   - MinigameManager3.cs - ^^^
		   - StealthAbility.cs - Implements the stealth ability into the game while also having a UI element represent how much you have left.
		   - CameraManager.cs - the new camera manager that handles rotations and other camera restrictions like colliding with walls.

Dev Patel - PlayerLife.cs - handles if the player is caught by the enemy, stops movement and reloads scene if so.
			  - after playtest feedback, this script handles sound from when player is caught by the enemy spider.
          - EnemyFollow.cs - enemy AI script for attacking the player.
          - MoveToWaypoints.cs - handles patrolling AI, enemies go to waypoints.


Ramya Ramaswamy - PauseMenu.cs - handled pause menu scripts for connecting buttons with different screens and
				 pausing audio when pause screen pops up
		- StartMenu.cs - implemented the start menu screen with different buttons to play the game, 
				 button to go to the options screen, and a button to quit the game
		- FillStatusBar.cs - started the script for associating the status bar with the rat's health
		- SceneSwitcher.cs - script to handle going back to the start menu screen from the endarea scene when the user has finished the game

Soughtout Olasupo-Ojo - TileInteract.cs - detects if the player has interated/collided with the tile
		      - TilePress.cs - handles pathing of the tiles
				       stores what path the player has already taken
				       stores the solution path
			               changes color of panel to green when player collides with tile
		      - ToggleCamera.cs - handles switching between the mouse and arrow keys to move the 
					  camera view 

