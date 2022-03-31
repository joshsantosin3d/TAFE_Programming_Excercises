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
    public int initialspheres;
    public int newspheres;

    void Start()
    {
        for (int newspheres = 0; newspheres < initialspheres; newspheres++)
        {
        Instantiate(sphere, new Vector3(0, newspheres, 0), Quaternion.identity);

        }
        //Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 1, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 2, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 3, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 4, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 5, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 6, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 7, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 8, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 9, 0), Quaternion.identity);
        //Instantiate(sphere, new Vector3(0, 10, 0), Quaternion.identity);
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(sphere, new Vector3(0, newspheres, 0), Quaternion.identity);
            newspheres++;
        }
    }
}
