using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    MeshRenderer _renderer;
    Vector2 currentPos = Vector2.zero;
    const float scrollingSpeedX = 0.15f;
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        currentPos.x += scrollingSpeedX * Time.deltaTime; //hacer que no dependa del tiempo, si no de la posicion del jugador.
        _renderer.material.mainTextureOffset = currentPos;
    }
}
