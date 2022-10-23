using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalObjectController : MonoBehaviour
{
    public LevelManager levelManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        Debug.Log("collide");
            if (levelManager.books == 5)
            {
                collision.gameObject.GetComponent<PlayerController>().Goal();
                GameManager.Instance.StageComplete();
            }
        }
    }
}
