using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetTrigger("Kick1");
        }
         if (Input.GetKeyDown(KeyCode.B))
        {
            anim.SetTrigger("Kick2");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetTrigger("Idle");
        }
         if (Input.GetKeyDown(KeyCode.N))
        {
            anim.SetTrigger("Kick3");
        }
    }
}