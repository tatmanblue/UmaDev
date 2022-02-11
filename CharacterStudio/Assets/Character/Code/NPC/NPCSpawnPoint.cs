using TatmanGames.Character.Interfaces;
using TatmanGames.Character.Scriptables;
using UnityEngine;

namespace TatmanGames.Character.NPC
{
    public class NPCSpawnPoint : MonoBehaviour, INPCSpawnPoint
    {
        public INPCSpawnData Data
        {
            get
            {
                return spawnData;
            } 
            
        }
        
        [SerializeField] private NPCSpawnData spawnData;
    }
}