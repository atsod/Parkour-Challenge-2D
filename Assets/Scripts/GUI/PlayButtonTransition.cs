using UnityEngine;

public class PlayButtonTransition : MonoBehaviour
{
    [SerializeField] private GameObject _levelsObject;
    [SerializeField] private GameObject _playButton;

    public void OnClickPlayButton()
    {
        _levelsObject.SetActive(true);
        _playButton.SetActive(false);
    }

    public void OnClickExitButton()
    {
        _levelsObject.SetActive(false);
        _playButton.SetActive(true);
    }
}
