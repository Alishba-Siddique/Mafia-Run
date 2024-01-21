using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resume : MonoBehaviour
{
    
    public Text life;
    public int score=3;
    public int SetUp()
    {
         gameObject.SetActive(true);
         score--;
         life.text=score.ToString();
         
         return score;
    }
    public void ResumeButton()
    {
        SceneManager.LoadScene("yuyu");
    }
    void Update()
    {
         
         
        

    }
  
    
}
