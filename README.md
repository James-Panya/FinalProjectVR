# Final Project VR
### James Panya

## Project Description
At first I wanted to develop a virtual reality space similar to America Ninja Warrior, but after creating the movement system by finding a public preset and using YouTube videos to properly implement it I want to develop a virtual reality remake of a farming simulator. Since the America Ninja Warrior is already done, there will be a final course that'll test you to properly use the movement system to get to the finish line. As for my farming simulator, I'll make it somewhat basic by somewhat replicating mechanics from Minecraft and Stardew Valley.

## ANW Feature Breakdown
1. Recreating Monkey Tag Movement
   - Difficulty: Hard or Easy - I would like to implement some sort of movement similar to Monkey Tag, but if I'm unable to figure how to recreate it, I'll just create a teleport obstable in place.
2. Climbable Interactions
   - Difficulty: Hard - I was able to create a grab interactable that just picks up objects. Aside from that, I don't know how I'd implement a climbing interaction that pulls the character's camera as they move their arm.
   - Difficulty: Easy - Whenever a player hovers over a climbable object or if a player climbs, a haptic feedback to give them some signal. I've already done this with my Interactions Project.
3. UI Menu
   - Difficulty: Easy - Allow the user to switch between the scenes and restart the application within the menu window.
4. In-Game Button and maybe Leaderboard
   - Difficulty: Medium - Implementing the button will be easy, but sometimes the button wont recognize the hands I've created sometimes which wont be good to get the player's time. I need to also figure out how to Implement a start and stop timer.
   - Difficulty: Hard - Storing the player's time into a leaderboard will most likely require a database, unless I'm going to run the entire thing without restarting the entire thing.\
5. Particle Effects and SFX
   - Difficulty: Easy - Most likely a trigger and spawns in particles or confetti. SFX is very easy.
  
## Farming Simulator Breakdown
1. Being able to plant crops
   - Difficulty: Medium - This will use the XR Grab Interaction to pick up crops and then being able to drop the GameObject on a plot to plant it.
2. Growing the crops
   - Difficulty: Hard - Finding a way to implement a timer system to allow the plant to grow and make sure the player can't pick it up until it's fully grown. Maybe have the update system raise a GameObject and once that Object's Y axis number reaches a certain number then it'll be harvastable.
4. Farming the crops
   - Difficulty: Medium - Use the XR Grab Interaction to pick it up and put a value on the crop to sell it for money.
6. Wrist UI Menu
   - Difficulty: Easy? - I've implemented a wrist UI Menu to reset the level for ANW, but since the movement wasn't using XR Ray Interaction, it stopped working. I can implement it here for an inventory system.
7. Wrist Inventory System
   - Difficulty: Hard - When the user presses the button to spawn the Object, a crop seed for example, it should spawn in front of them. After that, once they grab it I'll turn off the button so they can't spawn multiple. Once, the player grabs the item they can't drop it or it'll destory the object and add it back into the UI Inventory.
9. Sell Area
    - Difficulty: Easy - Have a collision box where a player puts in crops and a button to sell the items.
11. Shop Menu
    - Difficulty: Easy - Most likely utilize a UI Screen and have different crops of different value and end game item.
13. End Goal
    -Difficulty: Easy - Just have a item in shop menu where if the player buys it they finish the game.

## Milestones
1. 11/16 - Implement grabbing interaction to pull camera towards more grabbable objects.
2. 11/23 - Try to recreate Monkey Tag movement.
3. 11/27 - UI Menu for scene swapping and restarting scene.
4. 11/30 - Fix the in-game button collision, implement timer at start and end of course, particle effects, and SFX.
5. 12/7 - Create the obstacle courses in all three scenes and then one big main obstacle course in one scene.
6. 12/11 - Maybe implement leaderboard. Double-check and should be done by this time.

## Inspiration
- Main inspiration for this obstacle course is America Ninja Warrior. I used to watch this a lot when I was a kid, so being able to create something similar to it would be very surreal.
  - https://www.youtube.com/watch?v=ClfvuJ6XsZY&pp=ygUmYW1lcmljYW4gbmluamEgd2FycmlvciBvYnN0YWNsZSBjb3Vyc2U%3D
- Second inspiration for the obstacle course is the VR Game called Monkey Tag. I haven't seen much games in VR, but Monkey Tag was one of the first movement games in VR that has really good movement in VR.
  - https://www.youtube.com/watch?v=DaYRryvCs7I&pp=ygUUZ29yaWxsYSB0YWcgZ2FtZXBsYXk%3D
- Third inspiration for the obstacle course is a parkour game, that I have a lot of nostalgia for, called Mirror's Edge. I believe it was one of the best hidden gems for games due to it's aesthetics and game design.
  - https://www.youtube.com/watch?v=dvQp4qqw6Js&pp=ygUWbWlycm9yJ3MgZWRnZSBnYW1lcGxheQ%3D%3D
