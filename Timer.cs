using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;


    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0) {
                seconds += 59;
                minutes -= 1;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}
