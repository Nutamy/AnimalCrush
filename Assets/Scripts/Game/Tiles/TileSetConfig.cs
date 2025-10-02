using System.Collections.Generic;
using UnityEngine;

namespace Game.Tiles
{
    [CreateAssetMenu(fileName = "TileSetConfig", menuName = "Config/TileSetConfig", order = 0)]
    public class TileSetConfig : ScriptableObject
    {
        [SerializeField] private List<TileConfig> _set = new List<TileConfig>();
        public List<TileConfig> Set => _set;
    }
}