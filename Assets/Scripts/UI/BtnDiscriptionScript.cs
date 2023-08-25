using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnDiscriptionScript : MonoBehaviour
{
    GameObject btnnow;
    private void OnMouseEnter()
    {
        btnnow = gameObject;
        btnnow.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        if (btnnow.transform.GetChild(0).gameObject.activeSelf)
            btnnow.transform.GetChild(0).gameObject.SetActive(false);
    }
}
