using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TMP_Text textTimer;
    private float time = 0.0f;
    private bool isTimer = false;
    void Start(){
        StartTimer();
    }
 
    // Update is called once per frame
    void Update()
    {
        if(isTimer)
        {
            time += Time.deltaTime;
            DisplayTime();
        }
    }
    void DisplayTime()
    {
        int minutes= Mathf.FloorToInt(time / 60.0f);
        int seconds = Mathf.FloorToInt(time - minutes *60);
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StartTimer()
    {
        isTimer=true;
    }
    public void StopTimer()
    {
        isTimer=false;
    }
    public void ResetTimer()
    {
        time = 0.0f;
    }
}
