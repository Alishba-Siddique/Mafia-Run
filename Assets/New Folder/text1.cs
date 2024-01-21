using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text1 : MonoBehaviour
{
   
    
    public CodeCap codecap;
    Animator animator;
    
   
    void start()
    {
        
         animator=gameObject.GetComponent<Animator>();
         
    }
 
    void Update()
    {
         
              
          
    }
    public void play()
    {
             
            // animator.Play("1");
    
    }

    public void iplay()
 
    {
             // animator.SetTrigger("");
              
    }
    
}
