using AI.Checks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.Difficulty;

namespace AI.Truns
{
    public class AITrun : MonoBehaviour
    {
        public AIChecks AIChecks;
        public AIDifficulty AIDifficulty;
        private int Turn = 1;
        private int turnAI = 1;
        public void NextTrun()
        {
            if (turnAI == Turn)
                AIChecks.AIMoney += AIDifficulty.AddMoney;

            turnAI++;
            Turn++;
            AIDifficulty.AddMoney += 50;

        }
    }
}
