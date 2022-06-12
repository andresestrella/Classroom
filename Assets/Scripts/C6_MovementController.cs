using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C6_MovementController : MonoBehaviour
{
    float STARTINGFORCE = 500f;
    bool hasStarted = false;
    Rigidbody rigidBody;
    Vector3 startingForce = new Vector3(1,1);
    private void Awake(){
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(! hasStarted && Input.GetButtonDown("Fire1")){
            hasStarted = true;
            startingForce *= STARTINGFORCE;
            rigidBody.AddForce(startingForce);
        }
    }
}
