using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C9_MovementController : MonoBehaviour
{
    public GameObject Ammo;
    public GameObject Shield;
    const float shieldDistance = 2f;
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();
    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, 20);
    }

    void Update()
    {
        //esto podira ser con la posicion del mouse.

        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY =  userInput.y - gameObject.transform.position.y;
        deltaX =  userInput.x - gameObject.transform.position.x;

        //Input.GetTouch(0).position.y me da una posicion en pixeles en la pantalla, tengo que convertir esto a unidades 'Unity'
        currentAngle = Mathf.Atan( deltaY / deltaX);
        Debug.Log(currentAngle * Mathf.Rad2Deg);
        
        
        //trigger; disparar un objeto (balas, flechas.)
        if(Input.GetButtonDown("Fire1")){
            Instantiate(Ammo, gameObject.transform.position, Quaternion.identity).GetComponent<AmmoBehaviour>().Shoot(startingSpeed, currentAngle);
        }

        if(Input.GetButtonDown("Fire2")){
            Instantiate(Shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldBehaviour>().Shoot(gameObject, shieldDistance);
        }
    }
}
