using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCheckScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Balloon")     //ǳ���� �� ������ ����,
        {
            if (GameManager.life > 0)     //������ �ϳ��� ���� (0�� ��� ���� �Ұ�)
            {
                GameManager.life--;
            }
            GameManager.kill++;
        }

        Destroy(collision.gameObject, 0.3f);
    }
}
