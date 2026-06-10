using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{

    [Header("Player Setup")]
    public Rigidbody2D rb;
    public Vector2 friction = new Vector2(-0.1f, 0);
    public float speed;
    public float runSpeed;
    public float jumpForce = 6f;


    [Header("Player Animations")]
    public Animator animator;
    public string boolRunning = "isRunning";
    public string boolJumping = "isJumping";
    public string boolFalling = "isFalling";
    public float swipeTransition = 0.5f;
    
    void Update()
    {
        HandleMovement();
        HandleJump(); 
        
    }

    private void HandleMovement()
    {
        float move = Input.GetAxis("Horizontal");

        if(move != 0)
        {
            animator.SetBool(boolRunning, true);
        }
        else
        {
            animator.SetBool(boolRunning, false);
        }

        if(rb.linearVelocity.x > 0)
        {
            rb.transform.DOScaleX(1, swipeTransition);
            rb.linearVelocity += friction;
        }
        else if(rb.linearVelocity.x < 0)
        {
            rb.transform.DOScaleX(-1, swipeTransition);
            rb.linearVelocity -= friction;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.linearVelocity = new Vector2(move * runSpeed, rb.linearVelocity.y);
            animator.speed = 1.5f;
        }
        else
        {
            rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
        }
    }

    private void HandleJump()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(rb.linearVelocity.y != 0) return;

                animator.SetBool(boolJumping, true);
                rb.linearVelocity = Vector2.up * jumpForce;
            }
            else if(Input.GetKeyUp(KeyCode.Space))
            {
                animator.SetBool(boolJumping, false);
            }

            if(rb.linearVelocity.y < 0)
            {
                animator.SetBool(boolFalling, true);
            }
            else
            {
                animator.SetBool(boolFalling, false);
            }
            
        }

    


}
