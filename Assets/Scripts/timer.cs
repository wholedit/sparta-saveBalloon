using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GM에서 시간을 가져와 UI에 표기한다
        float timerTime = gameManager.GM.timerTime;
        
        timerText.text = timerTime.ToString("N2");
    }
}
