
using UnityEngine;

namespace TatmanGames.Character.Interfaces
{
    public interface INPCEngine
    {
        string SpawnTag { get; }
        event NpcInstantiated OnNpcInstantiated;
        
        void Instantiate(GameObject something, INPCSpawnPoint point);
    }
}