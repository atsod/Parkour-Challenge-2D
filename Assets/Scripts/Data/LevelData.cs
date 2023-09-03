using UnityEngine;
using UnityEngine.UI;

public class LevelData : MonoBehaviour
{
    [SerializeField] private Button[] _levelButtons;

    private int _levelComplete;

    void Start()
    {
        _levelComplete = PlayerPrefs.GetInt(PlayerPrefsKeys.LevelComplete);
        foreach (Button levelButton in _levelButtons)
        {
            levelButton.interactable = false;
            levelButton.transform.GetChild(1).gameObject.SetActive(false);
        }

        for(int i = 0; i < _levelComplete; i++)
        {
            if (i == _levelButtons.Length) return;
            _levelButtons[i].interactable = true;
            _levelButtons[i].transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
