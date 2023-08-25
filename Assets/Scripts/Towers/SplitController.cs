using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitController : MonoBehaviour
{
    public bool isinstall = false;
    float delay = 0;
    GameObject target;

    public GameObject splitdarts_;

    // Update is called once per frame
    void Update()
    {
        if (!isinstall)
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 90);
            if (Input.GetMouseButtonDown(0))
                isinstall = true;
        }

        delay += Time.deltaTime;

        if (target != null)
        {
            if (delay > 2f)
            {
                split();
                delay = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Balloon")
        {
            target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        target = null;
    }

    public void split()
    {
        GameObject Dart4 = Instantiate(splitdarts_);

        Dart4.transform.position = transform.position;

        Transform[] childs = Dart4.GetComponentsInChildren<Transform>();

        for (int i = 0; i < childs.Length; i++) 
        {
            childs[i].parent = null;
        }
        Destroy(Dart4);
    }
}
