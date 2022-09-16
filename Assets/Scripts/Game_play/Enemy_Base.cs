/*using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Base : MonoBehaviour
{
    public float Speed;

    public static bool Delay = false;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 5f;
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Play") // 셀렉트 씬에서만 작동
        {
            move();
        }

        Damaged();
        StartCoroutine("Attack_Delay");
    }[NotNull]

    public void move()
    {
        transform.Translate(-0.002f*Speed,0,0);
    }

    public static void Damaged()
    {
        void OnTriggerEnter2D(Collider2D col) //피격 판정
        {
            if (col.CompareTag("Player") && Delay == true)
            {
                Delay = false;
                UI.damaged_by_player = true;
            }
        }
    }
<<<<<<< HEAD
    public static IEnumerator Attack_Delay()
    {
        yield return new WaitForSeconds(0.5f);
        Delay = true;
    }
}
=======
    
}
*/
>>>>>>> 68c9ba19e0caed10b0d173f8b1f0d019832ca124
