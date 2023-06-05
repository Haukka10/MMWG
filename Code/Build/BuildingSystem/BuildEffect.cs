using GS.Builds;
using UnityEngine;

namespace GM.Effect
{
    public class BuildEffect : MonoBehaviour
    {
        private float Multiplier = 0.15f;
        private float MultiplierCost = 0.20f;

        /// <summary>
        /// list all effects 
        /// </summary>
        public enum effects
        {
            AddCost,
            RemoveCost,
            AddPowor,
            RemovePowor,
            MakePolluted
        }
        public effects Effects;
        public void SetEffect(BuildTypes buildTypes, effects effect)
        {
            switch (effect)
            {
                case effects.AddCost:
                    buildTypes.Cost += (int)(buildTypes.Cost * MultiplierCost);
                    break;
                case effects.RemoveCost:
                    buildTypes.Cost -= (int)(buildTypes.Cost / MultiplierCost);
                    break;
                case effects.AddPowor:
                    buildTypes.MakePower += (int)(buildTypes.MakePower * Multiplier);
                    break;
                case effects.RemovePowor:
                    buildTypes.MakePower -= (int)(buildTypes.MakePower / Multiplier);
                    break;
                case effects.MakePolluted:
                    buildTypes.Polluted += 2;
                    break;
                default:
                    break;
            }
        }
        public void AddEffect(BuildTypes buildTypes, effects effects)
        {

            switch (buildTypes.TypesEnergy)
            {
                case BuildTypes.typesenergy.Wind_Turbine:
                    SetEffect(buildTypes,effects.AddCost);
                    break;
                case BuildTypes.typesenergy.Coal_Reactor:
                    break;
                case BuildTypes.typesenergy.Water_Turbine:
                    break;
                case BuildTypes.typesenergy.Solar_Panel:
                    break;
                case BuildTypes.typesenergy.Nuclear_Reactor:
                    break;
                case BuildTypes.typesenergy.Oli_Generator:
                    break;
                default:
                    break;
            }

        }

    }
}
