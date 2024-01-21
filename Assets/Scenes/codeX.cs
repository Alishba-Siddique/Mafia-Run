using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class codeX : MonoBehaviour
{
    public CodeCap code;
    void Update()
    {
        if(code.score<=0)
        {
            PlayerPrefs.SetInt("Axe",CodeCap.scorex);
            Debug.Log(CodeCap.scorex);
        }
    }
}
