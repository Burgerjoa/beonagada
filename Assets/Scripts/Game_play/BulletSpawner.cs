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
        // �ڷ�ƾ ����
        StartCoroutine("attack");
    }

    IEnumerator attack()
    {
        while (true)
        {
            // 1�ʿ� �ѹ��� ����
            attackBullet();
            yield return new WaitForSeconds(1.0f);
        }
    }

    void attackBullet()
    {
       {

            transform.Translate(0.5f * speed * Time.deltaTime, 0, 0);
            // ��ȯ ������ ���ϱ�
            Vector3 spawnPos = gameObject.transform.position;
            spawnPos.z = -4;
            // �����ϱ�
            GameObject attBullet = Instantiate(bullet, spawnPos, Quaternion.identity);

            attBullet.GetComponent<Rigidbody2D>();
       }
    }

}
