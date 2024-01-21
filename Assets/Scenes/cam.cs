

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cam : MonoBehaviour
{
public Vector3 myPos;
public Transform play;
public Transform sec;
float playerZ;
float playerX;
public CodeCap code;
 
void Update()
{
     playerZ = play.position.z;
     playerX = play.position.x;
     
     transform.position = new Vector3(playerX,0f,playerZ)+myPos;
    // transform.position = follow;
  
   
}
}