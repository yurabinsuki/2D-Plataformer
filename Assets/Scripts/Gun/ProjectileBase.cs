using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;

    public float timeToDestroy = 5f;

    public float side = 1f;

    public int damageAmount = 1;

    void Awake()
    {
        Destroy(gameObject, timeToDestroy);
    }   

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * side);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<EnemyBase>();
        if (enemy != null)
        {
            enemy.Damage(damageAmount);
            Destroy(gameObject);
        }
    }

}
