using System.Collections;
using UnityEngine;

namespace Assets
{
    public class PlayerMovement : MonoBehaviour
    {
  
        public int forwardSpeed;
        public float horizVel = 0;
        public float horizSpeed = 10;
        public int laneNum = 2;
        public bool controlBlocked;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, forwardSpeed);

            if ((MobileInput.Instance.SwipeLeft) && (laneNum > 1) && (controlBlocked == false))
            {
                horizVel = -horizSpeed;
                StartCoroutine(stopSlide());
                laneNum -= 1;
                controlBlocked = true;
            }

            if ((MobileInput.Instance.SwipeRight) && (laneNum < 3) && (controlBlocked == false))
            {
                horizVel = horizSpeed;
                StartCoroutine(stopSlide());
                laneNum += 1;
                controlBlocked = true;
            }
            Debug.Log(horizVel);
            Debug.Log(controlBlocked);
        }

        IEnumerator stopSlide()
        {
            yield return new WaitForSeconds(.5f);
            horizVel = 0;
            controlBlocked = false;
        }

    }
}