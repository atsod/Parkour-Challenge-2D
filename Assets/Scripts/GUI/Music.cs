using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private GameObject _musicButtonOn;
    [SerializeField] private GameObject _musicButtonOff;
    [SerializeField] private AudioSource _customMusicBG;

    void Start()
    {
        if (PlayerPrefs.GetInt(PlayerPrefsKeys.Music) == 1)  OnClickMusicOn();
        else OnClickMusicOff();
    }

    public void OnClickMusicOn()
    {
        _musicButtonOn.SetActive(false);
        _musicButtonOff.SetActive(true);
        _customMusicBG.Pause();
        PlayerPrefs.SetInt(PlayerPrefsKeys.Music, 1);
    }

    public void OnClickMusicOff()
    {
        _musicButtonOn.SetActive(true);
        _musicButtonOff.SetActive(false);
        _customMusicBG.Play();
        PlayerPrefs.SetInt(PlayerPrefsKeys.Music, 2);
    }
}
