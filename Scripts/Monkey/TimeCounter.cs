using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float timeCount;
    [SerializeField] private float countDown = 120f;
    [SerializeField] private int min;
    [SerializeField] private int sec;
    [SerializeField] private bool isCountdown;
    [SerializeField] private TextMeshProUGUI timerText;
    private bool stop = false;
    public AudioSource tickSource;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (stop) return;
        if (isCountdown && countDown > 0)
        {
            countDown -= Time.deltaTime;
            min = Mathf.FloorToInt(countDown / 60f);
            sec = Mathf.FloorToInt(countDown - min * 60);
        }
        else if (!isCountdown)
        {
            timeCount += Time.deltaTime;
            min = Mathf.FloorToInt(timeCount / 60f);
            sec = Mathf.FloorToInt(timeCount - min * 60);
        }
        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tickSource.Play();
            stop = true;
        }
    }
}
