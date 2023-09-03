using System.Runtime.InteropServices;
using UnityEngine;

public class Yandex : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;

    private bool _wasMusicOn;

    [DllImport("__Internal")]
    private static extern void ShowFullscreenAdv();

    private void Start()
    {
        ShowFullscreenAdv();
    }

    public void OnOpenAdv()
    {
        if (PlayerPrefs.GetInt(PlayerPrefsKeys.Music) == 2)
        {
            _wasMusicOn = true;
        }
        _musicSource.Pause();
        Time.timeScale = 0f;
    }

    public void OnCloseAdv()
    {
        if (_wasMusicOn)
            _musicSource.UnPause();
        _wasMusicOn = false;
        Time.timeScale = 1f;
    }
}
