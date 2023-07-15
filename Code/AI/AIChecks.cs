using GS.Maps;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.Truns;

namespace AI.Checks
{
    public class AIChecks : MonoBehaviour
    {

        public float AIMoney;
        public int TitleAI;
        public GenMaps Titles;
        public AITrun AITrun;

        /// <summary>
        /// Check to skip trun or not 
        /// </summary>
        public void Check()
        {
            if(AIMoney <= 0)
            {
                Debug.Log("No money || Skip turn");
                AITrun.NextTrun();
            }

            var t = Titles.CountTitle / 2;
            // Check if AI wins 

            if (t <= TitleAI)
            {
                Debug.Log("AI Win");
            }
        }

    }
}
