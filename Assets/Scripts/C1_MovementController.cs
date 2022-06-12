using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_MovementController : MonoBehaviour
{
    float _speedY = 20f;
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIMIT_Y = -4.25f, MAX_LIMIT_Y = 4.25f;

    void Update() //~60 veces/s
    {
        _deltaPos.y = Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 
        Mathf.Clamp(gameObject.transform.position.y, MIN_LIMIT_Y, MAX_LIMIT_Y), 
        gameObject.transform.position.z);
    }
    void FixedUpdate(){}
}
