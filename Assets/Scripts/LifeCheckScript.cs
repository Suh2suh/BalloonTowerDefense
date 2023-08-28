using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCheckScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Balloon")     //풍선이 길 끝까지 오면,
        {
            Destroy(collision.gameObject, 0.3f);

            if (GameManager.life > 0)   GameManager.life--;

            GameManager.destroyedBalloonInRound++;
        }
    }
}
