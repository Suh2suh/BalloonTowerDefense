using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyController : MonoBehaviour
{
    public GameObject dart_;
    GameObject target;
    GameObject monkeySpr;
    Vector3 vec;
    float angle;
    float delay;
    public bool isinstall = false;

    private void Start()
    {
        monkeySpr = gameObject.transform.Find("MonkeySprite").gameObject;
    }

    private void Update()
    {
        if(!isinstall)
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            if (Input.GetMouseButtonDown(0))
                isinstall = true;
        }

        delay += Time.deltaTime;

        if(target != null)
        {
            vec = target.transform.position - transform.position;
            
            angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;

            monkeySpr.transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);

            if(delay > 0.8f)
            {
                //Destroy(target);
                Debug.Log("´ó");

                var Dart = Instantiate(dart_, transform.position, Quaternion.identity, transform);
                Vector3 dir = (target.transform.position - transform.position).normalized;
                float a2 = Vector2.SignedAngle(Vector2.down, dir);
                Quaternion qua = new Quaternion();
                qua.eulerAngles = new Vector3(0, 0, a2);
                Dart.transform.rotation = qua;
                Dart.transform.position += dir * 1.0f;

                delay = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Balloon")
        {
            target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        target = null;
    }
}
