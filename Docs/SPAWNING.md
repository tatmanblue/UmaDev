# Spawning Engine

## Overview

## Setting up spawning with Scriptable Object
1. Create an instance of the `NPCSpawnData` scriptable object.  Easiest solution is, in unity project window, right click and select
`SpawnData` from the `Tatman Games/NPC Spawn Data` menu choice.

2. Edit this item, setting the id and dragging an NPC gameobject to the `NPC Avatar` field.

3. In the scene, create and empty game object, placing it where you want the NPC to appear.

4. Set the tag of this game object to `NPCSpawn`.  Note this tag value is saved in the [INpcEngine implementation](https://github.com/tatmanblue/Unity-Characters/blob/9f1b74d62dfc76c83df64db1fc7a0c2cd5e539c7/CharacterStudio/Assets/Character/Code/Interfaces/INpcEngine.cs#L12) 
so if you change it there, gameobjects in the scene must be updated.

5. Attach a `NPC Spawn Point` to the gameobject and set `Spawn Data` to the scriptable object created in step 1.

