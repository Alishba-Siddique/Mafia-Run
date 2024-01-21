using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playAgain : MonoBehaviour
{
     
    void Update()
    {
        PlayerPrefs.GetInt("Coins");

    }
     
    public void Restart()
    {
        
        PlayerPrefs.GetInt("Coins");
        SceneManager.LoadScene("yuyu 1");
    }
}