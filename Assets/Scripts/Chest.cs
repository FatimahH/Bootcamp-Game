using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    bool locked = true;
    public Collectable book;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock()
    {
        locked = false;
    }

    void OnTriggerStay2D(Collider2D other)
    { 
        if (other.tag == "Player" && !locked && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("collide chest");
            book.ShowBook();
            Destroy(gameObject);
        }
    }
}
