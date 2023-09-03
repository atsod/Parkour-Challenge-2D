using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLevelsScript : MonoBehaviour
{
    [SerializeField] private GameObject levelsObject;
    [SerializeField] private GameObject playButton;

    public void OnClickPlayButton()
    {
        levelsObject.SetActive(true);
        playButton.SetActive(false);
    }

    public void OnClickExitButton()
    {
        levelsObject.SetActive(false);
        playButton.SetActive(true);
    }
}
