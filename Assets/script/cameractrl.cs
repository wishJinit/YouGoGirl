using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameractrl : MonoBehaviour
{
    public GameObject player;  //A라는 GameObject변수 선언
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void LateUpdate()
    {

        float xp = player.transform.position.x;
        xp = Mathf.Clamp(player.transform.position.x, -104.1f, 0);
        transform.position = new Vector3(xp, player.transform.position.y+1.5f, transform.position.z);


        //xp = Mathf.Clamp(xp, -87.49f, 0);
        // transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, -87.49f, 0), player.transform.position.y+2.3f, transform.position.z);
    }
}
