using GS.Builds;
using GS.Trun.Value;
using System.Collections.Generic;
using UnityEngine;
using GS.Resources.Setup;


namespace GS.Resources.System
{
    public class ResourcesSystem : ResourcesSetup
    {
        private Dictionary<string, int> _AllValue = new Dictionary<string, int>();
        public ValuePerTurn valuePerTurn;
        /// <summary>
        /// Add value to dictionary and return full dictionary
        /// </summary>
        /// <param name="buildTypes"></param>
        /// <returns></returns>
        public Dictionary<string, int> AddValue(BuildTypes buildTypes)
        {
            _AllValue.Add("Cost", buildTypes.Cost);
            _AllValue.Add("Polluted", buildTypes.Polluted);
            var Power = Mathf.FloorToInt(buildTypes.MakePower);
            _AllValue.Add("Power", Power);
            var Conusme_Power = Mathf.FloorToInt(buildTypes.ConusmePower);
            _AllValue.Add("Conusme_Power", Conusme_Power);

            SetValue();
            return _AllValue;
        }

        private void SetValue()
        {
            if (_AllValue.ContainsKey("Cost"))
            {
                _AllValue.TryGetValue("Cost", out var value);
                valuePerTurn.MoneyPerTurn += value;
            }

            if (_AllValue.ContainsKey("Polluted"))
            {
                _AllValue.TryGetValue("Polluted", out var value);
                valuePerTurn.PollutedPerTurn += value;
            }

            if (_AllValue.ContainsKey("Power"))
            {
                _AllValue.TryGetValue("Power", out var value);
                valuePerTurn.MakePowerPerTurn += value;
            }

            if (_AllValue.ContainsKey("People"))
            {
                _AllValue.TryGetValue("People", out var value);
                valuePerTurn.PeoplePerTurn += value;
            }

            if (_AllValue.ContainsKey("Conusme_Power"))
            {
                _AllValue.TryGetValue("Conusme_Power", out var value);
                valuePerTurn.ConusmePowerPerTurn += value;
            }
            PrintAndClean();
        }
        private void PrintAndClean()
        {
            Debug.Log(Money + " <- Money " + People
            + " <- People " + Polluted + " <- Polluted "
             + Power + " <- Power");
            _AllValue = new Dictionary<string, int>();
        }
    }
}
