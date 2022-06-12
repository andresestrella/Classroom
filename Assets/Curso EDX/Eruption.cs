using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    public GameObject stone;
    public float fireRate = 0.5f;
    
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    void Update()
    {
            
    }
    IEnumerator ThrowStone(){
        while(true){
            Instantiate(stone, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate); 
        }
    }
}
