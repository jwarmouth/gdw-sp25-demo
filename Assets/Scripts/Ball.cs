using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bottomY;
    public float destroyDelay;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // using position to destroy game object
        //if (transform.position.y < bottomY)
        //{
        //    Destroy(gameObject);
        //}
    }
}
