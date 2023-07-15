using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GS.Trun.Value;
using GS.Resources.System;

public class UISystem : MonoBehaviour
{
    public TextMeshProUGUI TextMoney;
    public TextMeshProUGUI TextPeople;
    public TextMeshProUGUI TextPolluted;
    public TextMeshProUGUI TextPower;
    public TextMeshProUGUI TextMakepowr;

    public ResourcesSystem resourcesSystem;
    public ValuePerTurn ValuePerTurn;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(resourcesSystem.Money.ToString());
        TextMoney.text = "Money: " + resourcesSystem.Money.ToString();
        TextPeople.text = "People: " + resourcesSystem.People.ToString();
        TextPolluted.text = "Polluted: " + resourcesSystem.Polluted.ToString();
        TextMakepowr.text = "Power per Turn: " + ValuePerTurn.MakePowerPerTurn.ToString();
        TextPower.text = "Power: " + resourcesSystem.Power.ToString();
    }
}
