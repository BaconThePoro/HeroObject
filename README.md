# HeroObject

Objective
How we can create/delete game objects, and, gain some insights into frame vs. wall-clock (real) time.

Coverage
Unity specific skills you will need, practice, and demonstrate include:

Working with Unity Prefab

o   Create a prefab in the editor

o   Create/Delete objects at run time

Working with Transform of GameObject

o   Set positions

o   Set object rotation/orientation

User Interface

o   Getting world position from the mouse

Object collisions and responses

 

Concepts you will explore and understand include

The camera and visible world bound
Frame update time vs, wall-clock real time
Randomness with simple examples in games
Simple direct object control: driving an object
Approach
Please refer to my attempt at the solutionLinks to an external site.. Note the followings, there are three main object categories: hero, eggs spawned, and enemies.

If you would like to setup a private GitHub directory, you can do so by following this linkLinks to an external site..

Here are the details:

World Camera Setting
Height of 100 (total world height is 200)
Hero
Size: 5x5
Control model: Key-M toggles between mouse or keyboard control
Mouse control: Hero’s position follow that of the mouse at all time. This is the default control (easy for me to test)
Keyboard control: Up/Down (WS) keys gradually increases/decreases the Hero’s speed moving towards its Transform.up direction.
Initial speed: 20 units/second
Left/Right (AD) keys: turn the hero towards left/right at a rate of 45-degrees per second.
Space-bar: spawns an egg-projectile (refer to next section) at a rate of one egg every 0.2 seconds
Spawned Egg
Size: 1x1
Aligned with the Transform.up direction of the hero at the spawn time
Spawned eggs travers towards its Transform.up direction at a speed of 40 unit/sec
Spawned eggs expires when either of the following condition is true
o   It reaches the bounds of the world

o   It collides with an enemy

Enemy and Spawning
Each enemy size is 5x5
There are always 10 enemies in the world
Enemies are within 90% of the world boundaries
When an enemy comes in contact:
With the hero, it is destroyed
With the egg: it loses 80% of its current energy (displayed as alpha-channel scaled by 80%):
 

GetComponent<Renderer>().material.color.a *= 0.8;

// Note, the above line does not run as Unity does not

// allow the modification of Color channels. You must

// create/modify/assign using a separate Color object

 

The 4th collision with an egg destroys an enemy
As soon as an enemy is destroyed, a new one is spawned subject to the above condition (maintain exactly 10, always within 90% of world boundaries) 
Application Status
The application must print out the following status:

Hero: control mode: Mouse/Keyboard, Number of times hero touched the enemy
Egg: Number of eggs that are currently in the world
Enemy: Total current enemy count (always 10), Total number destroyed
Q-key: Quits the application
Credit Distribution
(2%) Camera Setting

o   Height of 100

(30%) Hero

Size 5x5
Left/Right (AD) Keys: rotation
Key-M to toggle between mouse/keyboard control
In mouse mode: position is controlled by the mouse
In keyboard mode: Initial speed is 20 units/sec
In keyboard mode: Up/Down (WS) keys control speed smoothly
Space-bar spawns egg at 0.2 second per egg
Destroys an enemy when collided
(24%) Egg Behavior

Size 1x1
Orientation follows that of Hero’s transform.up
Travels towards its transform.up at 40 units/sec
Expires when collide with enemy
Expires when leaves the world bound
Graded based on proper application status echo of number of eggs currently in the world
(24%) Enemies

Size: 5x5
Maintains 10 enemies in the world
Spawned randomly within 90% of world boundaries
Destroyed by hero collision
Gradual loosing of power (alpha-channel) by Egg collision
Destroy by 4th Egg collision
(10%) Application Status

Hero control mode and collision with enemy count
Egg: number in the world
Enemy: total number in the world + number destroyed
Submissions
Edit with your name on the shared google spreadsheetLinks to an external site. + proper WebGL link in the document (that I can click and test your project)
Submission to Canvas with a zip
For the project, you only need to include Assets, Packages, ProjectSettings and UserSettings folder. The Library folder can be regenerated at run-rime.
'self-assessment.pdf' indicating all the features you have implemented and not implemented
Unzip and run in the editor properly, no extra files/folders in submission
Double click successfully runs the game
Extra Credit:
Max extra credit: is 20-points. Ideas for extra credits include:

Key control to enable random movements (flying) of the enemies
Key control to enable hero destruction if number of collision with enemy is too high
Different key to spawn different projectiles that can cause different damage on the enemies
Different kinds of enemies
Etc. etc. etc.
