using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    
    public Text score1;
    public void SetUp(int score)
    {
          
         score1.text=score.ToString();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    void Update()
    {
         
         
        

    }
  
    
}
