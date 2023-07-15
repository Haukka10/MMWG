using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.Difficulty;
using AI.Behaviour;
using AI.Checks;
using GS.Builds;

namespace AI.System
{
    public class AISystem : MonoBehaviour
    {
        public AIDifficulty AIDifficulty;
        public AIBehaviour AIBehaviour;
        public AIChecks AIChecks;
        public List<BuildTypes> buildTypes = new List<BuildTypes>();

        private string[] NamesTitles = { "Golden", "Stone", "Grass", "Oli", "River" };
        /// <summary>
        /// Set random titles to buy for AI
        /// </summary>
        public void BuyTitles()
        {
            var names = NamesTitles[RandomTitles(0, NamesTitles.Length)];

            AIBehaviour.AllTitles.TryGetValue(names, out var title);

            var FinaleTitle =  title[RandomTitles(0, title.Length)];

            var BuildID = buildTypes[RandomTitles(0, buildTypes.Count)];
            Debug.Log(FinaleTitle.Name);

            if (AIChecks.AIMoney >= BuildID.Cost && BuildID.Teams == GM.Teams.TeamsController.Teams.AI)
            {
                BuildID.Cost -= AIChecks.TitleAI;
                FinaleTitle.SetOwnerTeam = GM.Teams.TeamsController.Teams.AI;
            }

            AIChecks.Check();
            AIChecks.TitleAI++;
        }
        private int RandomTitles(int min , int max)
        {
            return Random.Range(min, max);
        }
    }
}
