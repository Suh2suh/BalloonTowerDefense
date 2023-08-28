using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMonkey : TowerParent
{
    [SerializeField] GameObject dart_;
    GameObject monkeySpr;
    Vector3 vec;
    float angle;


    private void Start()
    {
        monkeySpr = gameObject.transform.Find("SuperMonkeySprite").gameObject;
    }

    protected override void AttackTarget()
    {
        if (target != null)
        {
            vec = target.transform.position - transform.position;

            angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;

            monkeySpr.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

            if (delay > 0.4f)
            {
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
}
