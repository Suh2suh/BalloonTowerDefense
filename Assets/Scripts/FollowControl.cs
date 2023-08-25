using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowControl : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�浹 ����");
        if(collision.tag == "Balloon")
        {
            switch (gameObject.tag)
            {
                case "Up":
                    collision.transform.GetComponent<BaloonParent>().ChangeDir(Directions.vecU);
                    break;
                case "Down":
                    collision.transform.GetComponent<BaloonParent>().ChangeDir(Directions.vecD);
                    break;
                case "Right":
                    collision.transform.GetComponent<BaloonParent>().ChangeDir(Directions.vecR);
                    break;
                case "Left":
                    collision.transform.GetComponent<BaloonParent>().ChangeDir(Directions.vecL);
                    break;
                default:
                    Debug.Log("Error in FollowControl");
                    break;
            }
        }
    }
}
