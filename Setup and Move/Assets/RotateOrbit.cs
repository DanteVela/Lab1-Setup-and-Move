// CSCI 3370-90L
// Dante Vela

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOrbit : MonoBehaviour
{
    public Transform center;

    public Vector3 axis = Vector3.up;

    public float radius = 3.5f;

    public float radiusSpeed = 1.0f;
    
    public float rotationSpeed = 80.0f; 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform.position - center.position).normalized * radius + center.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround (center.position, axis, rotationSpeed * Time.deltaTime);
        var desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
    }
}
