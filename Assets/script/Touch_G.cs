using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Touch_G : MonoBehaviour
{
    Animator animator_t, animator_p;
   // public new Collider2D collider2D_1;
   // public new Collider2D collider2D_2;
    public new Collider2D Player;
    float playerx;
    float col_1x;
   // float col_2x;
    bool check;
   // teacher_move teachermm, teachermm2;
    time t;

    // Use this for initialization
    void Start()
    {
        //animator_t = collider2D_1.GetComponent<Animator>();
        //animator_t2 = collider2D_2.GetComponent<Animator>();
        animator_t = this.GetComponent<Animator>();
        animator_p = Player.GetComponent<Animator>();
       // teachermm = this.gameObject.GetComponent<teacher_move>();
        //teachermm2 = GameObject.Find("teacher2").GetComponent<teacher_move>();
        t = GameObject.Find("Text").GetComponent<time>();
        check = false;
       // GameObject.FindWithTag("teacher");
    }

    // Update is called once per frame
    void Update()
    {
        playerx = Player.transform.position.x;
        // col_1x = collider2D_1.transform.position.x;
        // col_2x = collider2D_2.transform.position.x;
        col_1x = this.gameObject.transform.position.x;
        // animator_p.SetBool("check", false/*collider2D_1.tag == "teacher"*/);
        // Debug.Log("1");
        /*if (Input.touchCount >= 1)
        {
            Vector3 ray;
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(ray.x, ray.y);

                if (this == Physics2D.OverlapPoint(touchPos)|| this == Physics2D.OverlapPoint(touchPos))
                {
                    if ((playerx - 6.0f <= col_1x && playerx >= col_1x) || (playerx - 6.0f <= col_2x && playerx >= col_2x))
                    {
                        if (this.gameObject.tag == "teacher")
                        {
                            animator_p.SetBool("check", false);
                            animator_t.SetBool("check", false);
                        }
                        //else if (collider2D_2.tag == "teacher")
                       // {
                       //     teachermm2.stop();
                       //     animator_p.SetBool("check", false);
                       //     animator_t2.SetBool("check", false);
                      //  }
                        else
                        {
                            t.minute -= 20;
                        }
                    }
                    else
                    {
                        animator_p.SetBool("check", true);
                    }
                }
            }
        }*/
       if ((playerx - 6.0f <= col_1x && playerx >= col_1x)/* || (playerx - 6.0f <= col_2x && playerx >= col_2x)*/)
           {
            if (Input.touchCount >= 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {

                        if (this.gameObject.tag == "teacher")
                        {
                            check = true;
                        //animator_p.SetInteger("check", 2);
                        animator_p.SetBool("check_1", false);
                        animator_t.SetBool("check", false);
                        }
                }
            }
       }
        else if(playerx < col_1x/* || playerx <= col_2x*/)
        {
            if (check == false)
            {
                check = true;
                t.second -= 20;
            }
            // animator_p.SetInteger("check", 1);
            animator_p.SetBool("check_1", true);
        }
    }
}
