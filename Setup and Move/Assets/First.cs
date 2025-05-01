// CSCI 3370-90L
// Dante Vela

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starty!");
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Updating!");
        // Vector3 velocity = new Vector2(0.1f, 0);
        // transform.position = transform.position + velocity;

        Vector3 velocity = new Vector2(5.0f, 0);
        // transform.position = transform.position + (velocity * Time.deltaTime);

        // Keyboard Movement
        velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D)) {
            velocity = new Vector2(5f, 0);
            transform.position = transform.position + (velocity * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.S)) {
            velocity = new Vector2(0, -5f);
            transform.position = transform.position + (velocity * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.A)) {
            velocity = new Vector2(-5f, 0);
            transform.position = transform.position + (velocity * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.W)) {
            velocity = new Vector2(0, 5f);
            transform.position = transform.position + (velocity * Time.deltaTime);
        }
    }
}
