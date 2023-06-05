using GM.Teams;
using GS.Builds;
using GS.BuildsSys;
using GS.Resources.System;

using System.Collections.Generic;
using UnityEngine;

namespace GM.MainScrip
{
    public class GameMainScript : MonoBehaviour
    {

        public List<TypeTitle> typeTitles = new List<TypeTitle>();
        public int StartValue;
        public int StartPeople;
        public float StartMoney;
        public BuildTypes BuildTypes;

        [HideInInspector]
        public TeamsController TeamsController;
        [HideInInspector]
        public BuildingSys BuildingSys;
        [HideInInspector]
        public ResourcesSystem ResourcesSystem;
        

        private int IDB;
        /// <summary>
        /// Set up all values and Systems
        /// </summary>
        private void Start()
        {
            BuildTypes = null;
            TeamsController = FindObjectOfType<TeamsController>();
            ResourcesSystem.SetUP(StartValue, StartMoney, StartPeople);

            for (int i = 0; i < typeTitles.Count; i++)
                typeTitles[i].Setup();
        }

        public void SelectBuind(BuildTypes buildTypes, int id)
        {
            IDB = id;
            BuildTypes = buildTypes;
        }
        public void GetActiveBuilding() => BuildingSys.SetBuild(IDB);
        public void AddResources() => ResourcesSystem.AddValue(BuildTypes);
    }
}
