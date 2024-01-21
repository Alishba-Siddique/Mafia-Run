using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class restart1 : MonoBehaviour
{
     
    void Update()
    {
        PlayerPrefs.GetInt("Axe");

    }
     
    public void Restart()
    {
        
        PlayerPrefs.GetInt("Axe");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}