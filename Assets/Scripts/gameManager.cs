using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    // block ����
    public GameObject block;

    // ���� ���� �ǳ�
    public GameObject endPanel;

    //�̱��� ó��
    public static gameManager GM;

    // balloon anim ����
    public Animator anim;

    // level ����
    public int level = 0;
    public Text levelTxt;
    // �ð� ����
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
        // �ð� ���
        timerTime += Time.deltaTime;

        // �ð� ����� ���� ������ �����Ѵ�
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

    // block ���� �Լ�
    void genBlock()
    {
        Instantiate(block);        
    }

    // ���� ���� �Լ�
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
