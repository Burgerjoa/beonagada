using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public GameObject Target;
    private Transform Tr;

    private Vector3 Attack_Location;

    private float Range_x;
    // Start is called before the first frame update
    void Start()
    {
        Range_x = barb.Range;
        Tr = GetComponent<Transform>();
        
        transform.localScale = new Vector3(Range_x, 3);


    }

    // Update is called once per frame
    void Update()
    {        
        if (Target == null)
        {
            Target = GameObject.FindWithTag("Player"); // Object의 이름으로 대상을 찾음, 이름이 같을 경우 가장 처음 검색된 Object 반환
            
        }

        Attack_Location.x = Target.transform.position.x + 1;
        Tr.position = Attack_Location;
    }
}
