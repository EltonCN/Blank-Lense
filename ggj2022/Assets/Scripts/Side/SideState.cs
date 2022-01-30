using UnityEngine;

[CreateAssetMenu(menuName ="Blank/Side State")]
public class SideState : ScriptableObject
{
    public Side actualSide = Side.SIDEA;
    public GameEvent sideChangeEvent;


    public void ToggleSide()
    {
        if(actualSide == Side.SIDEA)
        {
            actualSide = Side.SIDEB;
        }
        else
        {
            actualSide = Side.SIDEA;
        }
        
        sideChangeEvent.Raise();
    }

    public void OnValidate()
    {
        sideChangeEvent.Raise();
    }

    public void SetSide(Side side)
    {
        if(side != this.actualSide)
        {
            ToggleSide();
        }
    }
}