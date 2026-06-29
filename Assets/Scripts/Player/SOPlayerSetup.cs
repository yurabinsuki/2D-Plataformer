using UnityEngine;

[CreateAssetMenu]
public class SOPlayerSetup : ScriptableObject
{
    
    [Header("Speed Setup")]
    public Vector2 friction = new Vector2(-0.1f, 0);
    public float speed;
    public float runSpeed;
    public float jumpForce = 6f;


    [Header("Player Animations")]
    public string boolRunning = "isRunning";
    public string triggerJump = "jump";
    public string boolFalling = "isFalling";
    public string triggerDeath = "Death";
    public float swipeTransition = 0.5f;


}
