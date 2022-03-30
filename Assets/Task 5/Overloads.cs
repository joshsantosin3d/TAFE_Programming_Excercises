using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Currently this script makes the player jump when the spacebar is pressed.
/// However, we may want a different kind of jump when the crouch button is held (control).
///     - Crouch jump
///     
/// Please create an overload function with a boolean paramater, and uncomment the line in Update();
/// 
/// Extra credit: Make ANOTHER overload function for if the SHIFT key is held, and give it some torque
///     - Sprint jump
/// </summary>

public class Overloads : MonoBehaviour
{
    public float jumpForce = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))            //On this frame, we pressed space
        {
            if (Input.GetKey(KeyCode.LeftControl))      //On this frame, we are HOLDING control
            {
                //Jump(true);
            }
            else
            {
                Jump();
            }
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
    }

}
