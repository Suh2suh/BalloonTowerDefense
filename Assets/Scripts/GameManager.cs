using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public short round = 1;
    static public short life = 30;
    static public int money = 650;
    static public int kill = 0;
    int maxround = 10;
    float nextRoundTime = 0;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life > 0)
        {
            if (kill == BalloonCreater.balloonnum && BalloonCreater.balloonnum > 0)
            {
                nextRoundTime += Time.deltaTime;
                if (nextRoundTime > 5)
                    if (round < maxround)
                    {
                        kill = 0;
                        BalloonCreater.balloonnum = 0;
                        round++;
                        Debug.Log(round.ToString() + "라운드 시작");
                        nextRoundTime = 0;
                    }
                else
                    {
                        GameObject.Find("Panel").SetActive(false);
                        canvas.gameObject.transform.Find("WinPanel").gameObject.SetActive(true);
                    }
            }
        }

        else
        {
            GameObject.Find("Panel").SetActive(false);
            canvas.gameObject.transform.Find("LosePanel").gameObject.SetActive(true);
        }
    }
}
