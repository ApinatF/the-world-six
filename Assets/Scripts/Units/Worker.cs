using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    [SerializeField]
    private ResourceSource curResourceSource;
    public ResourceSource CurResourceSource { get { return curResourceSource; } set { curResourceSource = value; } }

    [SerializeField]
    private float gatherRate = 0.5f;

    [SerializeField]
    private int gatherAmount = 1; // An amount unit can gather every "gatherRate" second(s)

    [SerializeField]
    private int amountCarry; //amount currently carried
    public int AmountCarry { get { return amountCarry; } set { amountCarry = value; } }

    [SerializeField]
    private int maxCarry = 25; //max amount to carry
    public int MaxCarry { get { return maxCarry; } set { maxCarry = value; } }

    [SerializeField]
    private ResourceType carryType;
    public ResourceType CarryType { get { return carryType; } set { carryType = value; } }

    private float lastGatherTime;
    private Unit unit;
    
    void Start()
    {
        unit = GetComponent<Unit>();
    }
}
