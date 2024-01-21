using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar : MonoBehaviour
{
   
    public Slider slider;
    public Gradient grad;
    public Image fill;
    void start()
    {
       fill.color=grad.Evaluate(1f);
    }
    void Update()
    {
        
    }
}