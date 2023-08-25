using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{
    public GameObject monkey;
    public GameObject split;
    public GameObject freeze;
    public GameObject supermonkey;

    public void SetMonkey()
    {
        if(GameManager.money >= 250)
        {
            Instantiate(monkey, Input.mousePosition, Quaternion.identity);
            GameManager.money -= 250;
        }
    }

    public void SetSplit()
    {
        if (GameManager.money >= 320)
        {
            Instantiate(split, Input.mousePosition, Quaternion.identity);
            GameManager.money -= 320;
        }
    }

    public void SetFreeze()
    {
        if (GameManager.money >= 600)
        {
            Instantiate(freeze, Input.mousePosition, Quaternion.identity);
            GameManager.money -= 600;
        }
    }
    public void SetSuperMonkey()
    {
        if (GameManager.money >= 1000)
        {
            Instantiate(supermonkey, Input.mousePosition, Quaternion.identity);
            GameManager.money -= 1000;
        }
    }
}
