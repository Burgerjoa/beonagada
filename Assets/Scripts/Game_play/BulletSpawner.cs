using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    List<GameObject> foundEnemys;
    GameObject enemy;
    public GameObject bullet;
    float speed;



    void Start()
    {
        // 코루틴 시작
        StartCoroutine("attack");
    }

    IEnumerator attack()
    {
        while (true)
        {
            // 1초에 한번씩 수행
            attackBullet();
            yield return new WaitForSeconds(1.0f);
        }
    }

    void attackBullet()
    {
       {

            transform.Translate(0.5f * speed * Time.deltaTime, 0, 0);
            // 소환 포지션 정하기
            Vector3 spawnPos = gameObject.transform.position;
            spawnPos.z = -4;
            // 생성하기
            GameObject attBullet = Instantiate(bullet, spawnPos, Quaternion.identity);

            attBullet.GetComponent<Rigidbody2D>();
       }
    }

}
