using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartScript : MonoBehaviour
{
    public Vector3 target_vec;
    // Start is called before the first frame update
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
