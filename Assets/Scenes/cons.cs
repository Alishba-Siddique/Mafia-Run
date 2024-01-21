using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class cons: MonoBehaviour
{

 void Update()
{

}
public void restart()
{
    
    PlayerPrefs.GetInt("Coins");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1) ;
}

}