using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InterfaceFinal : MonoBehaviour
{
    public TMP_Text textThrown;
    public TMP_Text textDestroyed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberStonesDestroyed;
    }

    public void Click(){
        SceneManager.LoadScene("Awake");
    }
}
