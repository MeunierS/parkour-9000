using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class Timer : MonoBehaviour
{
    private float timeElapsed;
    private float record = 999999;
    private bool timerRunning;
    public TMP_Text timerText;
    public TMP_Text bestTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            timeElapsed += Time.deltaTime;
            timerText.SetText($"{timeElapsed:0.00}");
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Start")){
            timerRunning = true;
        } else if (other.CompareTag("End"))
        {
            timerRunning=false;
            if (timeElapsed < record){
                record = timeElapsed;
                bestTime.SetText($"Best : {record:0.00}");
                timeElapsed = 0;
            }
        }
    }
}
