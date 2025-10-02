using Game.Tiles;
using UnityEngine;

namespace ResourcesLoader
{
    public class GameResourcesLoader : MonoBehaviour
    {
        [SerializeField] private GameObject _tilePrefub;
        [SerializeField] private GameObject _blankPrefub;
        [SerializeField] private TileConfig _blankConfig;
        [SerializeField] private TileSetConfig _tileSetConfig;

        public GameObject TilePrefub => _tilePrefub;

        public TileSetConfig TileSetConfig => _tileSetConfig;

        public GameObject BlankPrefub => _blankPrefub;

        public TileConfig BlankConfig => _blankConfig;
    }
}