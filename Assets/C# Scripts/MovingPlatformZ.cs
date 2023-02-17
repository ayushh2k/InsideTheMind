using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformZ : MonoBehaviour
{
    public float speed = 20f; // speed of platform movement
    public float distance = 50f; // distance platform travels before reversing
    private Vector3 startPosition; // starting position of platform
    private float direction = 1; // direction platform is moving
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * direction); // move platform in current direction

        // check if platform has reached the end of its movement range
        if (Mathf.Abs(transform.position.z - startPosition.z) >= distance) {
            direction *= -1; // reverse platform direction
        }
        
    }
}
