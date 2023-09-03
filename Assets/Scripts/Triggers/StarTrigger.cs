using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarTrigger : MonoBehaviour
{
    public static int starScore;

    [SerializeField] private TextMeshProUGUI scoreStarTextGUI;
    [SerializeField] private TextMeshProUGUI scoreStarTextPause;
    [SerializeField] private int starAmount;

    private bool isStarTriggered = false;

    void Start()
    {
        starScore = 0;
        ChangeTextGUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isStarTriggered)
        {
            isStarTriggered = true;
            starScore++;
            ChangeTextGUI();
            GetComponent<AudioSource>().Play();
            Invoke("DestroyStar", 0.5f);
        }
    }

    private void ChangeTextGUI()
    {
        scoreStarTextGUI.text = starScore.ToString() + "/" + starAmount;
        scoreStarTextPause.text = scoreStarTextGUI.text;
    }

    private void DestroyStar()
    {
        Destroy(gameObject);
    }
}
