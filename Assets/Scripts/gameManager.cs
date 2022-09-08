using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    // block 변수
    public GameObject block;

    // 게임 종료 판넬
    public GameObject endPanel;

    //싱글톤 처리
    public static gameManager GM;

    // balloon anim 변수
    public Animator anim;

    // level 변수
    public int level = 0;
    public Text levelTxt;
    // 시간 변수
    public float timerTime = 0.0f;
    

    void Awake()
    {
        GM = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("genBlock", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // 시간 경과
        timerTime += Time.deltaTime;

        // 시간 경과에 따라 레벨을 설정한다
        if (timerTime < 5f)
        {
            level = 0;
        }
        else if (timerTime <10f)
        {
            level = 1;
        }
        else
        {
            level = 2;
        }
        levelTxt.text = level.ToString();
    }

    // block 생성 함수
    void genBlock()
    {
        Instantiate(block);        
    }

    // 게임 종료 함수
    public void gameOver()
    {
        Invoke("timeStop", 0.6f);
        endPanel.SetActive(true);
        anim.SetBool("Die", true);
    }

    public void timeStop()
    {
        Time.timeScale = 0.0f;
    }
}
