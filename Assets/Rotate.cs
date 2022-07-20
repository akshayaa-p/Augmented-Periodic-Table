using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
    void Start()
    {
        
    }
 public float rotatespeed = 10f;
 private float startingPosition;
   
 void Update()
 {
     if (Input.touchCount > 0)
     {
         Touch touch = Input.GetTouch(0);
         switch (touch.phase)
         {
             case TouchPhase.Began:
                 startingPosition = touch.position.y;
                 break;
             case TouchPhase.Moved:
                 if (startingPosition > touch.position.y)
                 {
                     transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
                 }
                 else if (startingPosition < touch.position.y)
                 {
                     transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
                 }
                 break;
             case TouchPhase.Ended:
                 Debug.Log("Touch Phase Ended.");
                 break;
             }
         }
}
 }

