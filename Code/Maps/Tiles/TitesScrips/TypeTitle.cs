using System;
using GM.Teams;
using UnityEngine;

[CreateAssetMenu(fileName = "TypeTitle", menuName = "ScriptableObjects/Titles", order = 1)]

public class TypeTitle : ScriptableObject
{
    public string Name;
    [Multiline]
    public string Description;
    public string TypeString;
    public int AmmonSpace;
    public Sprite IdleSprite, HoverSprite;
    public bool IsStone;

    private string[] _Types;
    private string _CustomType;
    private TeamsController.Teams _Team;

    public TeamsController.Teams SetOwnerTeam
    {
        get
        {
            return _Team;
        }
        set
        { 
            _Team = value;
        }
    }

    public enum Types : int
    {
        Grass = 0,
        stone = 1,
        river = 2,
        oli = 3,
        golden = 4,
    }
    public Types Type;

    public void Setup()
    {
        _Types = Enum.GetNames(typeof(Types));
        _CustomType = TypeString;
        foreach (var item in _Types)
        {
            if (!string.IsNullOrEmpty(TypeString))
                if (!string.Equals(item, TypeString))
                {
                    _Types = new string[_Types.Length + 1];
                    _Types.SetValue(TypeString, _Types.Length - 1);
                    Debug.LogWarning($"{TypeString} is not set int types add to list (of index {_Types.Length - 1}) ");
                    TypeString = String.Empty;
                }
        }
        Debug.Log("All item check successful");
    }
}
