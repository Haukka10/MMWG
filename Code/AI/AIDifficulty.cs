using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI.Difficulty
{
    public class AIDifficulty : MonoBehaviour
    {
        public Difficulty difficulty;
        public int MaxCapTitles;
        public enum Difficulty
        {
            Eeasy,
            Medium,
            Hard,
            Very_Hard
        }

        [HideInInspector]
        public int AddMoney;

        public void Start() => SetDifficulty(difficulty);
        private void SetDifficulty(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Eeasy:
                    AddMoney = 100;
                    MaxCapTitles = 1;
                    break;
                case Difficulty.Medium:
                    AddMoney = 125;
                    MaxCapTitles = 2;
                    break;
                case Difficulty.Hard:
                    AddMoney = 170;
                    MaxCapTitles = 3;
                    break;
                case Difficulty.Very_Hard:
                    AddMoney = 270;
                    MaxCapTitles = 5;
                    break;
                default:
                    AddMoney = 125;
                    MaxCapTitles = 2;
                    break;
            }
        }
    }
}
