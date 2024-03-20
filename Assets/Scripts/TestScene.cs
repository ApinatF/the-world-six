using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    [SerializeField] private Unit[] units;
    
    public void SetIdle()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Idle;
        }
    }

    public void SetMove()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Move;
        }
    }

    public void SetAttack()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.AttackUnit;
        }
    }
    
    public void SetWork()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.BuildProgress;
        }
    }
    
    public void SetGather()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Gather;
        }
    }
}
