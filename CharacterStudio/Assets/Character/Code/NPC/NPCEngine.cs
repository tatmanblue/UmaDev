using TatmanGames.Character.Interfaces;
using UnityEngine;

namespace TatmanGames.Character.NPC
{
    public class NPCEngine : INPCEngine
    {
        public string SpawnTag { get; private set; } = "NPCSpawn";
        public event NpcInstantiated OnNpcInstantiated;

        public void Instantiate(GameObject something, INPCSpawnPoint point)
        {
            GameObject.Instantiate(point.Data.NPCAvatar, something.transform.position, something.transform.rotation);
        }

        private void FireOnNpcInstantiated(INPCSpawnPoint point)
        {
            NpcInstantiated instantiated = OnNpcInstantiated;
            if (null == instantiated)
                return;

            instantiated(point);
        }
    }
}