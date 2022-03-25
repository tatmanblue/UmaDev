using TatmanGames.Character.Interfaces;
using TatmanGames.Character.Scriptables;
using UnityEngine;

namespace TatmanGames.Character.NPC
{
    public class SpawnPoint : MonoBehaviour, ISpawnPoint
    {
        public IEnvironmentSpawnData Data
        {
            get
            {
                return spawnData;
            } 
            
        }
        
        [SerializeField] private EnvironmentSpawnData spawnData;
    }
}