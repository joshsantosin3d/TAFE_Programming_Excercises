using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In this code, the programmer has made input checks for both arrow keys and the WS keys.
/// Please modify the code to use Unity's Input Axis system instead.
/// 
/// Extra credit: Make a new function that takes in a parameter to move the cube, and call that function in Update() based on the inputs made.
/// 
/// Exta credit 2: Allow for Left/right inputs too.
/// </summary>

public class RiseOnKeyPress : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        //What this does is gets the WS or Up/Down arrows and outputs a number from -1 to +1
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * 0.01f);
        //Get the transform component
        //"Translate" the transform, which is to say "move it"
        //In the direction of "upwards"
        //Multiplied by the vertical input axis (up/down arrows or W/S keys)
        //Multiplied by 0.01
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.01f);

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(Vector3.up * 0.01f);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.up * 0.01f);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(Vector3.down * 0.01f);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.down * 0.01f);
        //}
    }
}
