
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidecontrol : MonoBehaviour
{
    private Touch touch;
    public float speed = 0.01f;
    public bool slide = false;
    public CodeCap code;
   // public GameObject swipe;

   public pause pause;
    void start()
    {
        speed = 0.01f;
    }
    void Update()
    {
       //if (slide  && !pause.ispaused)
       if(code.ismove)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + 1 * .6f);
        }


       if(code.ismove)
        
        if (Input.touchCount > 0)
        {
            //swipe.SetActive(false);
            slide = true;

            //float xPos = Mathf.Clamp(touch.deltaPosition.x, xMin, xMax);
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                if (transform.position.x >= -4.5f && transform.position.x <= 4.5f)
                    transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speed,
                    transform.position.y,
                    transform.position.z);
                else if (transform.position.x < -4.5f)
                    transform.position = new Vector3(
                    -4.5f,
                    transform.position.y,
                    transform.position.z);
                else if (transform.position.x > 4.5f)
                    transform.position = new Vector3(
                    4.5f,
                    transform.position.y,
                    transform.position.z);





            }
        }
    }
}