using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private GameObject finishBlock;
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject starObject;

    [SerializeField] private TextMeshProUGUI starNumberText;
    [SerializeField] private TextMeshProUGUI starFinishNumberText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Finish();
        LevelControllerScript.instance.ManageStarNumber(starFinishNumberText.text);
        LevelControllerScript.instance.ManageCompletedLevel();
    }

    private void Finish()
    {
        finishBlock.SetActive(true);

        buttonPause.SetActive(false);
        starObject.SetActive(false);

        starFinishNumberText.text = starNumberText.text;

        Time.timeScale = 0f;
    }
}
