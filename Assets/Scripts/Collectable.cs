using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int bookNum;
    AudioSource collectSound;

    // Use this for initialization
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
        collectSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            collectSound.Play();
            gameLevelManager.AddBooks(bookNum);
            Destroy(gameObject);
        }
    }
    public void ShowBook()
    {
        gameObject.SetActive(true);
    }
}
