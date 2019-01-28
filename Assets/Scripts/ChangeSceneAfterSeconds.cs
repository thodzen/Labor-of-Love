using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAfterSeconds : MonoBehaviour
{
    public float delay = 440;
    public string sceneName;
    public Animator transitionAnim;
    void Start()
    {
        //StartCoroutine(LoadScene());
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

   /* IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end long");
        yield return new WaitForSeconds(2.5f);
    } */

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        transitionAnim.SetTrigger("end long");
        yield return new WaitForSeconds(2.5f);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}