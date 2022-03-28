using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script spawns a bomb whenever the player clicks on screen.
/// Currently, the bomb does nothing, is too big, is the wrong colour, and doesn't quite look like a bomb.
/// 1: Make the bomb use physics and drop once it's spawned.
/// 2: Shrink the bomb to a more reasonable size.
/// 3: Change the colour of the bomb.
/// 4: Add more shapes to the bomb so it looks more like one.
/// </summary>


public class ClickAndSpawn : MonoBehaviour
{
    public GameObject bomb;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePoint = Input.mousePosition;
            Vector3 spawnPoint = Camera.main.ScreenToWorldPoint(mousePoint);
            spawnPoint.z = -5;
            Instantiate(bomb, spawnPoint, Quaternion.identity);
        }
    }
}
