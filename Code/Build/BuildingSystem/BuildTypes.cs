using UnityEngine;
using GM.Teams;

namespace GS.Builds
{
    [CreateAssetMenu(fileName = "Builds", menuName = "ScriptableObjects/Building", order = 1)]
    public class BuildTypes : ScriptableObject
    {
        [Header("Build name and description")]
        public int ID;
        public string Name;
        public Sprite Sprite;
        [Multiline]
        public string Description;
        public bool CanStoneBuild;
        [Header("Cost and Res")]
        public int Cost;
        public int Polluted;
        public int People;
        public float MakePower;
        public float ConusmePower;
        public float Resources;
        public int SpaceToBuild;
        public typesenergy TypesEnergy;
        public TeamsController.Teams Teams;

        [HideInInspector]
        public bool IsToPeople;

        public enum typesenergy
        {
            Wind_Turbine,
            Coal_Reactor,
            Water_Turbine,
            Solar_Panel,
            Nuclear_Reactor,
            Oli_Generator
        }
        private void Awake() => Teams = TeamsController.Teams.AI;
    }
}
