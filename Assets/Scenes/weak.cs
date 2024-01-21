using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weak : MonoBehaviour
{
    public CodeCap code;
    public Animator animator;
    void Update()
    {
       
        if(code.score>=40 && code.score<80)
           {
               animator.SetBool("create",true);
           }
        if(code.score>=80 && code.score<120)
            animator.SetBool("create",true);
        if(code.score>=120 && code.score<160)
            animator.SetBool("create",true);
        if(code.score>=160 && code.score<200)
            animator.SetBool("create",true);
        
        
    }
    public void res()
    {
            animator.SetBool("create",false);
        
    }
}