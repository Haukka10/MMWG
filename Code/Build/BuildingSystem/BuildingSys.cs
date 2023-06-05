using GS.Builds;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GS.BuildsSys
{
    public class BuildingSys : MonoBehaviour
    {
        private List<TypeTitle> typeTitle = new List<TypeTitle>();
        private List<BuildTypes> buildTypes = new List<BuildTypes>();

        private int _oldCons;
        /// <summary>
        /// Add 25% to cost is you build stone
        /// </summary>
        /// <param name="index"></param>
        public void SetBuild(int index)
        {
            foreach (var item in typeTitle)
            {
                if (buildTypes[index].CanStoneBuild == true)
                {
                    if (item.IsStone == true)
                    {
                        _oldCons = buildTypes[index].Cost;
                        Debug.Log(buildTypes[index].Cost + "old cost");
                        double newcost = buildTypes[index].Cost * 0.25;
                        Math.Floor(newcost);

                        buildTypes[index].Cost = (int)(buildTypes[index].Cost + newcost);
                        Debug.Log(buildTypes[index].Cost + "New cost");
                        buildTypes[index].Cost = _oldCons;

                       return;
                    }
                }
                else
                    Debug.Log("Not stone");
            }
        }
    }
}
