using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This script currently spawns 10 spheres in a stack when the game is first played
/// Please rewrite it using a Loop.
/// 
/// Extra credit: Make the number of spheres a variable for the editor.
/// 
/// Extra credit 2: Make it so every time the spacebar is pressed, another N spheres appear on top.
/// </summary>

public class UnwrappedLoop : MonoBehaviour
{

    public GameObject sphere;

    void Start()
    {
        Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 2, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 3, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 4, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 5, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 6, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 7, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 8, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 9, 0), Quaternion.identity);
        Instantiate(sphere, new Vector3(0, 10, 0), Quaternion.identity);
    }


    void Update()
    {
        
    }
}
