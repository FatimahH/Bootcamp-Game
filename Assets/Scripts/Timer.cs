using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Timer
    public int timeLeft = 120; //Seconds Overall
    public Text countdown; //UI Text Object
    public PlayerController player;
    int minutes;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Initialize",1f);
    }

    void Initialize()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            minutes = Mathf.FloorToInt(timeLeft / 60F);
            seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
            countdown.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        }
        else
        {
            player.GameOver();
            GameManager.Instance.GameOver();
        }
    }

    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
