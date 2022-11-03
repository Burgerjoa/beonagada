using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMgr : MonoBehaviour
{
    public float spawnTime = 3f;
    public float curTime;
    public Transform[] spawnPoints;
    public GameObject enemy;
    public void Update()
    {
        if(curTime >= spawnTime)
        {
            int x = Random.Range(0, spawnPoints.Length);
            SpawnEnemy(x);
        }
        curTime += Time.deltaTime;
       
    }
    public void SpawnEnemy(int ranNum)
    {
        curTime = 0f;
        Instantiate(enemy, spawnPoints[ranNum]);
    }
}
