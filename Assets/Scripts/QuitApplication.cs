using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Application has ended.");
    }

}

