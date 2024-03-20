using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private Animator anim;
    private Unit unit;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimation(unit);
    }
    
    
    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsWorking", false);
        
        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
            case UnitState.MoveToBuild:
            case UnitState.MoveToResource:
            case UnitState.DeliverToHQ:
                anim.SetBool("IsMove", true);
                anim.SetBool("IsGather", false);
                break;
            case UnitState.AttackUnit:
                anim.SetBool("IsAttack", true);
                break;
            case UnitState.BuildProgress:
                anim.SetBool("IsWorking", true);
                break;
            case UnitState.Gather:
                anim.SetBool("IsGather", true);
                break;
        }
    }


}
