using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Yandex : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    private bool wasMusicOn;

    [DllImport("__Internal")]
    private static extern void ShowFullscreenAdv();

    private void Start()
    {
        ShowFullscreenAdv();
    }

    public void OnOpenAdv()
    {
        if (PlayerPrefs.GetInt("music") == 2) wasMusicOn = true;
        musicSource.Pause();
        Time.timeScale = 0f;
    }

    public void OnCloseAdv()
    {
        if (wasMusicOn)
            musicSource.UnPause();
        wasMusicOn = false;
        Time.timeScale = 1f;
    }
}
