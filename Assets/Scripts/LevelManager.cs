using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    //public float respawnDelay;
    public PlayerController gamePlayer;
    public int books;
    public Text bookText;

    // Use this for initialization
    void Start()
    {
        gamePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //public void Respawn()
   // {
     //   StartCoroutine("RespawnCoroutine");
   // }
   // public IEnumerator RespawnCoroutine()
  //  {
      //  gamePlayer.gameObject.SetActive(false);
      //  yield return new WaitForSeconds(respawnDelay);
      //  gamePlayer.transform.position = gamePlayer.respawnPoint;
      //  gamePlayer.gameObject.SetActive(true);
   // }
    public void AddBooks(int numberOfBooks)
    {
        books += numberOfBooks;
        bookText.text = "" + books;
    }
}
