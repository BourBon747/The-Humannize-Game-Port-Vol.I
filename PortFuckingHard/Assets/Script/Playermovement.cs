using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;

public class Playermovement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 moveDiraction;
    private Animator anim;
    bool facingRight = true;
    float moveInput;

    private void Start()
    {
         moveInput = Input.GetAxisRaw("Horizontal");
         anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = SimpleInput.GetAxisRaw("Horizontal");
        float moveY = SimpleInput.GetAxisRaw("Vertical");
        Vector2 inputP1 = new Vector2(SimpleInput.GetAxis("Horizoltal"), SimpleInput.GetAxis("Vertical"));
        
        moveDiraction = new Vector2(moveX, moveY);


        if (   Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))

        {
            anim.SetBool("iswalk", true);
        }
        else
        {
            anim.SetBool("iswalk", false);
        }

        if (moveX < 0 && facingRight)
        {
            flip();
        }
        else if (moveX > 0 && !facingRight)
        {
            flip();
        }

    }

    void FixedUpdate()
    {
        Move();
        Animation();
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDiraction.x * movespeed, moveDiraction.y * movespeed);
    }

    void Animation()
    {
        if (moveInput == 0)
        {
            anim.SetBool("iswalk", false);
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
     
}
