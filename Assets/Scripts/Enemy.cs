using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] walk;
    public float speed;
    public bool MoveRight;

    void Start()
    {
        StartCoroutine(Walk());
    }
    void Update()
    {
        // Use this for initialization
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
    }
    IEnumerator Walk()
    {
        int i;
        i = 0;
        while (i < walk.Length)
        {
            spriteRenderer.sprite = walk[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;
        }
        StartCoroutine(Walk());
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Turn"))
        {

            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
}
