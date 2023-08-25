using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControl : MonoBehaviour
{
    public int mon;
    public GameObject gam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dart")
        {
            GameManager.money += mon;
            if (gam != null)
            {
                Instantiate(gam, transform.position, Quaternion.identity);
            }
            else
            {
                GameManager.kill++;
            }
            Destroy(gameObject);
        }
    }
}
