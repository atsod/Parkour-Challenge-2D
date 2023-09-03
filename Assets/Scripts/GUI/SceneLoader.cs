using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int sceneIndex;


    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void SceneLoad(int index)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }

    public void SceneReload()
    {
        SceneLoad(sceneIndex);
    }

    public void LoadNextScene()
    {
        SceneLoad(sceneIndex + 1);
    }
}
