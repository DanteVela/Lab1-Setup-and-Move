using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    private const float SPEED = 4.0f;

    Vector2 _target = Vector2.zero;

    bool _hasTarget = false;
    
    void Update()
    {
        // 0 = Left Mouse | 1 = Right Mouse
        if(Input.GetMouseButtonDown(0)) {
            // Vector2 mouse = Input.mousePosition;
            // Vector2 world = Camera.main.ScreenToWorldPoint(mouse);
            // Debug.Log(_target);
            _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _hasTarget = true;
        }

        if(_hasTarget) {
            Vector2 path = _target - (Vector2)transform.position;
            float dist = path.magnitude;
            Vector2 dir = path.normalized;
            float step = SPEED * Time.deltaTime;

            if(step > dist) {
                transform.position = _target;
                _hasTarget = false;
            } else {
                transform.position = (Vector2)transform.position + (dir * step);
            }
        }
    }
}
