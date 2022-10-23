using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverObject;
    public GameObject stageCompleteObject;

    public static GameManager Instance;

    AudioSource music;

    void Awake()
    {
        Instance = this;
        music = GetComponent<AudioSource>();
    }
    
    public void GameOver()
    {
        gameOverObject.SetActive(true);
        music.Stop();
    }

    public void StageComplete()
    {
        stageCompleteObject.SetActive(true);
        music.Stop();
    }
}
