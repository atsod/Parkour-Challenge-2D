using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControllerScript : MonoBehaviour
{
    public static LevelControllerScript instance = null;
    private int levelComplete;
    private int levelIndex;

    void Start()
    {
        if (!instance) instance = this;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void ManageCompletedLevel()
    {
        if(levelComplete < levelIndex)
        {
            PlayerPrefs.SetInt("LevelComplete", levelIndex);
        }
    }

    public void ManageStarNumber(string starNumber)
    {
        string[] splitedInput = starNumber.Split('/');
        float totalStarAmount = int.Parse(splitedInput[1]);
        float currentStarAmount = int.Parse(splitedInput[0]);

        int starPercent = (int)Mathf.Round((float)(100 * currentStarAmount) / totalStarAmount);

        if(PlayerPrefs.GetInt("Level" + levelIndex) < starPercent)
            PlayerPrefs.SetInt("Level" + levelIndex, starPercent);
    }
}
