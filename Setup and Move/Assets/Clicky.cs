// CSCI 3370-90L
// Dante Vela

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicky : MonoBehaviour
{
    public float SPEED = 1.5f;
    
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetMouseButtonDown(0));
        Debug.Log(Input.mousePosition);
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));

        // Moves to mouse-click position at constant speed until reaches destination
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
         }
         transform.position = Vector3.MoveTowards(transform.position, target, SPEED * Time.deltaTime);
    }
}