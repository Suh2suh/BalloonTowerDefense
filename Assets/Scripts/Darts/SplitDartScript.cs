using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitDartScript : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        Vector3 dir = transform.up;
        transform.position += dir * speed * Time.deltaTime;
    }

    void Start()
    {
        Destroy(gameObject, 1.2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Balloon")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
