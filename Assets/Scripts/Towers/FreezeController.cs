using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeController : MonoBehaviour
{
    GameObject target;
    public bool isinstall = false;
    float delay = 0;
   

    // Update is called once per frame
    void Update()
    {
        if (!isinstall)
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            if (Input.GetMouseButtonDown(0))
                isinstall = true;
        }

        delay += Time.deltaTime;
        if(target != null)
        {
            if (delay > 4)
            {
                target.GetComponent<BaloonParent>().speed = 0.1f;

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
}
