using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    //block ��ġ ����
    float x;
    float y;
    // block ũ�� ����
    float size;
    // Start is called before the first frame update

    Rigidbody2D rigid;

    void Start()
    {
        //x,y ��ġ��Ű��
        x = Random.Range(-14f, 14f);
        y = Random.Range(20f, 28f);
        transform.position = new Vector3(x, y, 0);

        // ũ�� ���ϱ�
        size = Random.Range(4f, 11f);
        transform.localScale = new Vector3(size, size, 0);

        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ȭ�� �ƿ��� �� ȸ��
        float downLimit = transform.position.y;
        if (downLimit < -30f)
        {
            Destroy(gameObject);
        }
        // ������ ���� �߷��� �����Ѵ�
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
        // ǳ�� �浹�� ����
        if( collision.gameObject.tag == "balloon")
        {
            gameManager.GM.gameOver();

        }
    }
}
