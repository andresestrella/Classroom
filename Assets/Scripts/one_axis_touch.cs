using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_axis_touch : MonoBehaviour
{
    float _speedY = 2;
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIMIT_Y = -4.25f, MAX_LIMIT_Y = 4.25f;

    void Update()
    {
        _deltaPos.y = Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position.y : 0;
        _deltaPos.y *= _speedY;
        _deltaPos *= Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIMIT_Y, MAX_LIMIT_Y),
            gameObject.transform.position.z
        );
    }
}
