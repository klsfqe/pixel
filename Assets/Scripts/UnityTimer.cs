using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnityTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public int timer = 0;

    private void Start()
    {
        StartCoroutine(TimerCoroution());
    }

    IEnumerator TimerCoroution()
    {
        timer += 1;

        timerText.text = (timer / 3600).ToString("D2") + ":" + (timer / 60 % 60).ToString("D2") + ":" + (timer % 60).ToString("D2");

        yield return new WaitForSeconds(1f);

        StartCoroutine(TimerCoroution());
    }
}