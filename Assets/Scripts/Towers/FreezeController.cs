using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeController : TowerParent
{
    protected override void AttackTarget()
    {
        if (target != null)
        {
            if (delay > 2.0f)
            {
                target.GetComponent<BalloonController>().Speed *= 0.5f;

                delay = 0;
            }
        }
    }
}
