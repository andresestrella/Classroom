using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4_MovementController : MonoBehaviour
{
    const float MIN_LIMIT_Y = -4.30f, MAX_LIMIT_Y = 4.30f;
    const float MIN_LIMIT_X = -8.18f, MAX_LIMIT_X = 8.18f;
    public FloatingJoystick Joystick; 
    Vector3 deltaPos = new Vector3();
    Vector3 moveSpeed = new Vector3(10,10);
    void Update()
    {
        deltaPos.x = Joystick.Horizontal * moveSpeed.x;
        deltaPos.y = Joystick.Vertical * moveSpeed.y;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIMIT_X, MAX_LIMIT_X), 
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIMIT_Y, MAX_LIMIT_Y), 
            gameObject.transform.position.z
        );
    }
}
