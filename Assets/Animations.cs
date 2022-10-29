using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("startRun", true);
        }
        else
        {
            anim.SetBool("startRun", false);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isJump", true);
        }
        else
        {
            anim.SetBool("isJump", false);
        }
    }
}
