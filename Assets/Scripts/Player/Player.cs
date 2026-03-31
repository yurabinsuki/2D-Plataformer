using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{

    [Header("Player Setup")]
    public Rigidbody2D rb;
    public Vector2 friction = new Vector2(-0.1f, 0);
    public float speed;
    public float runSpeed;
    public float jumpForce = 6f;

    [Header("Animation Setup")]
    public float jumpScaleY = 1.2f; 
    public float jumpScaleX= 0.7f; 
    public float animationDuration = 0.2f;
    public Ease easeType = Ease.OutBack;
    
    void Update()
    {
        Jump(); 
        Movement();
    }

    private void Movement()
    {
        
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(Input.GetKey(KeyCode.LeftShift) ? move * runSpeed : move * speed, rb.linearVelocity.y);


        if(rb.linearVelocity.x > 0)
        {
            rb.linearVelocity += friction;
        }
        else if(rb.linearVelocity.x < 0)
        {
            rb.linearVelocity -= friction;
        }
    }

    private void Jump()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.linearVelocity = Vector2.up * jumpForce;
                
                rb.transform.localScale = Vector2.one; // Reset scale before applying jump animation
                DOTween.Kill(rb.transform); // Kill any existing tweens on the transform to prevent conflicts

                JumpAnimation();
            }
        }

    private void JumpAnimation()
    {
        rb.transform.DOScaleY(jumpScaleY, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(easeType);  
        rb.transform.DOScaleX(jumpScaleX, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(easeType);  
    }


}
