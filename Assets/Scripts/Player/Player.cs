using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 velocity;

    public float speed;
    
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           rb.linearVelocity = new Vector2(-velocity.x, rb.linearVelocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           rb.linearVelocity = new Vector2(velocity.x, rb.linearVelocity.y);
        }
    }


}
