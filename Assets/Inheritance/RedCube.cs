using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Inheritance
{

    protected override void MoveUp()
    {
        transform.Translate(Vector3.up);
        transform.Rotate(transform.up, 50);
    }
}
