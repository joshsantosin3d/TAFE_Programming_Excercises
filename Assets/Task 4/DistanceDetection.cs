using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// In this class, the sphere is currently moving to thr right.
/// Make it register some change once it is within a certain distance to the other sphere.
/// Options include: Changing colour, moving upwards, changing size, ect
/// Make whatever the change was, it is undone or stops happening when the sphere is far enough away.
/// </summary>


public class DistanceDetection : MonoBehaviour
{

    public Transform otherSphere;
    public float range = 2;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
