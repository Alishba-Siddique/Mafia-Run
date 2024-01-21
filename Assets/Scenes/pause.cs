using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour

{
public Button btn;
public bool ispaused=false;
public Sprite play;
public Sprite pause1;
public slidecontrol slide;
public CodeCap code;
    
     
public void Pause()

{
     if(ispaused)
     {
         Time.timeScale=1;
         ispaused=false;
         code.ismove=true;
         btn.GetComponent<Image>().sprite=pause1;
         slide.slide=false;

     }
     else
     {
         Time.timeScale=0;
         ispaused=true;
         code.ismove=false;
         btn.GetComponent<Image>().sprite=play;
         slide.slide=true;
         
 

     }
}

}