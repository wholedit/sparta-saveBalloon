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
        // GM���� �ð��� ������ UI�� ǥ���Ѵ�
        float timerTime = gameManager.GM.timerTime;
        
        timerText.text = timerTime.ToString("N2");
    }
}
