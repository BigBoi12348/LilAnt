using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneSwitch : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(NextLevelAfterWait());
    }
    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(18f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
