using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    bool moveRight;
    bool moveUp;

    public float moveSpeed;
    public float rightEdge;
    public float leftEdge;
    public float upEdge;
    public float downEdge;
    public bool horizontalMove;
    public bool verticalMove;

    // Update is called once per frame
    void Update () {
        if (horizontalMove)
        {
            if (transform.position.x > leftEdge)
                moveRight = false;
            if (transform.position.x < rightEdge)
                moveRight = true;

            if (moveRight)
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            else
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }

        if (verticalMove)
        {
            if (transform.position.y > upEdge)
                moveUp = false;
            if (transform.position.y < downEdge)
                moveUp = true;

            if (moveUp)
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            else
                transform.position = new Vector2(transform.position.x , transform.position.y - moveSpeed * Time.deltaTime);
        }

    }
}
