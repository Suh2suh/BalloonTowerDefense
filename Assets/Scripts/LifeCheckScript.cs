using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCheckScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Balloon")     //ǳ���� �� ������ ����,
        {
            Destroy(collision.gameObject, 0.3f);

            if (GameManager.life > 0)   GameManager.life--;

            GameManager.destroyedBalloonInRound++;
        }
    }
}
