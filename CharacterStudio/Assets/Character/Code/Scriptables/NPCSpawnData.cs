using System.Collections;
using System.Collections.Generic;
using TatmanGames.Character.Interfaces;
using UnityEngine;

namespace TatmanGames.Character.Scriptables
{

    /// <summary>
    /// a persisted view, so to speak, into a model INPCSpawnData
    /// </summary>
    [CreateAssetMenu(fileName = "SpawnData", menuName = "Tatman Games/Characters/NPC Spawner")]
    public class NPCSpawnData : ScriptableObject, INPCSpawnData
    {
        public int Id
        {
            get { return id; }
        }

        [SerializeField] private int id;
    }

}
