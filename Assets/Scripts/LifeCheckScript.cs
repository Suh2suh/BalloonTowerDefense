using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCheckScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Balloon")     //풍선이 길 끝까지 오면,
        {
            if (GameManager.life > 0)     //라이프 하나씩 감소 (0일 경우 감소 불가)
            {
                GameManager.life--;
            }
            GameManager.kill++;
        }

        Destroy(collision.gameObject, 0.3f);
    }
}
