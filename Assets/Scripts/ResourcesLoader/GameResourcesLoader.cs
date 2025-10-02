using Game.Tiles;
using UnityEngine;

namespace ResourcesLoader
{
    public class GameResourcesLoader : MonoBehaviour
    {
        [SerializeField] private GameObject _tilePrefub;
        [SerializeField] private TileSetConfig _tileSetConfig;

        public GameObject TilePrefub => _tilePrefub;

        public TileSetConfig TileSetConfig => _tileSetConfig;
    }
}