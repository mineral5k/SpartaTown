using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{

    Text clockTxt;
    
    private void Awake()
    {
        clockTxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        clockTxt.text = DateTime.Now.ToString("HH:mm");
    }
}
