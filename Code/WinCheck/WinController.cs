using AI.System;
using GS.Maps;
using GS.Wining.Handler;
using UnityEngine;

namespace GS.Wining
{
    public class WinController : MonoBehaviour
    {
        [Header("How many to capture in % ")]
        [SerializeField]
        private float _TilesToWin;

        public GenMaps Titles;
        public WinHandler winHandler;
        private UISystem _UISystem;
        /// <summary>
        /// Check if you win and set limit to win 
        /// </summary>
        public void Checkwin()
        {
            _UISystem = FindObjectOfType<UISystem>();
            var GameWin = Mathf.Floor(Titles.CountTitle * _TilesToWin);// / 100;

            if (winHandler.checkTitles() >= GameWin)
            {
                _UISystem.IsWin();
            }
        }
    }
}
