using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlock : MonoBehaviour
{

    float moveSpeed = 3f;
    bool moveUp = false;
    bool startMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveUp && startMoving)
        {
            //transform.position = new Vector2(transform.position.x, 0f);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, 1f), moveSpeed * Time.deltaTime);
        }
        else if (!moveUp && startMoving)
        {
            //transform.position = new Vector2(transform.position.x, -4f);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -4f), moveSpeed * Time.deltaTime);
        }
        
    }

    public void MoveUp()
    {
        //if (transform.position.y > 1f)
            //moveUp = false;
        //if (transform.position.y < -4f)
            moveUp = true;
        startMoving = true;

        //if (moveUp)
            //transform.position = new Vector2(transform.position.x, 0f);
            //transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, 1f), moveSpeed * Time.deltaTime);
        //else
            //transform.position = new Vector2(transform.position.x, -4f);
            //transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -4f), moveSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        //if (transform.position.y > 1f)
            moveUp = false;
        startMoving = true;
        //if (transform.position.y < -4f)
        // moveUp = true;

        //if (moveUp)
        //transform.position = new Vector2(transform.position.x, 1f);
        //transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, 1f), moveSpeed * Time.deltaTime);
        //else
        //transform.position = new Vector2(transform.position.x, -4f);
        //transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -4f), moveSpeed * Time.deltaTime);
    }
}
