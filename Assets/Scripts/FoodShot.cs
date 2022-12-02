using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShot : MonoBehaviour
{
    public float speed = 40.0f;

    private float topBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        //destroy out of boundary
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
