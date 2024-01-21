using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public float forwardSpeed;
    private CharacterController controller;
    private float dist;
    public bool dragging = false;
    private Transform toDrag;
    public CodeCap code;
    public pause pause;
    public GameObject mafia;
    public GameObject swipe;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(code.ismove)
        {
            if(code.slider.activeSelf == false && mafia.activeSelf==false && swipe.activeSelf==false)
            {
                Vector3 moveDirection = transform.TransformDirection(Vector3.forward) * forwardSpeed;
                controller.Move(moveDirection * Time.smoothDeltaTime);
            }
            
            Vector3 v3;

            if (Input.touchCount != 1)
            {
                dragging = false;
                return;
            }
            

            Touch touch = Input.GetTouch(0);
            Vector3 pos = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(pos);
                if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Draggable"))
                {
                    code.slider.SetActive(false);
                    mafia.SetActive(false);
                    swipe.SetActive(false);
                    Debug.Log("Here");
                    toDrag = hit.transform;
                    dist = hit.transform.position.z - Camera.main.transform.position.z;
                    v3 = new Vector3(pos.x, pos.y, dist);
                    v3 = Camera.main.ScreenToWorldPoint(v3);
                    //offset = toDrag.position - v3;
                    dragging = true;
                }
            }
            Debug.Log("Paused" + pause.ispaused);
            if (dragging && touch.phase == TouchPhase.Moved && pause.ispaused == false)
            {
                v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
                v3 = Camera.main.ScreenToWorldPoint(v3);
                Vector3 os = v3;
                os.x = Mathf.Clamp(os.x, -8, 8);
                os.y = Mathf.Clamp(os.y, -2.56f, -2.56f);
                toDrag.position = new Vector3(os.x, -2.37f, controller.transform.position.z);
            }
            if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
            {
                dragging = false;
            }
        }
       
    }
}