using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonParent : MonoBehaviour
{
    public float speed;
    public Vector3 vec;

    void Start()
    {
        vec = Directions.vecR;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vec * speed,Space.Self);
    }

    public void ChangeDir(Vector3 v)
    {
        vec = v;
    }
}
