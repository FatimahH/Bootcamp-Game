using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public SpriteRenderer lever;
    public Sprite leverOff;
    public Sprite leverOn;
    public PuzzleBlock blockOne;
    public PuzzleBlock blockTwo;
    public PuzzleBlock blockThree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.X))
        {
            if (gameObject.name == "Lever_One")
            {
                if(lever.sprite.name == "Lever_off")
                {
                    Debug.Log("collide one off");
                    lever.sprite = leverOn;
                    blockOne.MoveUp();
                    blockTwo.MoveUp();
                    blockThree.MoveDown();
                }
                else if (lever.sprite.name == "Lever_on")
                {
                    Debug.Log("collide one on");
                    lever.sprite = leverOff;
                    blockOne.MoveDown();
                    blockTwo.MoveDown();
                    blockThree.MoveUp();
                }

            }

            if (gameObject.name == "Lever_Two")
            {
                if (lever.sprite.name == "Lever_off")
                {

                    Debug.Log("collide two off");
                    lever.sprite = leverOn;
                    blockTwo.MoveDown();
                    blockThree.MoveDown();
                }
                else if (lever.sprite.name == "Lever_on")
                {
                    Debug.Log("collide two on");
                    lever.sprite = leverOff;
                    blockTwo.MoveUp();
                    blockThree.MoveUp();
                }
            }

            if (gameObject.name == "Lever_Three")
            {
                if (lever.sprite.name == "Lever_off")
                {
                    Debug.Log("collide three off");
                    lever.sprite = leverOn;
                    blockOne.MoveUp();
                    blockTwo.MoveDown();
                    blockThree.MoveUp();
                }
                else if (lever.sprite.name == "Lever_on")
                {
                    Debug.Log("collide three on");
                    lever.sprite = leverOff;
                    blockOne.MoveDown();
                    blockTwo.MoveUp();
                    blockThree.MoveDown();
                }
            }

            if (gameObject.name == "Lever_Four")
            {
                if (lever.sprite.name == "Lever_off")
                {
                    Debug.Log("collide four off");
                    lever.sprite = leverOn;
                    blockOne.MoveDown();
                }
                else if (lever.sprite.name == "Lever_on")
                {
                    Debug.Log("collide four on");
                    lever.sprite = leverOff;
                    blockOne.MoveUp();
                }

            }

        }
    }
}
