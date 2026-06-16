using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    public string attackTrigger = "Attack";
    public HealthBase health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var health = collision.transform.GetComponent<HealthBase>();

        if(health != null)
        {
            health.Damage(damage);
        }
    }

    private void Attack()
    {
        if (animator != null)
        {
            animator.SetTrigger(attackTrigger);
        }
    }

    public void Damage(int amount)
    {
        health.Damage(amount);
    }

}
