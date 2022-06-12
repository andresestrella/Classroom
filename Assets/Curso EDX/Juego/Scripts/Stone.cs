using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    private const float yDie = -30.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie){
            Destroy(gameObject);
        }
    }

    void OnMouseDown(){
        Destroy(gameObject);
        GameManager.currentNumberStonesDestroyed++;
    }
}
