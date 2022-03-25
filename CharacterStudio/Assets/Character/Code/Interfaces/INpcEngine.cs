
using UnityEngine;

namespace TatmanGames.Character.Interfaces
{
    /// <summary>
    /// TODO:  perhaps this could be refactored into an environment spawner (aka)
    /// TODO:  any game object not just an NPC 
    /// </summary>
    public interface INpcEngine
    {
        string SpawnTag { get; }
        event NpcInstantiated OnNpcInstantiated;
        event NpcAutoSpawningCompleted OnAutoSpawningComplete;
        
        GameObject Instantiate(GameObject something, INpcSpawnPoint point);
    }
}