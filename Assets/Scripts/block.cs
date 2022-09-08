using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    //block 위치 변수
    float x;
    float y;
    // block 크기 변수
    float size;
    // Start is called before the first frame update

    Rigidbody2D rigid;

    void Start()
    {
        //x,y 위치시키기
        x = Random.Range(-14f, 14f);
        y = Random.Range(20f, 28f);
        transform.position = new Vector3(x, y, 0);

        // 크기 정하기
        size = Random.Range(4f, 11f);
        transform.localScale = new Vector3(size, size, 0);

        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 화면 아웃시 블럭 회수
        float downLimit = transform.position.y;
        if (downLimit < -30f)
        {
            Destroy(gameObject);
        }
        // 레벨에 따라 중력을 가중한다
        if (gameManager.GM.level == 0)
        {
            rigid.gravityScale = 2;

        }
        else if (gameManager.GM.level == 1)
        {
            rigid.gravityScale = 3;
        }
        else
        {
            rigid.gravityScale = 5;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 풍선 충돌시 종료
        if( collision.gameObject.tag == "balloon")
        {
            gameManager.GM.gameOver();

        }
    }
}
