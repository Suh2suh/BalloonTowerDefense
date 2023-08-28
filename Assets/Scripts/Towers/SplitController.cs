using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitController : TowerParent
{
    [SerializeField] GameObject splitdarts_;

    protected override void AttackTarget()
    {
        if (target != null)
        {
            if (delay > 2f)
            {
                split();
                delay = 0;
            }
        }
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
