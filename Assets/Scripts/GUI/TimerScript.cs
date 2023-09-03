using UnityEngine;
using TMPro;
using System;

public class TimerScript : MonoBehaviour
{
    private TextMeshProUGUI textTimer;

    private float timer;
    // private float finishTime - для сохранения времени уровня игрока
    public bool isFinish;

    // Start is called before the first frame update
    void Start()
    {
        textTimer = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFinish)
        {
            timer += Time.deltaTime;
            textTimer.SetText(timer.ToString("F3"));
        }
    }

    public float FinishTime()
    {
        textTimer.SetText("Finish!");
        return timer;
    }
}
