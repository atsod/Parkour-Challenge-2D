using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarTextScript : MonoBehaviour
{
    private TextMeshProUGUI starText;
    [SerializeField] private int levelIndex;

    void Start()
    {
        starText = gameObject.GetComponent<TextMeshProUGUI>();
        starText.text = PlayerPrefs.GetInt("Level" + levelIndex).ToString() + "%";
    }
}
