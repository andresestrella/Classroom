using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod3_MovementController : MonoBehaviour{
    public float forceValue;
    public float jumpValue;
    private Rigidbody _rigidbody;
    private AudioSource _audio;
    void Start(){
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.01f){
            _rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            gameObject.GetComponent<AudioSource>().Play();
        }
        _rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forceValue);

    }
}
