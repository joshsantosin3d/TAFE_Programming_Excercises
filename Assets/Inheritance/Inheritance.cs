using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveUp();
        }
    }

    protected virtual void MoveUp()
    {
        transform.Translate(Vector3.up);
    }
}
