using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    public RectTransform img;
    public float minValue = -15;
    public float maxValue = 15;
    public pause pause;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!pause.ispaused)
        {
        float value = Mathf.Lerp(minValue, maxValue, Mathf.PingPong(Time.time, 1));
        Debug.Log(value);
        Vector2 shake = img.anchoredPosition;
        img.anchoredPosition = shake + new Vector2(value, 0);
        }
    }

}
