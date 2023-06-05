using UnityEngine;

namespace GS.Resources
{
    public class Resources : MonoBehaviour
    {

        public int People { get; set; }
        public float Money { get; set; }
        public int Polluted { get; set; }
        public int Power { get; set; }
        /// <summary>
        /// Set Defulte value on start
        /// </summary>
        public void SetUP(int DefulteValue, float DefulteMoney, int DefultePeople)
        {
            Power = DefulteValue;
            Money = DefulteMoney;
            People = DefultePeople;
            Polluted = DefulteValue;
        }
    }
}
