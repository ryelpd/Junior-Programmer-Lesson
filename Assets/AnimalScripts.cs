using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScripts : MonoBehaviour
{
    public float speed = 10.0f;
    public float topBound = 30;
    public float lowerBound = -10;

    private void Update()
    {
        //animal movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        //amimal boundary
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
