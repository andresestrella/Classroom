using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAwake : MonoBehaviour
{
    
    void Start()
    {
        GameManager.currentNumberStonesDestroyed = 0;
        GameManager.currentNumberStonesThrown = 0;
    }

    
    void Update()
    {
        
    }

    public void Click(){
        Application.LoadLevel("Juego");
    }
}
