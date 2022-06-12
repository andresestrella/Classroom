using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceStone : MonoBehaviour
{

    public TMP_Text textThrown;
    public TMP_Text textDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberStonesDestroyed;
    }
}
