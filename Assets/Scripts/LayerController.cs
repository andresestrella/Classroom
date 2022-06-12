using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    //en este ejemplo se produce movimiento en funcion al tiempo, pero se puede hacer en fncion a la posicion de un personaje o mouse..
    float scrollingSpeed = 0.1f, currentTempSpeed;
    MeshRenderer _renderer;
    Vector2 currentPosition = new Vector2();
    private void Awake(){
        _renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        currentTempSpeed = scrollingSpeed * (20 / gameObject.transform.position.z);
        currentPosition.x = currentPosition.x + scrollingSpeed * Time.deltaTime;
        _renderer.material.mainTextureOffset = currentPosition;
    }
}
