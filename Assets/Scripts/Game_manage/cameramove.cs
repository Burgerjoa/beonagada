using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    private float offsetx = 1.1f;

    private float offsetz = -3f;

    private Vector3 CameraPosition;
    public GameObject player = null;
    public GameObject[] charPrefabs;
    private string selectedChar;



    private void Update()
    {

        if (player == null)
        {
            player = GameObject.Find("Barbarian"); // Object의 이름으로 대상을 찾음, 이름이 같을 경우 가장 처음 검색된 Object 반환

        }
        CameraPosition.x = player.transform.position.x + offsetx;
        CameraPosition.y = -0f;
        CameraPosition.z = player.transform.position.z + offsetz;
        transform.position = CameraPosition;
    }
    
}