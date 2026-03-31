using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 friction = new Vector2(-0.1f, 0);

    public float speed;
    public float jumpForce = 10f;


    //private bool _isJumping = false;
    
    void Update()
    {
        Jump(); 
        Movement();
    }

    private void Movement()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

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
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }


}
