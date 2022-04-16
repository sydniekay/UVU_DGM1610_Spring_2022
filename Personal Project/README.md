# Personal Project - Beetle Blast
## Player Controls
### Current Working Features:
- Player can move left and right with the arrow keys
- Player is constrained to bounds
- Player's velocity resets when it reaches bounds
- Enemies and health can move up the screen at different speeds
- Player can shoot/spray by pressing the spacebar
### Features to Add:
- Enemies and health spawn randomly
- Speed of bugs increases over time
- Number of beetles increase over time
- Health has a constant rotation (animation mimic)
- Destroy objects when they collide
- Dying animations when objects collide
- Health animation
- UI stuff 
### Features to Change:
- Player controls switch to mouse click instead of arrow keys
- Spray bottle moves with mouse, shoots projectile in the direction of the click (or we could just have a spray animation with the bottle, and an animation on the insect implying that it has been sprayed)
- Insects come from all directions instead of just moving bottom to top
- Edit trigger controls on objects

### Log:
- 4/15/22: As I was working with my code today to fix some of the functionality I had implemented last week I came to the conclusion that I wanted to change pretty much all of the game mechanics that I had made previously. This was especially influenced by the free assets available through the Unity Store, and some of the new functionalities that we learned working on Prototype 5. That being said, it became apparent that it would be much faster for me to simply scrap my scripts and replace my assets and almost start over than to try and walk through all of my previously written code and work around it.

    My current plan is to replace my placeholder assets with the actual game assets, leave the environment how I have it for now, and write some brand new scripts organizing them better  by using a GameManager script. Essentially, for basic gameplay to be working how I want I need to have player controls (using the mouse), enemy spawning (randomized locations and varying speeds), and a wave system for increasing difficulty. 

- 4/16/22: Things that are working: 
    - Targets spawn from a list
    - Clicking a beetle with the mouse will destroy the object
    - Random Enemies spawn every second
    - Enemies are destroyed out of bounds on x axis
    - Enemies spawn on either side of the screen
    - Health spawns on either side of the screen
    - Health rotates continuously as it moves across the screen
    - Enemies spawn facing the right direction based on what side they enter from
    - Enemies and health travel in the direction they are facing
   
   Things I need to get working:
    - Projectile needs to travel in the direction of the mouse
    - three difficulty levels (change how quickly enemies spawn, and speeds) instead of a wave feature
    - Turret needs to rotate with the direction of the mouse
    - Lose a life when you miss a beetle (3 lives total)
    - Keep score, faster bugs are more points
    - Gain a life when you hit a health gem










