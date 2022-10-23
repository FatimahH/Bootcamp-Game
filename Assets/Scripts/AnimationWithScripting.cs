using UnityEngine;
using System.Collections;
public class AnimationWithScripting : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] walk;
    public Sprite[] idle;
    //public Sprite[] jump;
    void Start()
    {
        //StartCoroutine(Idle());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            StopAllCoroutines();
            StartCoroutine(Idle());
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    StopAllCoroutines();
        //    StartCoroutine(Jump());
        //}
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopAllCoroutines();
            StartCoroutine(Walk());
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.Space))
        {
            StopAllCoroutines();
            StartCoroutine(Idle());
        }
    }
    IEnumerator Idle()
    {
        int i;
        i = 0;
        while (i < idle.Length)
        {
            spriteRenderer.sprite = idle[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Idle());
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

    //IEnumerator Jump()
    //{
    //    int i;
    //    i = 0;
    //    while (i < jump.Length)
    //    {
    //        spriteRenderer.sprite = jump[i];
    //        i++;
    //        yield return new WaitForSeconds(0.07f);
    //        yield return 0;

    //    }
    //    StartCoroutine(Jump());
    //}
}