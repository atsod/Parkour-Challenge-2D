using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _pauseBackground;
    [SerializeField] private GameObject _buttonPause;
    [SerializeField] private GameObject _starObject;

    public void Pause()
    {
        _pausePanel.SetActive(true);
        _pauseBackground.SetActive(true);

        _buttonPause.SetActive(false);
        _starObject.SetActive(false);

        Time.timeScale = 0f;
    }

    public void Continue()
    {
        _pausePanel.SetActive(false);
        _pauseBackground.SetActive(false);

        _buttonPause.SetActive(true);
        _starObject.SetActive(true);

        Time.timeScale = 1f;
    }
}
