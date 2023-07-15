using GS.Wining;
using UnityEngine;
using GS.Trun.Value;
using UnityEngine.UI;
using GS.Resources.System;
using AI.System;

namespace GS.Trun
{
    public class TurnController : MonoBehaviour
    {
        public Button Button;
        public ResourcesSystem ResourcesS;
        public ValuePerTurn ValuePerTurn;
        public WinController WinController;
        public AISystem AISystem;

        private int CounterTurn = 1;
        public void NextTrun()
        {
            //Check to get limit turns
            if (CounterTurn >= byte.MaxValue)
                Debug.Log("End Game Limit turns !");
            //Check to win 
            WinController.Checkwin();

            Debug.Log($"Turn {CounterTurn}");

            ValuePerTurn.TurnValue();
            ValuePerTurn.MoneyPerTurn = 0;
            CounterTurn++;

            //add value to add end turn
            AddValueToResources();

            AISystem.BuyTitles();
        }
        /// <summary>
        /// Add value to give to next turn 
        /// </summary>
        private void AddValueToResources()
        {
            ResourcesS.Power += ResourcesS.Power;
            ResourcesS.Money += ValuePerTurn.MoneyPerTurn;
            ResourcesS.People += ValuePerTurn.PeoplePerTurn;
            ResourcesS.Polluted += ValuePerTurn.PollutedPerTurn;
        }
    }
}
