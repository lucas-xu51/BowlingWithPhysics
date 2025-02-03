# Bowling with Physics

## project display


Uploading BowlingWithPhysics - SampleScene - Windows, Mac, Linux - Unity 6 (6000.0.31f1) _DX11_ 2025-02-03 14-26-24.mp4…



## 1. Project Introduction  
"Bowling with Physics" is a bowling game project developed using the Unity engine. This project aims to help developers gain an in-depth understanding of key concepts such as Unity's physics engine, game object control, user input handling, scoring system, and game state management. By completing this project, developers will learn how to build an interactive game with physics simulation in Unity.  

## 2. Features  

- **Player Control**: The player can move left and right using the "A" and "D" keys and launch the bowling ball by pressing the spacebar. The camera can be controlled with the mouse for precise aiming.  
- **Physics Simulation**: Unity's physics engine is used to realistically simulate the collision between the bowling ball and the pins. Pins will fall upon impact, and the ball will move according to real-world physics rules.  
- **Scoring System**: When pins are knocked down, the game automatically detects and updates the player's score, which is displayed in real-time on the game interface.  
- **Game Reset**: Pressing the "R" key resets the game. The ball returns to its starting position, and the pins are regenerated while the accumulated score remains unchanged.  

## 3. Project Structure  

- **Assets**: Contains various resources required for the project, such as scripts, prefabs, materials, and models.  
- **Scripts**: Contains scripts that control the game logic, such as `InputManager.cs` for handling user input, `BallController.cs` for controlling ball movement, and `GameManager.cs` for managing game states and scores.  
- **Prefabs**: Stores reusable game object templates, such as pins and gutters, making them easy to use multiple times in the game.  
- **Materials**: Defines different physics materials that control properties like friction and elasticity.  
- **Models**: Stores 3D models imported from external sources to replace Unity's default geometric shapes, enhancing the game's visual appeal.  

## 4. How to Run  

1. Ensure that Unity is installed.  (Unity 6000.0.31f1)
2. Import the project files and resources into a Unity project.  
3. In the Unity Editor, click the play button to experience the bowling game.  

## 5. Key Technical Implementations  

- **Input Handling**: Uses Unity’s `Input` class and `UnityEvent` to listen for and process player keyboard and mouse inputs.  
- **Physics Components**: Adds `Rigidbody` and `Collider` components to game objects with properly configured parameters to achieve realistic physics simulation.  
- **Event System**: Uses `UnityEvent` to establish an event-driven mechanism, enabling effective interaction and communication between different game objects.  
- **UI Display**: Uses Unity’s `Canvas` and `TextMeshPro` components to display the player's score in real time.  

## 6. Notes  

- When importing external resources, ensure you have the legal rights to use them. It is recommended to use assets with a **CC0 license**.  
- Thoroughly test physics parameters and game logic adjustments to prevent unexpected behavior.  
