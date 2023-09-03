using TMPro;
using UnityEngine;

public class StarText : MonoBehaviour
{
    [SerializeField] private int _levelIndex;

    private TextMeshProUGUI _starTextComponent;

    void Start()
    {
        _starTextComponent = gameObject.GetComponent<TextMeshProUGUI>();
        _starTextComponent.text = PlayerPrefs.GetInt("Level" + _levelIndex).ToString() + "%";
    }
}
