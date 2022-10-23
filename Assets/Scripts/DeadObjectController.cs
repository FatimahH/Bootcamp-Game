﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadObjectController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().GameOver();
            GameManager.Instance.GameOver();
        }
    }
}
