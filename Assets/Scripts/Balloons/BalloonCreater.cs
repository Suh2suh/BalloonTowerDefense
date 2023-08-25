using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCreater : MonoBehaviour
{
    float spontime;
    static public int balloonnum;

    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public GameObject sky;
    public GameObject pink;

    // Update is called once per frame
    void Update()
    {
        spontime += Time.deltaTime;
        switch(GameManager.round)
        {
            case 1:
                if(balloonnum < 10)
                {
                    if (spontime > 0.5f)
                    {
                        Instantiate(red, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 2:
                if (balloonnum < 10)
                {
                    if (spontime > 0.5f)
                    {
                        if(balloonnum < 5)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 3:
                if (balloonnum < 12)
                {
                    if (spontime > 0.5f)
                    {
                        if (balloonnum < 7)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 4:
                if (balloonnum < 10)
                {
                    if (spontime > 0.5f)
                    {
                        if (balloonnum < 5)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else if(balloonnum < 9)
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        else
                            Instantiate(green, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 5:
                if (balloonnum < 10)
                {
                    if (spontime > 0.5f)
                    {
                        if (balloonnum < 7)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else if (balloonnum < 10)
                            Instantiate(green, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 6:
                if (balloonnum < 15)
                {
                    if (spontime > 0.5f)
                    {
                        if (balloonnum < 10)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else if(balloonnum < 11)
                            Instantiate(sky, transform.position, Quaternion.identity);
                        else if(balloonnum < 15)
                            Instantiate(red, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 7:
                if (balloonnum < 10)
                {
                    if (spontime > 0.8f)
                    {
                        if (balloonnum < 10)
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 8:
                if (balloonnum < 10)
                {
                    if (spontime > 0.8f)
                    {
                        if (balloonnum < 5)
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        else if (balloonnum < 6)
                            Instantiate(sky, transform.position, Quaternion.identity);
                        else if (balloonnum < 9)
                            Instantiate(red, transform.position, Quaternion.identity);
                        else
                            Instantiate(pink, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 9:
                if (balloonnum < 5)
                {
                    if (spontime > 0.9f)
                    {
                        Instantiate(pink, transform.position, Quaternion.identity);
                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            case 10:
                if (balloonnum < 10)
                {
                    if (spontime > 0.9f)
                    {
                        if(balloonnum < 1)
                           Instantiate(pink, transform.position, Quaternion.identity);
                        else if(balloonnum < 3)
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        else if(balloonnum < 5)
                            Instantiate(green, transform.position, Quaternion.identity);
                        else if(balloonnum < 6)
                            Instantiate(pink, transform.position, Quaternion.identity);
                        else if(balloonnum < 9)
                            Instantiate(yellow, transform.position, Quaternion.identity);
                        else
                            Instantiate(pink, transform.position, Quaternion.identity);

                        balloonnum++;
                        spontime = 0;
                    }
                }
                break;
            default:
                break;
        }
    }
}
