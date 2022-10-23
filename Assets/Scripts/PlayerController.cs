using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;
    float axisH = 0.0f;
    public float speed = 3.0f;

    public float jump = 9.0f;
    public LayerMask groundLayer;
    //bool gonnaJump = false;
    bool onGround = false;
    bool doubleJump = false;

    public static PlayerController Instance;

    AudioSource jumpSound;

    enum State
    {
        playing,
        gameComplete,
        gameOver,
    }

    State gameState = State.playing;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        gameState = State.playing;
        jumpSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gameState != State.playing)
        {
            return;
        }

        axisH = Input.GetAxisRaw("Horizontal");
        if (axisH > 0.0f)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (axisH < 0.0f)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Jump();
            if (onGround)
            {
                Jump();
                doubleJump = true;
            }
            else if (doubleJump)
            {
                jump = jump / 1.5f;
                Jump();

                doubleJump = false;
                jump = jump * 1.5f;
            }
        }
    }

    void FixedUpdate()
    {
        if (gameState != State.playing)
        {
            return;
        }

        onGround = Physics2D.Linecast(transform.position,
            transform.position - (transform.up * 0.1f),
            groundLayer);
        if (onGround || axisH != 0)
        {
            rbody.velocity = new Vector2(speed * axisH, rbody.velocity.y);
        }

        //if (onGround && gonnaJump)
        //{
          //  Vector2 jumpPw = new Vector2(0, jump);
          //  rbody.AddForce(jumpPw, ForceMode2D.Impulse);
          //  gonnaJump = false;
        //}
    }

    void Jump()
    {
        jumpSound.Play();
        //gonnaJump = true;
        rbody.velocity = Vector2.up * jump;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("block_move"))
            this.transform.parent = col.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("block_move"))
            this.transform.parent = null;
    }

    public void Goal()
    {
        gameState = State.gameComplete;
        GameStop();
    }

    public void GameOver()
    {
        gameState = State.gameOver;
        GameStop();
        //GetComponent<CapsuleCollider2D>().enabled = false;
        //rbody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }

    void GameStop()
    {
        Rigidbody2D rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(0, 0);

    }
}