using GM.Effect;
using GS.Builds;
using UnityEngine;
using GM.MainScrip;

public class SelectBuilding : MonoBehaviour
{
    public GameMainScript GameMain;
    public BuildTypes BuildTypes;

    private void Start() => GameMain = FindObjectOfType<GameMainScript>();
    public void GetTypeBuild() => GameMain.SelectBuind(BuildTypes, BuildTypes.ID);
}
