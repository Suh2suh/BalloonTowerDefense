using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCreater : MonoBehaviour
{
    float spawnTime;
    static public int spawnedBalloonNum = 0;

    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public GameObject sky;
    public GameObject pink;

    List<int> maxBalloonPerRound = new List<int> { 10, 10, 12, 10, 10, 15, 10, 10, 5, 10 };
    public List<int> MaxBalloonPerRound
    {
        get {   return maxBalloonPerRound;  }
    }

    List<float> spawnTimePerRound = new List<float> { 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.8f, 0.8f, 0.9f, 0.9f };


    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnedBalloonNum < maxBalloonPerRound[GameManager.round - 1])
        {
            if (spawnTime > spawnTimePerRound[GameManager.round - 1])
            {
                switch (GameManager.round)
                {
                    case 1:
                        Instantiate(red, transform.position, Quaternion.identity);

                        break;
                    case 2:
                        if (spawnedBalloonNum < 5) CreateBalloon(red);
                        else                       CreateBalloon(yellow);

                        break;
                    case 3:
                        if (spawnedBalloonNum < 7) CreateBalloon(red);
                        else                       CreateBalloon(yellow);

                        break;
                    case 4:
                        if (spawnedBalloonNum < 5)      CreateBalloon(red);
                        else if (spawnedBalloonNum < 9) CreateBalloon(yellow);
                        else                            CreateBalloon(green);

                        break;
                    case 5:
                        if (spawnedBalloonNum < 7)       CreateBalloon(red);
                        else if (spawnedBalloonNum < 10) CreateBalloon(green);

                        break;
                    case 6:
                        if (spawnedBalloonNum < 10)      CreateBalloon(red);
                        else if (spawnedBalloonNum < 11) CreateBalloon(sky);
                        else if (spawnedBalloonNum < 15) CreateBalloon(red);

                        break;
                    case 7:
                        if (spawnedBalloonNum < 10) CreateBalloon(yellow);

                        break;
                    case 8:
                        if (spawnedBalloonNum < 5)      CreateBalloon(yellow);
                        else if (spawnedBalloonNum < 6) CreateBalloon(sky);
                        else if (spawnedBalloonNum < 9) CreateBalloon(red);
                        else                            CreateBalloon(pink);

                        break;
                    case 9:
                        CreateBalloon(pink);

                        break;
                    case 10:
                        if (spawnedBalloonNum < 1)      CreateBalloon(pink);
                        else if (spawnedBalloonNum < 3) CreateBalloon(yellow);
                        else if (spawnedBalloonNum < 5) CreateBalloon(green);
                        else if (spawnedBalloonNum < 6) CreateBalloon(pink);
                        else if (spawnedBalloonNum < 9) CreateBalloon(yellow);
                        else                            CreateBalloon(pink);

                        break;
                    default:
                        Debug.Log("Round Limit Over Error in BalloonCreater.cs");
                        break;
                }

                spawnedBalloonNum++;
                spawnTime = 0;
            }
        }
    }

    void CreateBalloon(GameObject Balloon)
    {
        Instantiate(Balloon, transform.position, Quaternion.identity);
    }
}
