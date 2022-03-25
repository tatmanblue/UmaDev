using System.Collections;
using System.Collections.Generic;
using TatmanGames.Character.Interfaces;
using UnityEngine;

namespace TatmanGames.Character.Scriptables
{

    /// <summary>
    /// a persisted view, so to speak, into a model INPCSpawnData
    /// </summary>
    [CreateAssetMenu(fileName = "SpawnData", menuName = "Tatman Games/NPC Spawn Data")]
    public class SpawnData : ScriptableObject, ISpawnData
    {
        public int Id
        {
            get { return id; }
        }

        public GameObject NpcAvatar {
            get
            {
                return npcAvatar;
            }
        }

        public bool DestroyPointOnSpawn
        {
            get { return true; }
        }


        [SerializeField] private int id;
        [SerializeField] private GameObject npcAvatar;
    }

}