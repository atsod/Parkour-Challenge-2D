using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelData : MonoBehaviour
{
    [SerializeField] private Button[] levelButtons;
    private int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        foreach (Button levelButton in levelButtons)
        {
            levelButton.interactable = false;
            levelButton.transform.GetChild(1).gameObject.SetActive(false);
        }

        for(int i = 0; i < levelComplete; i++)
        {
            if (i == levelButtons.Length) return;
            levelButtons[i].interactable = true;
            levelButtons[i].transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
