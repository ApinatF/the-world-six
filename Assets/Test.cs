using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject[] MyArray;
    [SerializeField]
    private List<int> MyList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        MyList.Add(4);
        MyList.Add(7);
        MyList.Add(9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
