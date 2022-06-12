using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3_PlayerController : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed = 15f, maxWalkingSpeed = 6f, currentSpeed;
    Vector3 deltaPos = new Vector3();
    void Awake()
    {
        currentAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", true);
        }else if (Input.GetButtonUp("Fire1")){
            currentAnimator.SetBool("isAttacking", false);
        }
        if (Input.GetButtonDown("Jump")) {
            currentAnimator.SetBool("isJumping",true);
        }else if (Input.GetButtonUp("Jump")){
            currentAnimator.SetBool("isJumping",false);
        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxWalkingSpeed  : maxRunningSpeed);
        deltaPos.x = currentSpeed * Time.deltaTime;
        currentAnimator.SetFloat("Speed", currentSpeed);

        gameObject.transform.Translate(deltaPos);
    }
}
