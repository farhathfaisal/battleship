## Table of Contents
1. [Team Details](#Team-Details)
2. [Gameplay Overview](#Gameplay-Overview)
3. [Game Screens and Flow](#Game-Screens-and-Flow)
4. [User Interface](#User-Interface)
5. [Gameplay](#Gameplay)
6. [Assets](#Assets)

## Team Details 
* Zicong Huang	 101318649
* Farhath Faisal 100656490
* Hayden Donald	 100578604
* Zhong Wang	 101795132


## Gameplay Overview
Batteleship is a strategy type guessing game for two players, its played on ruled grids on which each player's fleet are concealed from the other player. Players alternate turns calling "shots" at the other player's ships, and the objective of the game is to destroy the opposing player's fleet.

### Target platform
Android
**visual style**： 2D
**audio style**： Classical

## Game Screens and Flow

Show  the  basic  screens  of  the  game  and  how  a  player  can  get between each. For example, show the intro/splash screen, main menu, options, in-game, high-score, closing credits, etc.

In Battleship the game flow is quite simple due to the limitations back in the day.

### General Flow Diagram
![Flow Diagram](https://raw.githubusercontent.com/farhathfaisal/battleship/master/Wiki/Image/battleshipLayout.png?token=ADCFOV7E56YEMVNCLWVQW225M6LQ4)

#### Game Flow
In general the game consists of 3 main states.

#### Pre Game
The pre game is the screen where the user chooses to find an oppoent which can either be a random person or a friend. The user in this screen should also move their battleships to their desired location.
![Start game](https://raw.githubusercontent.com/farhathfaisal/battleship/master/Wiki/Image/startOfGame.png?token=ADCFOV2MN6NRCHBNLN7ZOD25M6MTI)

#### Game
The game is where the user "plays the game". The user can click on the opponents grid to shoot a missle in an attempt to hit the opponent. In this screen the user can also talk to the opponent.
![game](https://raw.githubusercontent.com/farhathfaisal/battleship/master/Wiki/Image/gameInProgress.png?token=ADCFOV3IPMKSLXEFEPDULDC5M6NBM)

#### Post Game
In the post game screen the user can see if they won or lost the game.

## User Interface
### Main Menu
Here the player is given the option to play with a friend, a random player or the computer. If they click on friend they are given a link to share with their friend and random will present the player with a random online user.Before the player enters a game they have the option to organise their fleet on their grid.    

### The Grid
Once the game starts the user is able to click any of the given squared on the enemy's grid to attack. If they are successful it will allow them to keep selecting grid units to attack the enemy player's fleet.   


## Gameplay
Before the game begins, each player must put their boat on the grid. Each ship can be arranged horizontally or vertically. And the ship can not overlap or exceed the grid. The number of squares for each ship is determined by the type of the ship. The following is the type of the ship:

**class of ship:** Carrier,Battleship,Destroyer,Submarine,Patrol Boat     **Following Size:** 5,4,3,3,2         

**Goals:**
destroy all of your opponent's ship.

**Rules:**

1. The game proceeds in a series of rounds. In each round, each player takes a turn firing shots by calling out grid coordinates.

2. The others player will tell you "miss" or "hits".

4. Place a red marks if you hit the target. if you don't place white marks.

5. Player must tell opponent when the ship was destroyed.


## Assets 

### Game Grid 
The game board will be 10x10 grid with the number column on the left and letter row on top 
![game-board](https://raw.githubusercontent.com/farhathfaisal/battleship/master/Wiki/Image/game-board-assets.png?token=AC33YIWEDPH7PTFFSP6RJC25M6QJS)

### Battleships
There will be 2 sets of 5 png images of battleships to be used in this game. 1 set will be in blue for the player and the enemy ships will be red. The aesthetic of this game will be pixel based and the board will be a grid block . The ships will be block units of specified lengths.  

![ships](https://raw.githubusercontent.com/farhathfaisal/battleship/master/Wiki/Image/ships-assets.png?token=AC33YIRTN6HBJP5K33GPDNS5M6NVO)

### Audio 
The game will have the following audio files:
* menu-ui-click.mp3 (This will be a sound that plays when the user clicks on buttons)
* player-ship-hit.mp3 (This sound will be played when the enemy hits a player ship)
* enemy-ship-hit.mp3 (This sound will be played when the player hits a enemy ship)
* victory.mp3 (This sound plays when the player wins by destroying all enemy ships)
* defeat.mp3 (This sound plays when the player loses by having all ships destroyed by the enemy)
