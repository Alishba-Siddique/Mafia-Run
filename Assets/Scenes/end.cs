using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject UI1;
   
    public void End1()
    {
        UI1.SetActive(true);
          
    }
    public void OnTriggerEnter()
    {
       End1();
    }
    void Update()
    {
         
         
        

    }
  
    
}
