# Prototype 3 - Challenge 3
### Fixed Bugs:

- The balloon would not float back up when space key was pressed
- The background would only move after 'game over', and repeat too soon, making it feel choppy and disjointed
- Game objects were not being spawned; needed to spawn randomly within the array of objects, and with specific intervals
- Fireworks particles would not play when colliding with money object, and needed to be transformed to align with the balloon
- Bonus: the balloon can float way too high
    - my solution to this was to create a "ceiling" with a negative force added to it so that the balloon would bounce off the ceiling, instead of floating in the air above it, or sticking to the ceiling until gravity brought it back down.
- Bonus: the balloon can drop below the ground
    - I did the same thing as I did with the ceiling, just in reverse with the ground. I added a small force to the ground to make the balloon bounce when it collides with it.