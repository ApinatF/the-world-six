using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCommand : MonoBehaviour
{
    public LayerMask layerMask;
    private UnitSelect unitSelect;

    private Camera cam;


    private void Awake()
    {
        unitSelect = GetComponent<UnitSelect>();
    }

    void Start()
    {
        cam = Camera.main;

        layerMask = LayerMask.GetMask("Unit", "Building", "Resource", "Ground");
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            TryCommand(Input.mousePosition);
        }
    }
    
    private void UnitsMoveToPosition(Vector3 dest, Unit unit)
    {
        if (unit != null)
            unit.MoveToPosition(dest);
    }
    
    private void CommandToGround(RaycastHit hit, Unit unit)
    {
        UnitsMoveToPosition(hit.point, unit);
    }
    
    private void TryCommand(Vector2 screenPos)
    {
        Ray ray = cam.ScreenPointToRay(screenPos);
        RaycastHit hit;

        //if we left-click something
        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            switch (hit.collider.tag)
            {
                case "Ground":
                    CommandToGround(hit, unitSelect.CurUnit);
                    break;
            }
        }
    }
}
