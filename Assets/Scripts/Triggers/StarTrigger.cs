using TMPro;
using UnityEngine;

public class StarTrigger : MonoBehaviour
{
    public static int StarScore;

    [SerializeField] private TextMeshProUGUI _scoreStarTextGUI;
    [SerializeField] private TextMeshProUGUI _scoreStarTextPause;
    [SerializeField] private int _starAmount;

    private bool _isStarTriggered;

    private void Awake()
    {
        StarScore = 0;
        ChangeTextGUI();
        _isStarTriggered = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeroMovement>() != null && !_isStarTriggered)
        {
            _isStarTriggered = true;
            StarScore++;
            ChangeTextGUI();
            GetComponent<AudioSource>().Play();
            Invoke(nameof(DestroyStar), 0.5f);
        }
    }

    private void ChangeTextGUI()
    {
        _scoreStarTextGUI.text = StarScore.ToString() + "/" + _starAmount;
        _scoreStarTextPause.text = _scoreStarTextGUI.text;
    }

    private void DestroyStar()
    {
        Destroy(gameObject);
    }
}
