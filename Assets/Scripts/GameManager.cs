using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//sometimes we need to tell the script what library to use
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timerSet;
    float timer;

    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {

        timer = timerSet;
        timerText.text = "Timer: " + timer;

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = timerSet;
        }
        float seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = "Timer: " + seconds;

    }
}
