using GM.SystemTiles;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GS.Wining.Handler
{
    public class WinHandler : MonoBehaviour
    {
        private List<TilesSystem> _AllTiles = new List<TilesSystem>();
        private List<TilesSystem> _WiningTitles = new List<TilesSystem>();
        private void Start() => _AllTiles = FindObjectsOfType<TilesSystem>().ToList();
        /// <summary>
        /// Check titles who is owner is player or AI
        /// </summary>
        /// <returns></returns>
        public int checkTitles()
        {
            _WiningTitles.Clear();

            if (_AllTiles.Count < 500)
            {
                foreach (var item in _AllTiles)
                {
                    if (item.Isfull)
                        _WiningTitles.Add(item);
                }
                return _WiningTitles.Count;
            }
            else
            {
                for (int i = 0; i < _AllTiles.Count; i++)
                {
                    if (_AllTiles[i].Isfull)
                        _WiningTitles.Add(_AllTiles[i]);
                }

                return _WiningTitles.Count;
            }
        }

    }
}
