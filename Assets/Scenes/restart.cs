using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
     
    void Update()
    {
        PlayerPrefs.GetInt("Coins");

    }
     
    public void Restart()
    {
        
        PlayerPrefs.GetInt("Coins");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}