using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseBackground;
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject starObject;

    public void Pause()
    {
        pausePanel.SetActive(true);
        pauseBackground.SetActive(true);

        buttonPause.SetActive(false);
        starObject.SetActive(false);

        Time.timeScale = 0f;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        pauseBackground.SetActive(false);

        buttonPause.SetActive(true);
        starObject.SetActive(true);

        Time.timeScale = 1f;
    }
}
