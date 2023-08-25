using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text txtRound;
    Text txtLife;
    Text txtMoney;
    // Start is called before the first frame update
    void Start()
    {
        txtRound = GameObject.Find("TextRoundNum").GetComponent<Text>();
        txtLife = GameObject.Find("TextLifeNum").GetComponent<Text>();
        txtMoney = GameObject.Find("TextMoneyNum").GetComponent<Text>();
    }

    private void Update()
    {
        txtRound.text = GameManager.round.ToString();
        txtLife.text = GameManager.life.ToString();
        txtMoney.text = GameManager.money.ToString();
    }
}
