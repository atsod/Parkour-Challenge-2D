using TMPro;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _finishBlock;
    [SerializeField] private GameObject _buttonPause;
    [SerializeField] private GameObject _starObject;

    [SerializeField] private TextMeshProUGUI _starNumberText;
    [SerializeField] private TextMeshProUGUI _starFinishNumberText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Finish();
        LevelDataChecker.Instance.CheckAndSetLevelStarPercentage(_starFinishNumberText.text);
        LevelDataChecker.Instance.CheckAndSetIndexOfLastCompletedLevel();
    }

    private void Finish()
    {
        _finishBlock.SetActive(true);
        _buttonPause.SetActive(false);
        _starObject.SetActive(false);

        _starFinishNumberText.text = _starNumberText.text;

        Time.timeScale = 0f;
    }
}
