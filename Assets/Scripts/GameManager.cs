using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public short round = 9;
    static public short life = 30;
    static public int money = 650;

    [SerializeField] Canvas Canvas;
    [SerializeField] BalloonCreater BalloonCreater;

    static public int destroyedBalloonInRound = 0;
    int maxround = 10;
    float RoundPreparingTime = 0;




    void Update()
    {
        if(life > 0)
        {
            if (IsThisRoneDone())
            {
                if (round < maxround)
                {
                    RoundPreparingTime += Time.deltaTime;

                    if (RoundPreparingTime > 5.0f)
                    {
                        StartNewRound();

                        RoundPreparingTime = 0.0f;
                    }
                }
                else
                {
                    ProcessWin();
                }
            }
        }

        else
        {
            ProcessLose();
        }
    }


    bool IsThisRoneDone()
    {
        Debug.Log("Destroyed: " + destroyedBalloonInRound + "/ Max: " + BalloonCreater.MaxBalloonPerRound[round-1]);

        return (destroyedBalloonInRound == BalloonCreater.MaxBalloonPerRound[round-1]);

    }
    void StartNewRound()
    {
        Debug.Log("Round Start");

        destroyedBalloonInRound = 0;
        BalloonCreater.spawnedBalloonNum = 0;

        round++;
    }


    void ProcessWin()
    {
        Canvas.transform.Find("Panel").gameObject.SetActive(false);
        Canvas.gameObject.transform.Find("WinPanel").gameObject.SetActive(true);
    }

    void ProcessLose()
    {
        Canvas.transform.Find("Panel").gameObject.SetActive(false);
        Canvas.gameObject.transform.Find("LosePanel").gameObject.SetActive(true);
    }

}
