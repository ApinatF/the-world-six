using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] 
    private GameObject selectionMarker;
    public GameObject SelectionMarker { get { return selectionMarker; } }

    public static MainUI instance;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
