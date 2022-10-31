using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float timer;
    public Text timerText;

    public bool timeOut = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 26f; 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "" + timer.ToString("f1");
        if (timer <= 0)
        {
            TimeOut();
        }

    }
    public void sumarSegundos(float segundos)
    {
        timer = timer + segundos;
    }
    public void TimeOut()
    {
        timeOut = true;
        timer = 0;
    }

}

