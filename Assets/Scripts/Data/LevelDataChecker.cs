using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDataChecker : MonoBehaviour
{
    public static LevelDataChecker Instance = null;
    private int _levelComplete;
    private int _levelIndex;

    void Start()
    {
        if (!Instance) Instance = this;
        _levelComplete = PlayerPrefs.GetInt(PlayerPrefsKeys.LevelComplete);
        _levelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void CheckAndSetIndexOfLastCompletedLevel()
    {
        if(_levelComplete < _levelIndex)
        {
            PlayerPrefs.SetInt(PlayerPrefsKeys.LevelComplete, _levelIndex);
        }
    }

    public void CheckAndSetLevelStarPercentage(string starNumber)
    {
        string[] splitedInput = starNumber.Split('/');
        float totalStarAmount = int.Parse(splitedInput[1]);
        float currentStarAmount = int.Parse(splitedInput[0]);

        int starPercent = (int)Mathf.Round((float)(100 * currentStarAmount) / totalStarAmount);

        if(PlayerPrefs.GetInt("Level" + _levelIndex) < starPercent)
            PlayerPrefs.SetInt("Level" + _levelIndex, starPercent);
    }
}
