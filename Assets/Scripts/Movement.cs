using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;

    // Update is called once per frame
    void Update()
    {
        bool isWalkingHorizontal = Input.GetButton("Horizontal");
        bool isWalkingVertical = Input.GetButton("Vertical");
        bool isRunning = Input.GetKey("left shift");


       

        if (isWalkingHorizontal || isWalkingVertical)
        {
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime;
            

            transform.Rotate(0, horizontalMove, 0);
            if (isRunning)
            {


                verticalMove = verticalMove * 20;
            }

        

            transform.Translate(0, 0, verticalMove);
            transform.localEulerAngles = new Vector3(0, transform.localRotation.eulerAngles.y, 0);


        }
      
    }
}
