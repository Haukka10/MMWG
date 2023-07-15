using GM.MainScrip;
using GS.Builds;
using System.Collections.Generic;
using UnityEngine;
using GM.Teams;

namespace GM.SystemTiles
{
    public class TilesSystem : MonoBehaviour
    {
        public TypeTitle Tile;

        public bool Isfull = false;
        [SerializeField]
        private SpriteRenderer _SpriteRenderer;

        private int _MaxBuildings;
        private int _SpaceAvailable;
        private GameMainScript _gameMainScript;
        private TeamsController.Teams _SetTeam;
        private List<BuildTypes> _buildings = new List<BuildTypes>();

        private void Start()
        {
            _gameMainScript = FindObjectOfType<GameMainScript>();
            _SetTeam = FindObjectOfType<TeamsController>().SetTeams;
            _SetTeam = TeamsController.Teams.None;
            _MaxBuildings = Tile.AmmonSpace;
            _SpaceAvailable = Tile.AmmonSpace;
        }
        private void OnMouseEnter() => _SpriteRenderer.sprite = Tile.HoverSprite;
        private void OnMouseOver()
        {
            try
            {
                if (_SpaceAvailable >= _gameMainScript.BuildTypes.SpaceToBuild && _gameMainScript.ResourcesSystem.Money >= _gameMainScript.BuildTypes.Cost &&_gameMainScript.BuildTypes.Teams != TeamsController.Teams.Human )
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        AddBuild();
                        _SpaceAvailable -= _gameMainScript.BuildTypes.SpaceToBuild;
                        _gameMainScript.ResourcesSystem.Money -= _gameMainScript.BuildTypes.Cost;
                        _SetTeam = TeamsController.Teams.Human;
                    }
                }
            }
            catch { Debug.Log("Not select build or GameObcje not set"); }
        }
        /// <summary>
        /// Add build to titles
        /// </summary>
        private void AddBuild()
        {
            if(_SpaceAvailable <= 0)
            Isfull = true;
            
            _gameMainScript.AddResources();
            _gameMainScript.GetActiveBuilding();
            _buildings.Add(_gameMainScript.BuildTypes);
        }

        private void OnMouseExit() => _SpriteRenderer.sprite = Tile.IdleSprite;
    }
}