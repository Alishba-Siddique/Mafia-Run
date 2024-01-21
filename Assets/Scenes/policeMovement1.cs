using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeMovement1 : MonoBehaviour
{
    public float min = 7.0F;
    public float max = 2.0F;
    static float t = 0.0f;
    public float Zx =0F;
    public  Vector3 currentAngle;
 
    public void Start()
    {
        currentAngle = transform.eulerAngles;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(min, max, t), -2.6f, Zx);

        t += 0.2f * Time.deltaTime;

        if (t > 1.0f)
        {
            currentAngle = new Vector3(currentAngle.x, 90, currentAngle.z);
            transform.eulerAngles = currentAngle;

            float temp = max;
            max = min;
            min = temp;
            t = 0.0f;
        }
        else if (max == 2.0)
        {
            currentAngle = new Vector3(currentAngle.x, 270, currentAngle.z);

            transform.eulerAngles = currentAngle;
        }
    }
}