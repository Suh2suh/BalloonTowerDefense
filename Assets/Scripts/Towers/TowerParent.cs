using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerParent: MonoBehaviour
{
    protected GameObject target;
    public bool isinstalled = false;
    protected float delay = 0;


    protected void Update()
    {
        delay += Time.deltaTime;

        if (!isinstalled)
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            if (Input.GetMouseButtonDown(0)) isinstalled = true;
        }

        AttackTarget();
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Balloon")
        {
            target = collision.gameObject;
        }
    }

    protected void OnTriggerExit2D(Collider2D collision)
    {
        target = null;
    }

    protected virtual void AttackTarget()
    {

    }
}