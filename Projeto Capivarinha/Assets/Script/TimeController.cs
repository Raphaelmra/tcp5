using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    [SerializeField] private Text _timeText;
    private int _minutes;
    private float seconds;

    void Start()
    {
        _minutes = 2;
        seconds = 5;

        
    }

    // Update is called once per frame
    void Update()
    {
       

        seconds -= 1 * Time.deltaTime;

        if(seconds <= 0)
        {
            _minutes--;
            seconds = 60;
        }

        _timeText.text = $"{_minutes}:{seconds.ToString("0")}";
        
    }
}
