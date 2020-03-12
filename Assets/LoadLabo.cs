
 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class LoadLabo : MonoBehaviour
{
    public float delay = 20;
    public string NewLevel = "laboScene";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        print("delay: "+delay);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}