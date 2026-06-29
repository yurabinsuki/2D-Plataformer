using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{

    [Header("Setup")]
    public SOPlayerSetup soPlayerSetup;
    public Rigidbody2D rb;
    public HealthBase healthBase;
    public Animator animator;



    void Awake()
    {
        if(healthBase != null)
        {
            healthBase.OnKill += PlayerKilled;
        }
    }

    private void PlayerKilled()
    {
        healthBase.OnKill -= PlayerKilled; 
        PlayerDeath();
    }

    private void PlayerDeath()
    {
        animator.SetTrigger(soPlayerSetup.triggerDeath);  
    }
    
    void Update()
    {
        HandleMovement();
        HandleJump(); 
        HandleFalling();
    }

    private void HandleMovement()
    {
        float move = Input.GetAxis("Horizontal");

        if(move != 0)
        {
            animator.SetBool(soPlayerSetup.boolRunning, true);
        }
        else
        {
            animator.SetBool(soPlayerSetup.boolRunning, false);
        }

        if(rb.linearVelocity.x > 0)
        {
            rb.transform.DOScaleX(1, soPlayerSetup.swipeTransition);
            rb.linearVelocity += soPlayerSetup.friction;
        }
        else if(rb.linearVelocity.x < 0)
        {
            rb.transform.DOScaleX(-1, soPlayerSetup.swipeTransition);
            rb.linearVelocity -= soPlayerSetup.friction;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.linearVelocity = new Vector2(move * soPlayerSetup.runSpeed, rb.linearVelocity.y);
            animator.speed = 1.5f;
        }
        else
        {
            rb.linearVelocity = new Vector2(move * soPlayerSetup.speed, rb.linearVelocity.y);
            animator.speed = 1f;
        }
    }

    private void HandleJump()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(rb.linearVelocity.y != 0) return;
                
                animator.SetTrigger(soPlayerSetup.triggerJump);
                rb.linearVelocity = Vector2.up * soPlayerSetup.jumpForce;
            }
        }

    private void HandleFalling()
    {
        if(rb.linearVelocity.y < 0)
        {
            animator.SetBool(soPlayerSetup.boolFalling, true);
        }
        else
        {
            animator.SetBool(soPlayerSetup.boolFalling, false);
        }
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }

}
