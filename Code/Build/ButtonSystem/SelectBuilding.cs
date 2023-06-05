using GM.Effect;
using GS.Builds;
using UnityEngine;
using GM.MainScrip;

public class SelectBuilding : MonoBehaviour
{
    public GameMainScript GameMain;
    public BuildEffect BuildEffect;
    public BuildTypes BuildTypes;

    private void GetTypeBuild() => GameMain.SelectBuind(BuildTypes, BuildTypes.ID);
}
