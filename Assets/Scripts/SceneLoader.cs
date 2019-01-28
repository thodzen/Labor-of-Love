using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transitionAnim;

    public GameObject theManager;
    public void LoadScene(string name)
        
    {
        SceneManager.LoadScene(name, LoadSceneMode.Single);
        StartCoroutine(LoadCurrentScene());
    }

    /*public void LoadCurrentScene()
    {
        Debug.Log("PRESSED BUTTON");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    } */

    IEnumerator LoadCurrentScene()
    {
        //Debug.Log("PRESSED BUTTON");
        transitionAnim.SetTrigger("end long");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void myMethod()
    {
        DontDestroyOnLoad(theManager);
    }
}
