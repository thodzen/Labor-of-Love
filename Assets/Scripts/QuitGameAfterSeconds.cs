using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameAfterSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Quit", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
