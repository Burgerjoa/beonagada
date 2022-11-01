using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
   public GameObject[] charPrefabs;
   public GameObject player;

   void Start()
   {
        player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
        int index = player.name.IndexOf("(Clone)");
        if (index > 0)
            player.name = player.name.Substring(0, index);
        player.transform.position = transform.position;
    }
}
