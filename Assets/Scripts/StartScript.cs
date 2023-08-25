using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    float startTime = 0;
    void Update()
    {
        startTime += Time.deltaTime;

        if(startTime > 3)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
