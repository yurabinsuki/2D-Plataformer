using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    public string attackTrigger = "Attack";
    public string deathTrigger = "Death";
    public HealthBase health;
    public float timeToDestroy = 1f;


    void Awake()
    {
        if(health != null)
        {
            health.OnKill += EnemyKilled;
        }
    }

    private void EnemyKilled()
    {
        health.OnKill -= EnemyKilled;
        Death();
        Destroy(gameObject, timeToDestroy);
    }

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
    private void Death()
    {
        if (animator != null)
        {
            animator.SetTrigger(deathTrigger);
        }
    }

    public void Damage(int amount)
    {
        health.Damage(amount);
    }

}
