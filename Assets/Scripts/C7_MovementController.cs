using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7_MovementController : MonoBehaviour
{
    const float MAX_Y = 8f;
    Vector3 currentPosition = new Vector3();
    const float SPEED_Y = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        currentPosition.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, MAX_Y);
        gameObject.transform.position = currentPosition;
    }
}
