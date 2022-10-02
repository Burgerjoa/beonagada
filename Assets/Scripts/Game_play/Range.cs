using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{

    private Vector3 Attack_Location;

    private float Range_x;
    
    


    // Start is called before the first frame update
    void Start()
    {
        Range_x = barb.Range;
        transform.localScale = new Vector3(Range_x*0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
