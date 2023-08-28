using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    [SerializeField] float speed;
    public float Speed
    {
        get { return speed;  }
        set { speed = value; }
    }

    Vector3 currentDir;

    void Start()
    {
        currentDir = Directions.vecR;
    }

    void Update()
    {
        transform.Translate(currentDir * speed,Space.Self);
    }

    public void ChangeDir(Vector3 newDir)
    {
        currentDir = newDir;
    }


    [SerializeField] int rewardMoney;
    [SerializeField] GameObject subBalloon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dart")
        {
            GameManager.money += rewardMoney;

            if (subBalloon != null) Instantiate(subBalloon, transform.position, Quaternion.identity);
            else                    GameManager.destroyedBalloonInRound++;

            Destroy(gameObject);
        }
    }
}
