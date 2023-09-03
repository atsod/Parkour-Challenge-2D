using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int _sceneIndex;


    private void Start()
    {
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void SceneLoad(int index)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }

    public void SceneReload()
    {
        SceneLoad(_sceneIndex);
    }

    public void LoadNextScene()
    {
        SceneLoad(_sceneIndex + 1);
    }
}
