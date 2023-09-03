using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField] private GameObject MusicButtonOn;
    [SerializeField] private GameObject MusicButtonOff;
    [SerializeField] private AudioSource customMusicBG;

    void Start()
    {
        if (PlayerPrefs.GetInt("music") == 1)  OnClickMusicOn();
        else OnClickMusicOff();
    }

    public void OnClickMusicOn()
    {
        MusicButtonOn.SetActive(false);
        MusicButtonOff.SetActive(true);
        customMusicBG.Pause();
        PlayerPrefs.SetInt("music", 1);
    }

    public void OnClickMusicOff()
    {
        MusicButtonOn.SetActive(true);
        MusicButtonOff.SetActive(false);
        customMusicBG.Play();
        PlayerPrefs.SetInt("music", 2);
    }
}
