using GS.Resources.System;
using UnityEngine;

namespace GS.Trun.Value
{
    public class ValuePerTurn : MonoBehaviour
    {
        private int _money;
        private int _people;
        private int _polluted;
        private int _power;
        private int _Makepowr;

        public ResourcesSystem resourcesSystem;
        public int MoneyPerTurn
        {
            get { return _money; }
            set { _money = value; }
        }
        public int PeoplePerTurn
        {
            get { return _people; }
            set { _people = value; }
        }
        public int PollutedPerTurn
        {
            get { return _polluted; }
            set { _polluted = value; }
        }
        public int ConusmePowerPerTurn
        {
            get { return _power; }
            set { _power = value; }
        }
        public int MakePowerPerTurn
        {
            get { return _Makepowr; }
            set { _Makepowr = value; }
        }
        /// <summary>
        /// Get value per turn
        /// </summary>
        public void TurnValue()
        {
            resourcesSystem.Power -= MakePowerPerTurn;
            resourcesSystem.Power += ConusmePowerPerTurn;
            resourcesSystem.People += PeoplePerTurn;
            resourcesSystem.Money += MoneyPerTurn;
        }
    }
}
