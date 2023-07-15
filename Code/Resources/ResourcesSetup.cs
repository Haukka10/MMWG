using UnityEngine;

namespace GS.Resources.Setup
{
    public class ResourcesSetup : MonoBehaviour
    {

        public int People;
        public float Money;
        public int Polluted;
        public int Power;
        /// <summary>
        /// Set Defulte value on start
        /// </summary>
        public void SetUP(float DefulteMoney, int DefultePeople)
        {
            Power = 0;
            Money = DefulteMoney;
            People = DefultePeople;
            Polluted = 0;
        }
    }
}
