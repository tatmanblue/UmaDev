using UnityEngine;

namespace TatmanGames.Character.Interfaces
{
    public interface INpcSpawnController
    {
        bool CanSpawnAtStartup(ISpawnPoint point);
        GameObject[] GetAllNpcSpawnPoints();
    }
}