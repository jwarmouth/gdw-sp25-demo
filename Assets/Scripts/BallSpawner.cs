using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    //public GameObject ball;
    public GameObject[] balls;
    public GameObject spawnPoint;
    // this is a reference to the "ball" prefab

    // Update is called once per frame
    void Update()
    {
        Instantiate(balls[Random.Range(0,balls.Length)], 
            spawnPoint.transform.position,
            spawnPoint.transform.rotation);
        // spawn an instance of "ball" at default position

    }
}
