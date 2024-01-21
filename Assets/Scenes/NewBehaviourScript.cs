using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    Vector3 V3;
    [SerializeField]
    KeyCode keypos;
    [SerializeField]
    KeyCode keyneg;
    [SerializeField]
    KeyCode space;
    void FixedUpdate()
    {
        if (Input.GetKey(keypos))
        GetComponent<Rigidbody>().velocity+=V3;
         if (Input.GetKey(keyneg))
        GetComponent<Rigidbody>().velocity-=V3;
         if (Input.GetKeyDown(space))
        GetComponent<Rigidbody>().velocity+=V3;


    }
}
