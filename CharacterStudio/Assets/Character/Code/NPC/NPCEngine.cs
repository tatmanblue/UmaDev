using TatmanGames.Character.Interfaces;

namespace TatmanGames.Character.NPC
{
    public class NPCEngine : INPCEngine
    {
        public string SpawnTag { get; private set; } = "NPCSpawn";
    }
}